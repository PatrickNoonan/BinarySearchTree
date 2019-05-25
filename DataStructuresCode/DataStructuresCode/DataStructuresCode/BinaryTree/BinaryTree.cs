using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresCode.BinaryTree
{
    class BinaryTree
    {
        //has
        public Node root;
        public Node current;
        public Node parent;
        public Node leaf;

        //constructor
        public BinaryTree()
        {
            root = null;
        }

        //does this
        public void Add(int num)
        {
            if (root == null)
            {
                root = new Node(num);
            }
            else
            {







            }
        }
        public void Search(int num)
        {

        }
    }
}
