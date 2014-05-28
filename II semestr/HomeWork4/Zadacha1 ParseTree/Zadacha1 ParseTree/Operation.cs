using System;

namespace ParseTreeNamespace
{
    /// <summary>
    /// Class operation.
    /// </summary>
    public class Operation : TreeElement
    {
        public virtual char PrintCharElement()
        {
            return '#';
        }

        /// <summary>
        /// Print operation.
        /// </summary>
        public override void Print(ref string result)
        {
            Console.Write("( {0} ", this.PrintCharElement());
            result += "( " + this.PrintCharElement().ToString() + " ";
            if (this.left != null)
            {
                this.left.Print(ref result);
            }
            if (this.right != null)
            {
                this.right.Print(ref result);
            }
        }

        /// <summary>
        /// Count element by number1 and number2.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns></returns>
        public virtual int CountElement(int number1, int number2)
        {
            return 0;
        }

        /// <summary>
        /// Count operation.
        /// </summary>
        /// <returns></returns>
        public override int Count()
        {
            return CountElement(this.left.Count(), this.right.Count());
        }
    }
}
