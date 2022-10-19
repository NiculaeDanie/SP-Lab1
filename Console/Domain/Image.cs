using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Image: Element
    {
        private string url { get; set; }

        public Image(string imageName) { this.url = imageName; }

        public void print()
        {
            Console.WriteLine(url);
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
