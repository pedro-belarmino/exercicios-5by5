using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public Contact Next { get; set; }

        public Contact()
        {
            Next = null;
        }


    }
}
