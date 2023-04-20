using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW11
{
    class Node<T>
    {
        public T info { get; set; }
        public Node<T>? prev { get; set; }
        public Node<T>? next { get; set; }

        public Node(T Info) { info = Info; prev = next = null; }
    }
    class doubleLinkedList<T>
    {
        private Node<T>? head { get; set; }
        private Node<T>? current { get; set; }

        public void addLast(T value)
        {
            Node<T> el = new Node<T>(value);
            if (head == null)
            {
                head = el; current = el;
            }
            else
            {
                current.next = el;
                el.prev = current;
                current = el;
            }
        }
        public void remove(T val) 
        {
            Node<T> tmp = head;
            while (tmp != null) 
            {
                if (tmp.info.Equals(val))
                {
                    if (tmp == head)
                    {
                        tmp.next.prev = null;
                        head = tmp.next;
                        break;
                    }
                    else if(tmp == current)
                    {
                        tmp.prev.next = null;
                        current = tmp.prev;
                        break;
                    }
                    else
                    {
                        tmp.prev.next = tmp.next;
                        tmp.next.prev = tmp.prev;
                        break;
                    }
                }
                else
                {
                    tmp = tmp.next;
                }
            }
        }
        public int count()
        {
            int count = 0;
            Node<T> tmp = head;
            while (tmp != null)
            {
                count++;
                tmp = tmp.next;
            }
            return count;
        }
    }
}
