namespace FunctionNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class of functions.
    /// </summary>
    public class Function
    {
        /// <summary>
        /// Function Map return new list with elements from the list with modifications func.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public List<int> Map(List<int> list, Func<int, int> func)
        {
            List<int> newList = new List<int>();
            foreach (var temp in list)
            {
                newList.Add(func(temp));
            }
            return newList;
        }
    }
}
