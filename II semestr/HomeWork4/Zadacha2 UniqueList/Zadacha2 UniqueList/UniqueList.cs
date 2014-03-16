namespace UniqueListNamespace
{
    using System;
    using ListNamespace;
    using MyExceptionNamespace;

    /// <summary>
    /// Class unique list.
    /// </summary>
    public class UniqueList : List
    {
        /// <summary>
        /// Insert to head of the unique list with exclusion.
        /// </summary>
        /// <param name="value"></param>
        public new void InsertToHead(int value)
        {
            if (this.Exist(value))
            {
                throw new MyException("This element already exist!");
            }
            else
            {
                base.InsertToHead(value);
            }
        }

        /// <summary>
        /// Insert to position of the unique list with exclusion.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position"></param>
        public new void InsertToPosition(int value, int position)
        {
            if (this.Exist(value))
            {
                throw new MyException("This element already exist!");
            }
            else
            {
                base.InsertToPosition(value, position);
            }
        }

        /// <summary>
        /// Remove value from the unique list with exclusion.
        /// </summary>
        /// <param name="value"></param>
        public new void RemoveElement(int value)
        {
            if (!this.Exist(value))
            {
                throw new MyException("This element is NOT in this list!");
            }
            else
            {
                base.RemoveElement(value);
            }
        }

    }
}
