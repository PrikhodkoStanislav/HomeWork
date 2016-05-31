open System.Net
open System.IO
open System.Text.RegularExpressions

let infoAboutURL(url : string) =
    let fetchAsync(url : string) =
        async {
            let req = WebRequest.Create(url)
            let! resp = req.AsyncGetResponse()
            let stream = resp.GetResponseStream()
            let reader = new StreamReader(stream)
            let html = reader.ReadToEndAsync()
            let! htmlTask = Async.AwaitTask(html)
            do printfn "%s --- %d" url htmlTask.Length
        }

    let readHtml(url: string) =
        let req = WebRequest.Create(url)
        let resp = req.GetResponse()
        let stream = resp.GetResponseStream()
        let reader = new StreamReader(stream)
        let html = reader.ReadToEnd()
        html

    let regexExpression = new System.Text.RegularExpressions.Regex("<a.*href=\"http.*\">")
    let webPages = regexExpression.Matches(readHtml(url))
    let doWork = [for url in webPages -> 
                     let value = url.Value
                     fetchAsync(value.Substring(value.IndexOf("=\"") + 2 , value.IndexOf("\">") - value.IndexOf("=\"") - 2))
                     ]    
    Async.Parallel doWork |> Async.RunSynchronously |> ignore

infoAboutURL("http://se.math.spbu.ru/SE/Members/ylitvinov/13-44/resultsSpring2015_244_Yurii")