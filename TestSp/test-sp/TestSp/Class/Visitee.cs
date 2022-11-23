using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSp.Class
{
    public interface Visitee
    {
        void accept(Visitor visitor);
    }
}
