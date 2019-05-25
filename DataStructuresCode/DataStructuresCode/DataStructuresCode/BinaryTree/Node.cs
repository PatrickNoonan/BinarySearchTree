using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresCode.BinaryTree
{
    class Node
    {
        //has this
        public int info;
        public Node left;
        public Node right;

        //constructor
        public Node(int num)
        {
            info = num;
            left = null;
            right = null;
        }
        //does this
        public void NodeInfo()
        {
            Console.WriteLine(info);
            Console.ReadLine();
        }
    }
}