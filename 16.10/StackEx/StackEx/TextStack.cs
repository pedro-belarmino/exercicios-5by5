using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StackEx
{
    internal class TextStack
    {
        public Text top { get; set; }

        int counter = 0;

        public TextStack()
        {
            top = null;
        }

        public bool Empty()
        {
            return top == null;
        }
        public void PushStack(Text t)
        {
            if (Empty())
            {
                t.Next = null;
            }
            else
            {
            if(counter < 10)
                {
                    t.Next = top;
                    counter++;
                } else
                {
                    Console.WriteLine("Pilha cheia");
                }
            } 
            
        }
        public void PopStack()
        {
            if (Empty())
            {
                Console.WriteLine("ta vazio");
            }
            else
            {
                top = top.Next;
            }
        }

        public void ShowStack()
        {
            if (Empty())
            {
                Console.WriteLine("ta vazio");

            }
            else
            {
                Text t = top;
                while (t.Next != null)
                {
                    Console.WriteLine(t.Next.ToString());
                    t = t.Next;
                }
            }

        }
    }
}
