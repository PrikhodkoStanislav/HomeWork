using System;

namespace ParseTreeNamespace
{
    /// <summary>
    /// Class operand.
    /// </summary>
    public class Operand : TreeElement
    {
        /// <summary>
        /// Value of operand.
        /// </summary>
        public int operand { get; set; }

        /// <summary>
        /// Constructor operand with value.
        /// </summary>
        /// <param name="value"></param>
        public Operand(TreeElement treeElement, int element)
        {
            this.operand = element;
            this.left = null;
            this.right = null;
            this.up = treeElement;
            if (treeElement.left == null)
            {
                treeElement.left = this;
            }
            else
            {
                treeElement.right = this;
            }
        }

        /// <summary>
        /// Print operand.
        /// </summary>
        public override void Print(ref string result)
        {
            Console.Write("{0} ", this.operand);
            result += this.operand.ToString() + " ";
            if (this == this.up.right)
            {
                Console.Write(") ");
                result += ") ";
            }
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
        /// Count operand.
        /// </summary>
        /// <returns></returns>
        public override int Count()
        {
            return this.operand;
        }
    }
}
