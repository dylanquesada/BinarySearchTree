using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        Node root;
        public BinarySearchTree()
        {

        }
        public void Add(int item)
        {
            Node node = new Node(item);
            if (root == null)
            {
                root = node;
                return;
            }
            Node current = root;
            bool placed = false;
            while (!placed)
            {
                if (node.Data > current.Data)
                {
                    current.right = current;
                    if (current == null)
                    {
                        current = node;
                        placed = true;
                    }
                }
                else
                {
                    current.left = current;
                    if (current == null)
                    {
                        current = node;
                        placed = true;
                    }
                }

            }
        }

    }
}
