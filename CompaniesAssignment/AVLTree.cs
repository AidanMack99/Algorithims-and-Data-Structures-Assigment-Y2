using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompaniesAssignment
{
    class AVLTree<T> : BSTree<T> where T: IComparable
    {
        public void insertItem(T item)
        {
            if(!Contains(item))
            {
                insertItem(item, ref root);
            }
        }

        //insert item 
        //check if tree needs balanced
        //if so rotate accordingly 
        private void insertItem(T item,ref Node<T> tree)
        {
            if(tree==null)
            {
                tree = new Node<T>(item);
            }
            else if (item.CompareTo(tree.Data)<0)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data)<0)
            {
                insertItem(item, ref tree.Right);
            }
            tree.BalanceFactor = height(tree.Left) - height(tree.Right);
            if (tree.BalanceFactor<= -2)
            {
                rotateLeft(ref tree);
            }
            else if (tree.BalanceFactor>=2)
            {
                rotateRight(ref tree);
            }

        }

        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0)
            {
                rotateRight(ref tree.Right);
            }
            Node<T> root = tree;
            Node<T> newroot = tree.Right;
            root.Right = newroot.Left;
            newroot.Left = root;
            tree = newroot;
        }

        private void rotateRight(ref Node<T> tree)
        {
            if (tree.Left.BalanceFactor < 0)
            {
                rotateLeft(ref tree.Left);
            }
            Node<T> root = tree;
            Node<T> newroot = tree.Left;
            root.Left = newroot.Right;
            newroot.Right = root;
            tree = newroot;
        }

        public new void RemoveItem(T item)
        {
            if (root != null && Contains(item))
            {
                removeItem(item, ref root);
            }
            if (root != null)
            {
                balanceTree(ref root);
            }
        }

        private void removeItem(T item, ref Node<T> tree)
        {
            if (item.CompareTo(tree.Data) < 0 && tree.Left != null)
            {
                removeItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0 && tree.Right != null)
            {
                removeItem(item, ref tree.Right);
            }
            else if (tree.Left == null)
            {
                tree = tree.Right;
            }
            else if (tree.Right == null)
            {
                tree = tree.Left;
            }
            else
            {
                T newRoot = leastItem(tree.Right);
                tree.Data = newRoot;
                removeItem(newRoot, ref tree.Right);
            }
        }

        private T leastItem(Node<T> tree)
        {
            if (tree.Left == null)
            {
                return tree.Data;
            }
            else
            {
                return leastItem(tree.Left);
            }
        }


        private void balanceTree(ref Node<T> root)
        {
            if (root.Data != null)
            {
                root.BalanceFactor = height(root.Left) - height(root.Right);
                if (root.BalanceFactor <= -2)
                {
                    rotateLeft(ref root);
                }
                if (root.BalanceFactor >= 2)
                {
                    rotateRight(ref root);
                }
            }
        }
    }
}
