using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3._3
{
    class CREATESTACK
    {
        public class Node
        {
            public Node next;
            public object data;
        }
        public class  MyStack
        {
            Node top;
            public int count;
            public bool IsEmpty()
            {
                return top == null;
            }
            public void Push(object value)
            {
                Node n = new Node();
                n.data = value;
                n.next = top;
                top = n;
                count++;
            }
            public object Pop()
            {
                if (top == null)
                    return null;
                object value = top.data;
                top = top.next;
                count--;
                return value;
            }
        }
    }
}
