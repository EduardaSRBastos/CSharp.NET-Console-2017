using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    public class Centro
    {
        private int x; private int y;
        public Centro(int xs, int ys)
        { x = xs; y = ys; }
        public void CoodCentro()
        { Console.WriteLine("Centro = ({ 0}, { 1})", x, y);}
    }
    
}
