namespace SortNamespace
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using InterfaceNamespace;

    public class Sort
    {
        public void SortArray(ArrayList array, int length, InterfaceComparator Compare)
        {
            for (int j = 0; j < length - 1; j++)
            {
                for (int i = 0; i < (length - j); i++)
                {
                    Compare.NewCompare(array[i]);
                    if (Compare.CopareTo(array[i + 1]) > 0)
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
        }

        public void Swap(ArrayList array, int i, int j)
        {
            object element = array[i];
            array[i] = array[j];
            array[j] = element;
        }
    }
}
