using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Section: Element
    {
        protected string title { get; set; }
        protected List<Element> element { get; set; }
        public Section(string title)
        {
            this.title = title;
            this.element = new List<Element>();
        }

        public void add(Element element)
        {
            this.element.Add(element);
        }

        public Element get(int index)
        {
            return this.element[index];
        }

        public void print()
        {
            Console.WriteLine(this.title);
            foreach (Element element in this.element)
            {
                element.print();
            }
        }

        public void remove(Element element)
        {
            this.element.Remove(element);
        }
    }
}
