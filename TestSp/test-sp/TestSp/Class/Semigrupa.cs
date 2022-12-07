using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSp.Class
{
    public class Semigrupa: Element
    {
        public string title { get; set; }
        public List<Element> elements { get; set; }
        public Semigrupa(string title)
        {
            this.title = title;
            this.elements = new List<Element>();
        }
        public void print()
        {
            Console.WriteLine(this.title);
        }

        public Element add(Element element)
        {
            elements.Add(element);
            return this;
        }

        public void remove(Element element)
        {
            elements.Remove(element);
        }

        public Element get(int pos)
        {
            return elements[pos];
        }
        public void accept(Visitor visitor)
        {
            visitor.visitSemigrupa(this);
        }
    }
}
