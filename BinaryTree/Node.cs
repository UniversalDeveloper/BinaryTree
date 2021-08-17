using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Node
    {
        public int value;
        public Node left;
        public Node right;
         
        public Node (int initial)
        {
            value = initial;
            left = null;
            right = null;
        }
    }
}
