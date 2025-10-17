using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using queue;

namespace queue
{
    internal class Queue
    {
            private Person head;
            private Person tail;


        bool EmptyQueue(Person p) { if (p == null) { return true; } else { return false; } }

        public void AddPerson(Person a)
        {
            if (EmptyQueue(head))
            {
                head = a;
                tail = a;
                a.Next = tail;
            }
            else
            {
                tail.Next = a;
                tail = a;
            }

        }

        public void RemovePerson()
        {
            if (EmptyQueue(head))
            {
                Console.WriteLine("Fila vazia");
            }
            else
            {
                head = head.Next;
                if (head == null)
                {
                    tail = null;
                }
            }
        }

        public int QueueSize()
        {
            int size = 0;
            if (EmptyQueue(head)) { return 0; }
            else
            {
                Person a = head;
                do
                {
                    size++;
                    a = a.Next;

                } while (head != null);

                return size;
            }
        }

        public void ShowQueue()
        {
            if (EmptyQueue(head))
            {
                Console.WriteLine("vazia");
            }
            else
            {
                Person a = head;
                while (a != null)
                {
                    Console.WriteLine(a.Name);
                    a = a.Next;
                }
            }
        }
    }
}
