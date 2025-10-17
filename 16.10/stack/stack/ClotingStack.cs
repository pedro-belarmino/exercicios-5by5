using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class ClotingStack
    {
        public Clothing top { get; set; }

        public ClotingStack()
        {
            top = null;
        }

        public bool Empty()
        {
            return top == null;
        }

        public void AddStack(Clothing c)
        {
            if (Empty())
            {
                c.Next = null;
            }
            else
            {
                c.Next = top;
            }
            top = c;
        }

        public void RemoveStack()
        {
            if (Empty())
            {
                Console.WriteLine("pilha vazia :(");
            } else
            {
                top = top.Next;
            }

        }
    
    public void ShowStack()
        {
            if (Empty())
            {
                Console.WriteLine("Pilha vazia");
            } else
            {
                Clothing a = top;
                while (a.Next != null) {
                    Console.WriteLine(a.Next.ToString());
                    a = a.Next;
                }
            }
        }
    
    }

}
