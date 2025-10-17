using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackEx
{
    internal class Text
    {
        public string Value { get; set; }

        public Text Next { get; set; }

        public Text(string v) {
            this.Value = v;
            this.Next = null;
        }

        public void setValue(string v)
        {
            this.Value = v;
        }
        public override string ToString()
        {
            return Value;

        }
    }
}
