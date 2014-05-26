using System;

namespace ParseTreeNamespace
{
    /// <summary>
    /// Class operand.
    /// </summary>
    public class Operand
    {
        /// <summary>
        /// Value of operand.
        /// </summary>
        private int operand { get; set; }

        /// <summary>
        /// Constructor operand with value.
        /// </summary>
        /// <param name="value"></param>
        public Operand(int value)
        {
            this.operand = value;
        }
        
        /// <summary>
        /// Return value of operand.
        /// </summary>
        /// <returns></returns>
        public int ReturnOperand()
        {
            return operand;
        }

        /// <summary>
        /// Print operand.
        /// </summary>
        public void Print()
        {
            Console.Write(operand);
        }
    }
}
