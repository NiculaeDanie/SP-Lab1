using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Paragraph: Element
    {
        private string text { get; set; }

        public Paragraph(string text) { this.text = text; }

        public void print()
        {
            Console.WriteLine(this.text);
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
