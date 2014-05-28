﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTreeNamespace
{
    /// <summary>
    /// Class operation difference.
    /// </summary>
    public class OperationDiff : Operation
    {
        /// <summary>
        /// Return '-'.
        /// </summary>
        /// <returns></returns>
        public override char PrintCharElement()
        {
            return '-';
        }

        /// <summary>
        /// Count difference.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public override int CountElement(int number1, int number2)
        {
            return (number1 - number2);
        }
    }
}
