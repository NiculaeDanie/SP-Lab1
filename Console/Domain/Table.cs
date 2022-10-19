using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Table: Element
    {
        private string title { get; set; }

        public Table(string title) { this.title = title; }

        public void print()
        {
            Console.WriteLine(this.title);
        }

        public void add(Element element)
        {
            throw new NotImplementedException();
        }

        public void remove(Element element)
        {
            throw new NotImplementedException();
        }

        public Element get(int index)
        {
            throw new NotImplementedException();
        }
    }
}
