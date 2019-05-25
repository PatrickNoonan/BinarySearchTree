using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresCode.BinaryTree
{
    public class BinaryTree
    {
        //has
        public Node root;
        public Node current;
        public Node parent;

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
                //Console.WriteLine(root.info);
            }
            else
            {
                current = root;

                while (true)
                {
                    parent = current;
                    
                    if (num < current.info)
                    {
                        if (parent.left == null)
                        {
                            parent.left = new Node(num);
                            //Console.WriteLine(parent.left.info);
                            return;
                        }
                        else
                        {
                            current = parent.left;
                            //Console.WriteLine(current.info);
                        }
                    }
                    else if (num > current.info)
                    {
                        if (parent.right == null)
                        {
                            parent.right = new Node(num);
                            //Console.WriteLine(parent.right.info);
                            return;
                        }
                        else
                        {
                            current = parent.right;
                            //Console.WriteLine(current.info);
                        }
                    }
                    else
                    {
                        //num already on tree
                        break;
                    }
                }
            }
        }
        public object Search(int num, Node rootOrCurrent)
        {
            current = rootOrCurrent;

            if (current == null)
            {
                Console.WriteLine("Number not found");
            }      
            if (num == current.info)
            {
                Console.WriteLine(num);
            }
            if (num < current.info)

                return this.Search(num, current.left);

            else

                return this.Search(num, current.right);
        }
    }
}
