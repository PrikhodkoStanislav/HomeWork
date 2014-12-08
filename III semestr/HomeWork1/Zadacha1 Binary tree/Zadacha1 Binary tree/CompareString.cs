using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zadacha1_Binary_tree
{
    /// <summary>
    /// Comparator for elements with string type.
    /// </summary>
    public class CompareString : CompareInterface<string>
    {
        /// <summary>
        /// Function Compare for elements with string type.
        /// </summary>
        /// <param name="element1"></param>
        /// <param name="element2"></param>
        /// <returns></returns>
        public int Compare(string element1, string element2)
        {
            int counter = 0;
            while (counter != element1.Length && counter != element2.Length)
            {
                if (element1[counter] > element2[counter])
                {
                    return 1;
                }
                if (element1[counter] < element2[counter])
                {
                    return -1;
                }
                counter++;
            }
            if (counter == element1.Length)
            {
                if (counter == element2.Length)
                {
                    return 0;
                }
                return -1;
            }
            return 1;
        }
    }
}
