namespace Zadacha3_FoldOnFunctionWithValue
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class of function.
    /// </summary>
    public class Function
    {
        /// <summary>
        /// Fold with func returns new value from the value and element of the list.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="value"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public int Fold(List<int> list, int value, Func<int, int, int> func)
        {
            foreach (var temp in list)
            {
                value = func(value, temp);
            }
            return value;
        }
    }
}
