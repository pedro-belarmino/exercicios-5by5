using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace filaPrioridade
{
    internal class Bank
    {
        public Queue NomalQueue { get; set; }
        public Queue PriorityQueue{get; set;}
        public int counter {  get; set; }

        public Bank()
        {
            this.NomalQueue = new Queue();
            this.PriorityQueue = new Queue();
            this.counter = 0;
        }

        public Person GetClient()
        {
            if(this.NomalQueue.Empty() && this.PriorityQueue.Empty())
            {
                return null;
            } else
            {
                if (this.PriorityQueue.Empty())
                {
                    return NomalQueue.popQueue();
                }
                else if (this.NomalQueue.Empty())
                {
                    return PriorityQueue.popQueue();
                } else
                {
                    if(counter % 3 == 0)
                    {
                        this.counter++;
                        return PriorityQueue.popQueue();
                    } else
                    {
                        this.counter++;
                        return NomalQueue.popQueue();
                    }
                }

                
                     
                
            }
    }
}
