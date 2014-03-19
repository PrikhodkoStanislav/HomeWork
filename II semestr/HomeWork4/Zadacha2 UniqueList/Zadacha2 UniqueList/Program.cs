namespace Zadacha2_UniqueList
{
    using System;
    using UniqueListNamespace;

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
            catch (ExceptionExistElement e)
            {
                Console.WriteLine();
            }
        }
    }
}
