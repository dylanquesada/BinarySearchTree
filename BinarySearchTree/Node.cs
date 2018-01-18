using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        int data;
        Node left;
        Node right;


    public int Data
        {
            get { return data; }
        }
        public Node(int newData)
        {
            data = newData;
        }
    }
}
