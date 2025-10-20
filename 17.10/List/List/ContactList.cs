using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class ContactList
    {
        public Contact Head { get; set; }
        public Contact Tail { get; set; }
        public int Counter { get; set; }

        public ContactList()
        {
            this.Head = null;
            this.Tail = null;
            this.Counter = 0;
        }

        public void putContact(Contact c)
        {
            if (Empty())
            {
                StartAdd(c);
            }
            else
            {
                if (String.Compare(c.Name, this.Head.Name, StringComparison.Ordinal) < 0)
                {
                    StartAdd(c);
                }
                else
                {
                    if (String.Compare(c.Name, this.Head.Name, StringComparison.Ordinal) > 0)
                    {
                        EndAdd(c);
                    }
                    else
                    {
                        Contact next = this.Head;
                        Contact previous = null;

                        while (String.Compare(c.Name, next.Name, StringComparison.Ordinal) > 0)
                        {
                            previous = next;
                            next = next.Next;
                        }
                        MiddleAdd(previous, next, c);
                    }
                }
            }
        }


        public bool Empty()
        {
            return Head == null;
        }

        public void StartAdd(Contact c)
        {
            if (Empty())
            {
                this.Head = c;
                this.Tail = c;

            }
            else
            {
                c.Next = this.Head;
                this.Head = c;
            }
        }

        public void MiddleAdd(Contact previous, Contact next, Contact aux)
        {
            if (Empty())
            {
                StartAdd(aux);
            }
            else
            {
                previous.Next = aux;
                aux.Next = next;
            }
        }

        public void EndAdd(Contact c)
        {
            if (Empty())
            {
                StartAdd(c);
            }
            else
            {
                this.Tail.Next = c;
                this.Tail = c;
            }

        }

        public void StarRemove()
        {

        }

        public void MiddleRemove()
        {

        }

        public void EndRemove()
        {

        }

        public int Size()
        {
            return Counter;
        }

    }
}
