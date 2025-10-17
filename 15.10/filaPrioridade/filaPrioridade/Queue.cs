using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using filaPrioridade;


namespace filaPrioridade
{
    internal class Queue
    {
        private Person head;
        private Person tail;


        

        //bool EmptyQueue(Person p) { if (p == null) { return true; } else { return false; } }

        //public void AddPerson(Person a)
        //{
        //    if (EmptyQueue(head))
        //    {
        //        head = a;
        //        tail = a;
        //        a.Next = tail;
        //    }
        //    else
        //    {
        //        tail.Next = a;
        //        tail = a;
        //    }

        //}

        //public void RemovePerson()
        //{
        //    if (EmptyQueue(head))
        //    {
        //        Console.WriteLine("Fila vazia");
        //    }
        //    else
        //    {
        //        head = head.Next;
        //        if (head == null)
        //        {
        //            tail = null;
        //        }
        //    }
        //}

        //public int QueueSize()
        //{
        //    int size = 0;
        //    if (EmptyQueue(head)) { return 0; }
        //    else
        //    {
        //        Person a = head;
        //        do
        //        {
        //            size++;
        //            a = a.Next;

        //        } while (head != null);

        //        return size;
        //    }
        //}

        //public void ShowQueue()
        //{
        //    if (EmptyQueue(head))
        //    {
        //        Console.WriteLine("vazia");
        //    }
        //    else
        //    {
        //        Person a = head;
        //        while (a != null)
        //        {
        //            Console.WriteLine(a.Name);
        //            a = a.Next;
        //        }
        //    }
        //}


        public Queue()
        {
            head = null;
            tail = null;
        }

        public bool Empty()
        {
            return head == null;
        }

        public void pushQueue(Person p)
        {
            if (Empty())
            {
                this.head = p;
                this.tail = p;
            } else
            {
                this.tail.Next = p;
                this.tail = p;
            }
        }

        public Person popQueue() { 
        if(Empty())
            {
                return null;
            } else
            {
                head = head.Next;

            }
        }

    }
}
