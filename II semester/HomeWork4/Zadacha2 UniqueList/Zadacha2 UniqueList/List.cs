namespace UniqueListNamespace
{
    /// <summary>
    /// Class list.
    /// </summary>
    public class List
    {
        private class ListElement
        {
            /// <summary>
            /// Next element.
            /// </summary>
            public ListElement Next { get; set; }

            /// <summary>
            /// Value of list element.
            /// </summary>
            public int Value { get; set; }
        }

        private ListElement head;

        /// <summary>
        /// Insert value in the head of the list.
        /// </summary>
        /// <param name="value"></param>
        public virtual void InsertToHead(int value)
        {
            var newElement = new ListElement()
            {
                Value = value,
                Next = head
            };
            head = newElement;
        }

        /// <summary>
        /// Return value of the position.
        /// If position bigger than number of elements in list then return -1.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public int ValueOfPosition(int position)
        {
            var element = head;
            if (element == null)
            {
                return -1;
            }
            for (int i = 0; i < position; i++)
            {
                if (element.Next == null)
                {
                    return -1;
                }
                element = element.Next;
            }
            return element.Value;
        }

        /// <summary>
        /// Insert value to position in list.
        /// If list is empty then insert to head.
        /// If number of elements in list less than posision then insert to end of list.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="position"></param>
        public virtual void InsertToPosition(int value, int position)
        {
            var element = head;
            if (element == null || position == 0)
            {
                InsertToHead(value);
                return;
            }
            for (int i = 0; i < position - 1; i++)
            {
                if (element.Next == null)
                {
                    break;
                }
                element = element.Next;
            }
            var newElement = new ListElement()
            {
                Value = value,
                Next = element.Next
            };
            element.Next = newElement;
        }

        /// <summary>
        /// Remove first element with value from the list.
        /// </summary>
        /// <param name="value"></param>
        public virtual void RemoveElement(int value)
        {
            var element = head;
            if (element == null)
            {
                return;
            }
            if (element.Value == value)
            {
                head = head.Next;
                return;
            }
            while (element.Next != null)
            {
                if (element.Next.Value == value)
                {
                    element.Next = element.Next.Next;
                    return;
                }
                element = element.Next;
            }
        }

        /// <summary>
        /// Remove element to position in list.
        /// If list is empty then this will be written to the console.
        /// If position bigger then number of elements of the list then this will be written.
        /// </summary>
        /// <param name="position"></param>
        public void RemoveElementToPosition(int position)
        {
            if (position == 0)
            {
                head = head.Next;
                return;
            }
            var element = head;
            if (element == null)
            {
                return;
            }
            for (int i = 0; i < position - 1; i++)
            {
                if (element.Next == null)
                {
                    return;
                }
                element = element.Next;
            }
            element.Next = element.Next.Next;
        }

        /// <summary>
        /// Clean all list.
        /// </summary>
        public void RemoveList()
        {
            head = null;
        }

        /// <summary>
        /// Return 'true' if list is empty and 'false' if it is not empty.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return (head == null);
        }

        /// <summary>
        /// Is value in the list?
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool Exist(int value)
        {
            var element = head;
            while (element != null)
            {
                if (element.Value == value)
                {
                    return true;
                }
                element = element.Next;
            }
            return false;
        }
    }
}
