namespace Zadacha2_UniqueList
{
    using System;
    using UniqueListNamespace;
    using MyExceptionNamespace;

    class Program
    {
        static void Main(string[] args)
        {
            UniqueList u = new UniqueList();
            try
            {
                u.InsertToHead(5);
                u.InsertToHead(5);
            }
            catch (MyException e)
            {
                Console.WriteLine(e.error);
            }
        }
    }
}
