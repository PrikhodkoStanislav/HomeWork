namespace UniqueListNamespace
{
    using System;

    /// <summary>
    /// Class unique list.
    /// </summary>
    public class UniqueList : List
    {
        /// <summary>
        /// Insert to head of the unique list with exclusion.
        /// </summary>
        /// <param name="value"></param>
        public override void InsertToHead(int value)
        {
            if (this.Exist(value))
            {
                throw new ExceptionExistElement();
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
        public override void InsertToPosition(int value, int position)
        {
            if (this.Exist(value))
            {
                throw new ExceptionExistElement();
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
        public override void RemoveElement(int value)
        {
            if (!this.Exist(value))
            {
                throw new ExceptionNotThisElement();
            }
            else
            {
                base.RemoveElement(value);
            }
        }

    }
}
