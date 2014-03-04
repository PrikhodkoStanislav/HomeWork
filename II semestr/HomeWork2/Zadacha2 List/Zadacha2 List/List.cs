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
            public int Value
            {
                get
                {
                    return eValue;
                }

                set
                {
                    this.eValue = value;
                }
            }

            private ListElement head = null;

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
                var element = head;
                while (element != null)
                {
                    var temp = element;
                    element = element.Next;
                    temp = null;
                }
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
}