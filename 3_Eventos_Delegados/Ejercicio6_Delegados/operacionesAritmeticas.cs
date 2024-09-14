using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_Delegados
{
    delegate int delegado(int x,  int y);
    public class operacionesAritmeticas
    {
        public int suma(int x, int y)
        {
            return x + y;
        }

        public int multiplicacion(int x, int y)
        {
            return x * y; 
        }
    }
}
