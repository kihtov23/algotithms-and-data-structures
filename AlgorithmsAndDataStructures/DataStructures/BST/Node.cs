using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructuresLib.BST
{
    public class Node<T> where T : IComparable<T>
    {
        public T Value { get; set; }
        public Node<T> Left { get; private set; }
        public Node<T> Right { get; private set; }

        public Node(T value)
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
                    Left = new Node<T>(newValue);
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
                    Right = new Node<T>(newValue);
                }
                else
                {
                    Right.Insert(newValue);
                }
            }
        }

        public Node<T> Get(T value)
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
