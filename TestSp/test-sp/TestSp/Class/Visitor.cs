using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSp.Class
{
    public interface Visitor
    {
        void visitAn(An an);
        void visitGrupa(Grupa grupa);
        void visitSemigrupa(Semigrupa semigrupa);
        void visitStudent(Student student);
    }
}
