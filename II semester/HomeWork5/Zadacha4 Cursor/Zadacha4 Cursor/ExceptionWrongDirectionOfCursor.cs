namespace Zadacha4_Cursor
{
    using System;

    /// <summary>
    /// Exception that direction of cursor is wrong.
    /// </summary>
    [Serializable]
    public class ExceptionWrongDirectionOfCursor : Exception
    {
        /// <summary>
        /// Constructor exception with message:
        /// "This element already exist!".
        /// </summary>
        public ExceptionWrongDirectionOfCursor()
        {
            Console.Clear();
            Console.WriteLine("WrongDirectionOfCursor!");
        }
    }
}
