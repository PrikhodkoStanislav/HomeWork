namespace FunctionNamespace
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class of function.
    /// </summary>
    public class Function
    {
        public List<int> Filter(List<int> list, Func<int, bool> func)
        {
            return list.FindAll(i => func(i));
        }
    }
}
