using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Image: Element, Picture
    {
        private string url { get; set; }

        public Image(string imageName) { 
            this.url = imageName;
            try
            {
                Thread.Sleep(5000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

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

        public string Url()
        {
            throw new NotImplementedException();
        }

        public string dim()
        {
            throw new NotImplementedException();
        }

        public string Content()
        {
            throw new NotImplementedException();
        }
    }
}
