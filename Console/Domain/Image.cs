using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Image: Element
    {
        private string imageName { get; set; }

        public Image(string imageName) { this.imageName = imageName; }

        public void print()
        {
            Console.WriteLine(imageName);
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
