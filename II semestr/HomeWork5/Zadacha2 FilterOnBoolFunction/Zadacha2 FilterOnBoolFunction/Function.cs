namespace FunctionNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class of function.
    /// </summary>
    public class Function
    {
        /// <summary>
        /// Filter elements of the list on the bool function.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public List<int> Filter(List<int> list, Func<int, bool> func)
        {
            return list.FindAll(i => func(i));
        }
    }
}
