namespace UniqueListNamespace
{
    using System;

    /// <summary>
    /// Excepion that this element is not in the list,
    /// but we work with him.
    /// </summary>
    [Serializable]
    public class ExceptionNotThisElement : Exception
    {
        /// <summary>
        /// Constructor exception with message:
        /// "This element is NOT in the list!".
        /// </summary>
        public ExceptionNotThisElement()
        {
            Console.WriteLine("This element is NOT in the list!");
        }
    }
}
