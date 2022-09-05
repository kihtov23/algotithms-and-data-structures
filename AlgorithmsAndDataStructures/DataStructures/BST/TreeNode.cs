namespace MyDataStructuresLib.BST
{
    public class TreeNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public TreeNode<T> Left { get; private set; }
        public TreeNode<T> Right { get; private set; }

        public TreeNode(T value)
        {
            Value = value;
        }

        public void Insert(T newValue)
        {
            int compare = Value.CompareTo(newValue);

            if (compare == 0)
                return;

            if (compare < 0)
            {
                if (Left == null)
                {
                    Left = new TreeNode<T>(newValue);
                }
                else
                {
                    Left.Insert(newValue);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = new TreeNode<T>(newValue);
                }
                else
                {
                    Right.Insert(newValue);
                }
            }
        }

        public TreeNode<T> Get(T value)
        {
            int compare = Value.CompareTo(value);
            if (compare == 0)
            {
                return this;
            }

            if (compare < 0)
            {
                if (Left != null)
                    return Left.Get(value);
            }
            else
            {
                if (Right != null)
                    return Right.Get(value);
            }

            return null;
        }

        public IEnumerable<T> TraversePreOrder()
        {
            var list = new List<T>();
            TraversePreOrder(list);
            return list;
        }

        private void TraversePreOrder(List<T> list)
        {
            list.Add(Value);

            if (Left != null)
                Left.TraversePreOrder(list);

            if (Right != null)
                Right.TraversePreOrder(list);
        }

        public IEnumerable<T> TraverseInOrder()
        {
            var list = new List<T>();

            TraverseInOrder(list);
            return list;
        }

        private void TraverseInOrder(List<T> list)
        {
            if (Left != null)
                Left.TraverseInOrder(list);

            list.Add(Value);

            if(Right != null) 
                Right.TraverseInOrder(list);
        }

        public IEnumerable<T> TraversePostOrder()
        {
            var list = new List<T>();

            TraversePostOrder(list);
            return list;
        }

        private void TraversePostOrder(List<T> list)
        {
            if (Left != null)
                Left.TraverseInOrder(list);

            if (Right != null)
                Right.TraverseInOrder(list);

            list.Add(Value);
        }

        public T Min()
        {
            if (Left != null )
                return Left.Min();
            return Value;
        }

        public T Max()
        {
            if ( Right != null )
                return Right.Max();
            return Value;
        }
    }
}
