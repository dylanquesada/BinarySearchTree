﻿using System;
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
                if(node.Data > current.Data)
                {
                    if (current.right == null)
                    {
                        current.right = node;
                        placed = true;
                    }
                    else
                    {
                        current = current.right;
                    }
                }
                else
                {
                    if(current.left == null)
                    {
                        current.left = node;
                        placed = true;
                    }
                    else
                    {
                        current = current.left;
                    }                    
                }                
            }
        }
        public void Search(int item)
        {
            if(root == null)
            {
                Console.WriteLine("Sorry, Root is 'Null'. Tree is empty. No search results matching '{0}'.", item);
            }
            Node current = root;
            bool found = false;
            while (!found)
            {
                if (current == null)
                {
                    
                }
                if (item == current.Data)
                {
                    Console.WriteLine("Number found: {0} matches {1}.", current.Data, item);
                    found = true;
                }

                if (item > current.Data)
                {
                    Console.WriteLine("Right");
                    if(current.right == null)
                    {
                        Console.WriteLine("Sorry, '{0}' was not found.", item);
                        return;
                    }
                    current = current.right;
                }
                else if(item < current.Data)
                {
                    Console.WriteLine("Left");
                    if (current.left == null)
                    {
                        Console.WriteLine("Sorry, '{0}' was not found.", item);
                        return;
                    }
                    current = current.left;
                }
                
            }
        }
    }
}
