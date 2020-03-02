using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarySearchTree
{
    public class BinarySearchTree
    {
        public Node root;
        public Node temp;

        public void Insert(int data)
        {
            Node node = new Node(data);

            if (root == null)
            {
                root = node;
            }
            else
            {
                temp = root;

                while (true)
                {
                    if (data > temp.data)
                    {
                        if (temp.rightNode == null)
                        {
                            temp.rightNode = node;
                            break;
                        }
                        else
                        {
                            temp = temp.rightNode;
                        }
                    }
                    else if (data <= temp.data)
                    {
                        if (temp.leftNode == null)
                        {
                            temp.leftNode = node;
                            break;
                        }
                        else
                        {
                            temp = temp.leftNode;
                        }
                    }
                }

            }
        }

        public bool Search(int data)
        {
            temp = root;
            while (true)
            {
                if (data == temp.data)
                {
                    return true;
                }
                else if (data > temp.data)
                {
                    if (temp.rightNode == null)
                    {
                        return false;
                    }
                    else
                    {
                        temp = temp.rightNode;
                    }
                }
                else if (data < temp.data)
                {
                    if (temp.rightNode == null)
                    {
                        return false;
                    }
                    else
                    {
                        temp = temp.rightNode;
                    }
                }
            }
        }
    }
}
