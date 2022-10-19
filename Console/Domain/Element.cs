using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface Element
    {
        
        public void print();
        public void add(Element element);
        public void remove(Element element);
        public Element get(int index);
    }
}
