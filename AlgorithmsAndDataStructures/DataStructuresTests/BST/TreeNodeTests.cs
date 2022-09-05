using FluentAssertions;
using MyDataStructuresLib.BST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructuresLib.Tests.BST
{
    internal class TreeNodeTests
    {
        private TreeNode<int> _treeNode;

        public List<int> _listPreOrder => new List<int> { 4, 2, 1, 3, 5 };
        public List<int> _listInOrder => new List<int> { 1, 2, 3, 4, 5 };
        public List<int> _listPostOrder => new List<int> { 1, 3, 2, 5, 4 };

        public TreeNodeTests()
        {
            _treeNode = new TreeNode<int>(4);
            _treeNode.Insert(2);
            _treeNode.Insert(1);
            _treeNode.Insert(3);
            _treeNode.Insert(5);
        }

        [Test]
        public void Test_TraversePreOrder()
        {
            // Act 
            var traversedTree = GetTraversedTree(_treeNode.TraversePreOrder);

            // Assert
            traversedTree.Should().BeEquivalentTo(_listPreOrder);
        }

        [Test]
        public void Test_TraverseInOrder()
        {
            // Act 
            var traversedTree = GetTraversedTree(_treeNode.TraverseInOrder);

            // Assert
            traversedTree.Should().BeEquivalentTo(_listInOrder);
        }

        [Test]
        public void Test_TraversePostOrder()
        {
            // Act 
            var traversedTree = GetTraversedTree(_treeNode.TraversePostOrder);

            // Assert 
            traversedTree.Should().BeEquivalentTo(_listPostOrder);
        }

        private List<int> GetTraversedTree(Func<IEnumerable<int>> traverse)
        {
            var traversedTree = new List<int>();
            foreach (var val in traverse())
            {
                traversedTree.Add(val);
            }
            return traversedTree;
        }
    }
}
