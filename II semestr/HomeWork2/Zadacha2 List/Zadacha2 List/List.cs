namespace ListNamespace
{
    using System;

    public class List
    {
        private class ListElement
        {
            private int eValue;
            public ListElement Next { get; set; }

            /// <summary>
            /// Getter and setter for value.
            /// </summary>
            public int Value { get; set; }
        }

        private ListElement head;

        /// <summary>
        /// Insert value in the head of the list.
        /// </summary>
        /// <param name="value"></param>
        public void InsertToHead(int value)
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
                if (element == null)
                {
                    return -1;
                }
                element = element.Next;
            }
            return element.Value;
        }

        /// <summary>
        /// Print all list on console.
        /// </summary>
        public void Print()
        {
            var element = head;
            while (element != null)
            {
                Console.WriteLine("Element = {0}", element.Value);
                element = element.Next;
            }
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