using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {
        public static int CalcolaSommaInteri(int a, int b)
        {
            return a + b;
        }
        public static double CalcolaSommaDecimali(double c, double d)
        { 
            return c + d; 
        }

        public static int CalcolaSottrazioneInteri(int e, int f) 
        {
            return e - f;
        }

        public static double CalcolaSottrazioneDecimali(double g, double h)
        { 
            return g - h; 
        }
        public static int CalcolaMoltiplicazioneInteri (int i, int l) 
        {
            return i * l;
        }

        public static double CalcolaMoltiplicazioneDecimali (double m, double n)
        {
            return m * n;
        }

    }
}
