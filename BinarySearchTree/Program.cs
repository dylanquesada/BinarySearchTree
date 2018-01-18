using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(31);
            tree.Add(32);
            tree.Add(50);
            tree.Add(100);
            tree.Add(35);
            tree.Search(35);
            Console.Read();
        }
    }
}
