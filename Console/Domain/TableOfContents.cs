using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TableOfContents: Element
    {
        public TableOfContents()
        {

        }

        public void add(Element element)
        {
            throw new NotImplementedException();
        }

        public Element get(int index)
        {
            throw new NotImplementedException();
        }

        public void print()
        {
            Console.WriteLine("Table of Contents");
        }

        public void remove(Element element)
        {
            throw new NotImplementedException();
        }
    }
}
