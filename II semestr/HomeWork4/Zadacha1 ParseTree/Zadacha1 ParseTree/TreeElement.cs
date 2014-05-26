namespace ParseTreeNamespace
{
    /// <summary>
    /// Class element of the tree.
    /// </summary>
    public class TreeElement
    {
        /// <summary>
        /// Operand.
        /// </summary>
        private Operand operand { get; set; }

        /// <summary>
        /// Operation.
        /// If operation.ReturnOperation is not operation => this is operand with number.
        /// </summary>
        private Operation operation { get; set; }

        /// <summary>
        /// Left child of the tree element.
        /// </summary>
        private TreeElement left { get; set; }

        /// <summary>
        /// Right child of the tree element.
        /// </summary>
        private TreeElement right { get; set; }

        /// <summary>
        /// Up child of the tree element.
        /// </summary>
        private TreeElement up { get; set; }

        /// <summary>
        /// Constructor tree element with value-operation.
        /// </summary>
        /// <param name="value"></param>
        public TreeElement(char value)
        {
            this.operand = new Operand(0);
            this.operation = new Operation(value);
            this.left = null;
            this.right = null;
            this.up = null;
        }

        /// <summary>
        /// Constructor tree element with element-operand-number.
        /// Parent = treeElement.
        /// </summary>
        /// <param name="treeElement"></param>
        /// <param name="element"></param>
        public TreeElement(TreeElement treeElement, int element)
        {
            this.operand = new Operand(element);
            this.operation = new Operation('#');
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
        /// Return value-operation.
        /// </summary>
        /// <returns></returns>
        public char ReturnValue()
        {
            return this.operation.ReturnOperation();
        }

        /// <summary>
        /// Return number-operand.
        /// </summary>
        /// <returns></returns>
        public int ReturnNumber()
        {
            return this.operand.ReturnOperand();
        }

        /// <summary>
        /// Return left child.
        /// </summary>
        /// <returns></returns>
        public TreeElement ReturnLeft()
        {
            return this.left;
        }

        /// <summary>
        /// Return right child.
        /// </summary>
        /// <returns></returns>
        public TreeElement ReturnRight()
        {
            return this.right;
        }

        /// <summary>
        /// Return parent.
        /// </summary>
        /// <returns></returns>
        public TreeElement ReturnUp()
        {
            return this.up;
        }

        /// <summary>
        /// Write parent.
        /// </summary>
        /// <param name="up"></param>
        public void WriteUp(TreeElement up)
        {
            this.up = up;
        }

        /// <summary>
        /// Write left child.
        /// </summary>
        /// <param name="left"></param>
        public void WriteLeft(TreeElement left)
        {
            this.left = left;
        }

        /// <summary>
        /// Write right child.
        /// </summary>
        /// <param name="right"></param>
        public void WriteRight(TreeElement right)
        {
            this.right = right;
        }

    }
}
