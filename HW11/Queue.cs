using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11
{
    class Queue<T>
    {
        private T[] queue;
        public void enqueue(T value)
        {
            if (queue != null)
            {
                var arr = new T[queue.Length+1];
                for (int i = 0; i < queue.Length; i++)
                {
                    arr[i] = queue[i];
                }
                arr[arr.Length - 1] = value;
            }
            else
            {
                queue = new T[1];
                queue[0] = value;
            }
        }
        public T dequeue()
        {
            if (queue != null)
            {
                var a = queue[0];
                var arr = new T[queue.Length-1];
                for(int i = 1;i < arr.Length;i++){
                    arr[i-1] = queue[i];
                }
                queue = arr;
                return a;
            }
            else
            {
                throw new InvalidOperationException("No queue");
            }
        }
        
        public T peek()
        {
            if (queue != null)
            {
                return queue[0];
            }
            else
            {
                throw new InvalidOperationException("No queue");
            }
        }

        public int count()
        {
            return queue.Length;
        }
    }
}
