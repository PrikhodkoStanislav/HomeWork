namespace FunctionNamespace
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Function function = new Function();
            List<int> result = function.Map(new List<int>() { 1, 2, 3 }, x => x * 2);
            foreach(var temp in result)
            {
                Console.WriteLine(temp);
            }
        }
    }
}
