using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ImageProxy : Element, Picture
    {
        private string url { get; set; }
        private Image realImage { get; set; }
        public ImageProxy(string url)
        {
            this.url = url;
        }

        public void add(Element element)
        {
            throw new NotImplementedException();
        }

        public string Content()
        {
            throw new NotImplementedException();
        }

        public string dim()
        {
            throw new NotImplementedException();
        }

        public Element get(int index)
        {
            throw new NotImplementedException();
        }

        public void print()
        {
            loadImage().print();
        }

        public void remove(Element element)
        {
            throw new NotImplementedException();
        }

        public string Url()
        {
            throw new NotImplementedException();
        }
        public Image loadImage()
        {
            if (this.realImage == null)
            {
                realImage = new Image(url);
            }
            return realImage;
        }
    }
}
