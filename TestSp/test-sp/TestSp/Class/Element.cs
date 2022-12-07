using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSp.Class
{
    public interface Element: Visitee
    {
        void print();
        Element add(Element element);
        void remove(Element element);
        Element get(int pos);
    }
}
