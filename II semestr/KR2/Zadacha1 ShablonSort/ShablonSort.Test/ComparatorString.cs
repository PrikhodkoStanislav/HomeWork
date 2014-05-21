namespace ShablonSort.Test
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using InterfaceNamespace;

    public class ComparatorString : InterfaceComparator
    {
        private string element { get; set; }
        public void NewCompare(string newString)
        {
            this.element = newString;
        }

        public int CopareTo(string string2)
        {
            return (this.element.Length - string2.Length);
        }


    }
}
