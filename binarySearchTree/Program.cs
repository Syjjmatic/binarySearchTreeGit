using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Insert(100);
            binarySearchTree.Insert(50);
            binarySearchTree.Insert(110);
            binarySearchTree.Insert(25);
            binarySearchTree.Insert(55);
        }
    }
}
