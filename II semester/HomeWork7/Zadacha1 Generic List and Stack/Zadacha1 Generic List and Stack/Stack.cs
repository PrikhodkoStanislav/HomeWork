namespace StackNamespace
{
    using System;
    using ListNamespace;

    /// <summary>
    /// class of stack
    /// </summary>
    public class Stack<T>
    {
        /// <summary>
        /// push element with value to the stack
        /// </summary>
        /// <param name="value"></param>
        public void Push(T value)
        {
            list.InsertToHead(value);
        }

        /// <summary>
        /// return value from the stack and delete it from the stack
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            if (list.IsEmpty())
            {
                return default(T);
            }
            else
            {
                T variable = list.ValueOfPosition(0);
                list.RemoveElementToPosition(0);
                return variable;
            }
        }

        /// <summary>
        /// return value from the stack
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (list.IsEmpty())
            {
                return default(T);
            }
            else
            {
                T variable = list.ValueOfPosition(0);
                return variable;
            }
        }

        /// <summary>
        /// return 'true' if stack is empty and 'false' if it's not empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return (list.IsEmpty());
        }

        /// <summary>
        /// remove stack
        /// </summary>
        public void RemoveStack()
        {
            list.RemoveList();
        }

        private List<T> list = new List<T>();
    }
}