using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Table
    {
        public string title { get; set; }

        public Table(string title) { this.title = title; }

        public void print()
        {
            Console.WriteLine(this.title);
        }
    }
}
