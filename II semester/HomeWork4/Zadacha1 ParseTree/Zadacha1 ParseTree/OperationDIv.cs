using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTreeNamespace
{
    /// <summary>
    /// Class operation division.
    /// </summary>
    public class OperationDiv : Operation
    {
        /// <summary>
        /// Return '/'.
        /// </summary>
        /// <returns></returns>
        public override char PrintCharElement()
        {
            return '/';
        }

        /// <summary>
        /// Count operation division.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public override int CountElement(int number1, int number2)
        {
            if (number2 != 0)
            {
                return (number1 / number2);
            }
            else
            {
                throw new ExceptionDivisionBy0();
            }
        }
    }
}
