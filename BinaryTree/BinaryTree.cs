using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class BinaryTree
    {
        Node root;
       public BinaryTree()
        {
            root = null;
        }
        public BinaryTree(int initial)
        {
            root = new Node(initial);
        }
        public void add( int value)
        {
            // non - recurse add
            if(root== null)// the tree is empty
            {
                // add item as the base Node
                Node newNode = new Node(value);
                root = newNode;
                return;
            }
            Node currentNode = root;
            bool added = false;
            do
            {
                // traverse tree
                if (value < currentNode.value)
                {
                    // go left
                    if(currentNode.left== null)
                    {
                        // add the item
                        Node newNode = new Node(value);
                        currentNode.left = newNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }
                // go to right
                if (value >= currentNode.value)
                {
                    if (currentNode.right == null)
                    {
                        Node newNode = new Node(value);
                        currentNode.right = newNode;
                        added = true;
                    } else
                    {
                        currentNode = currentNode.right;
                    }
                }

            } while (!added);

        }
        public void addRc ( int value)
        {
            //recurse add
            addR(ref root, value);
        }
        private void addR(ref Node N , int value)
        {
            // privet recursive search for where to add the new Node
            if (N == null) {
                // Node does not exist add it here
                Node newNode = new Node(value);

                // set old Node reference to the newly created Node thus attaching it to the tree
                N = newNode;
                return; // end the function call and fall back
            }
             if (value< N.value)
            {
                addR(ref N.left, value);
                return;
            }
             if(value>= N.value)
            {
                addR(ref N.right, value);
                    return;

            }
        }
       
        public void print(Node N,ref  string s)
        {
            // write out the tree is sorted order to the string newString
            // impement string to recursion
            if (N == null)
            {
                N = root;
            }
            if(N.left!= null)
            {
                print(N.left, ref s);
                s = s + N.value.ToString().PadLeft(3);
            }
            if(N.right!= null)
            {
                print(N.right, ref s);
            }
        }
    }
}
