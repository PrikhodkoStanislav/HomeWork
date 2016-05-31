using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTreeNamespace
{
    /// <summary>
    /// Class operation sum.
    /// </summary>
    public class OperationSum : Operation
    {
        /// <summary>
        /// Return '+'.
        /// </summary>
        /// <returns></returns>
        public override char PrintCharElement()
        {
            return '+';
        }

        /// <summary>
        /// Count sum.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public override int CountElement(int number1, int number2)
        {
            return (number1 + number2);
        }
    }
}
