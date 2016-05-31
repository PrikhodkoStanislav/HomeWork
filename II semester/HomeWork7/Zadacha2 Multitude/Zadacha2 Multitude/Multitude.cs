namespace MultitudeNamespace
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Multitude<T> : IEnumerable
    {
        /// <summary>
        /// Constructor of multitude.
        /// </summary>
        public Multitude()
        {
            multitude = new List<T>();
        }

        /// <summary>
        /// Add element in the multitude.
        /// </summary>
        /// <param name="element"></param>
        public void AddElement(T element)
        {
            if (!this.ExistElement(element))
            {
                multitude.Add(element);
            }
        }

        /// <summary>
        /// Remove element from multitude.
        /// </summary>
        /// <param name="element"></param>
        public void RemoveElement(T element)
        {
            if (this.ExistElement(element))
            {
                multitude.Remove(element);
            }
        }

        /// <summary>
        /// Is element in the multitude?
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        public bool ExistElement(T element)
        {
            return multitude.Contains(element);
        }
        
        /// <summary>
        /// Unification elements from multi and multitude in multitude.
        /// </summary>
        /// <param name="multi"></param>
        public void Unification(Multitude<T> multi)
        {
            foreach (T element in multi)
            {
                if (!this.ExistElement(element))
                {
                    this.AddElement(element);
                }
            }
        }

        /// <summary>
        /// Intersection elements from multi and multitude in multitude.
        /// </summary>
        /// <param name="multi"></param>
        public void Intersection(Multitude<T> multi)
        {
            Multitude<T> variable = new Multitude<T>();
            foreach (T element in this)
            {
                variable.AddElement(element);
            }
            foreach (T element in variable)
            {
                if (!multi.ExistElement(element))
                {
                    this.RemoveElement(element);
                }
            }
        }

        /// <summary>
        /// Enumerator of multitude.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            foreach (var element in multitude)
            {
                yield return element;
            }
        }

        private List<T> multitude;
    }
}
