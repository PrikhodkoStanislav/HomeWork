open System.ComponentModel

let numberOfThreads = 100
let sum : int ref = ref 0

type backgroundWorkerFor100Threads(number) =
    let lengthOfArray = 1000000
    let array = Array.create lengthOfArray 1

    let startElement = number * (lengthOfArray / numberOfThreads)
    let finishElement = (number + 1) * (lengthOfArray / numberOfThreads) - 1

    let worker = new BackgroundWorker()

    let completed = new Event<_>()
    let error = new Event<_>()
    let cancelled = new Event<_>()
    let progress = new Event<_>()

    do worker.DoWork.Add(fun args -> 
        let rec partOfSum element finishPart  =
            if worker.CancellationPending then
                args.Cancel <- true
            elif (element < finishPart) then
               sum := !sum + array.[element]
               partOfSum (element + 1) finishPart
            else
               args.Result <- sum   
        partOfSum startElement finishElement)

    do worker.RunWorkerCompleted.Add(fun args ->
        if args.Cancelled then cancelled.Trigger ()
        elif args.Error <> null then error.Trigger args.Error
        else completed.Trigger (args.Result :?> int))

    do worker.ProgressChanged.Add(fun args ->
        progress.Trigger (args.ProgressPercentage, (args.UserState :?> 'a)))

    member x.WorkerCompleted = completed.Publish
    member x.WorkerCancelled = cancelled.Publish
    member x.WorkerError = error.Publish
    member x.ProgressChanged = progress.Publish

    member x.RunWorkerAsync() = worker.RunWorkerAsync()
    member x.CancelAsync() = worker.CancelAsync()

let backgroundWorkers = [|for i in 0 .. (numberOfThreads - 1) -> new backgroundWorkerFor100Threads(i)|]

for i in 0 .. (numberOfThreads - 1) do
   backgroundWorkers.[i].RunWorkerAsync()

// Strange results are received.
printfn "%d" !sum