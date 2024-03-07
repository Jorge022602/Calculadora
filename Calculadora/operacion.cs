using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class operacion
    {
        public bool EsNumerico(String num)
        { try
            {
                double x = Convert.ToInt32(num);
                return true;
            }
            catch (Exception){
                return false;
            }
        }
        public int Suma(int a, int b)
        { 
            return a + b;
        }
        public int Resta(int a, int b)
        { 
            return a - b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            try
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("No se puede dividir para cero");
                }
                return a / b;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return 0;
            }
        }

        public int Raiz(int a)
        {
            return (int)Math.Sqrt(a);
        }

        public int Potencia(int a,int b)
        {
            return (int)Math.Pow(a, b);
        }

        public int Logaritmo(int a, int b)
        {
            return (int)Math.Log(a, b);
        }

        public int ValorPI()
        {
            return (int)Math.PI;
        }
    }

}
