using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadoraCarro.Entities
{
    public class Menu
    {
        //public static int Choice { get; set; }
        //public static List<string> Options { get; set; }
        //public static string Title { get; set; }

        //public Menu(string t, List<string> options)
        //{
        //    Title = t;
        //    Options = options;
        //}
        public static int Display(string t, List<string> o)
        {
            Console.WriteLine(t);
            for (int i = 0; i < o.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {o[i]}");
            }
            Console.WriteLine("escolhe ai");
            return int.Parse(Console.ReadLine() ?? "0");
        }
    }
}
