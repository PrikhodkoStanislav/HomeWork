using System;

namespace ParseTreeNamespace
{
    using System;

    /// <summary>
    /// Exception that division by 0.
    /// </summary>
    [Serializable]
    public class ExceptionDivisionBy0 : Exception
    {
        /// <summary>
        /// Constructor exception with message:
        /// "Division by 0!".
        /// </summary>
        public ExceptionDivisionBy0()
        {
            Console.WriteLine("Division by 0!");
        }
    }
}
