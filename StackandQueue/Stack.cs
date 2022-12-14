using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueue
{
    class Node
    {
        //Creating node a top
        public Node top;
        public Node next;
        private int newData;
        private int data;

        public Node (int newData)
        {
            this.newData = newData;
        }
        public void Push(int newData)
        {
            Node newNode = new Node(newData);
            Node newnode = new(newData);
            if (this.top != null)
            {
                newNode.next = this.top;
            }
            this.top = newNode;
            Console.WriteLine("New Node {0} is added ", newNode.data);
        }
        public void Display()
        {
            Node temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("No values to be added");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine("Value in te stack " + temp.data);
                temp = temp.next;
            }
        }
    }
}
