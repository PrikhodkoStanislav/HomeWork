namespace UniqueListNamespace
{
    using System;

    /// <summary>
    /// Exception that element already exist.
    /// </summary>
    [Serializable]
    public class ExceptionExistElement : Exception
    {
        /// <summary>
        /// Constructor exception with message:
        /// "This element already exist!".
        /// </summary>
        public ExceptionExistElement()
        {
            Console.WriteLine("This element already exist!");
        }
    }
}
