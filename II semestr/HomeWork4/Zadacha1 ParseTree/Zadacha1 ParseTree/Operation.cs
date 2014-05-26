using System;

namespace ParseTreeNamespace
{
    /// <summary>
    /// Class operation.
    /// </summary>
    public class Operation
    {
        /// <summary>
        /// Value of operation.
        /// </summary>
        private char operation { get; set; }

        /// <summary>
        /// Constructor operation with value.
        /// </summary>
        /// <param name="value"></param>
        public Operation(char value)
        {
            this.operation = value;
        }

        /// <summary>
        /// Return value of operation.
        /// </summary>
        /// <returns></returns>
        public char ReturnOperation()
        {
            return operation;
        }

        /// <summary>
        /// Print operation.
        /// </summary>
        public void Print()
        {
            Console.Write(operation);
        }
    }
}
