/* BinaryTreeNode.cs
 * Author: Rod Howell */
using KansasStateUniversity.TreeViewer2;

namespace Ksu.Cis300.PriorityQueueLibrary
{
    /// <summary>
    /// An immutable generic binary tree node that can draw itself.
    /// </summary>
    /// <typeparam name="T">The type of the elements stored in the tree.</typeparam>
    public partial class LeftistTree<T> : ITree
    {
        /// <summary>
        /// Gets the data stored in this node.
        /// </summary>
        public T Data { get; }

        /// <summary>
        /// Gets this node's left child.
        /// </summary>
        public LeftistTree<T> LeftChild { get; }

        /// <summary>
        /// Gets this node's right child.
        /// </summary>
        public LeftistTree<T> RightChild { get; }

        /// <summary>
        /// length of null path
        /// </summary>
        private int _nullPathLength;

        /// <summary>
        /// Constructs a BinaryTreeNode with the given data, left child, and right child.
        /// </summary>
        /// <param name="data">The data stored in the node.</param>
        /// <param name="child1">a child.</param>
        /// <param name="child2">another child.</param>
        public LeftistTree(T data, LeftistTree<T> child1, LeftistTree<T> child2)
        {
            if (NullPathLength(child1) > NullPathLength(child2))
            {
                RightChild = child2;
                LeftChild = child1;
            }
            else
            {
                RightChild = child1;
                LeftChild = child2;
            }
            Data = data;
            _nullPathLength = NullPathLength(RightChild) + 1;
        }

        /// <summary>
        /// returns the length of a node from the bottom of a tree
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static int NullPathLength(LeftistTree<T> t)
        {
            if(t == null)
            {
                return 0;
            }
            else
            {
                return t._nullPathLength;
            }
        }


    }
}
