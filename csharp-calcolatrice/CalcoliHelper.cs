using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalcoliHelper
    {
        //METODI STATICI

        //Metodo per sommare due numeri interi
        public static int CalcolaSommaInteri(int a, int b)
        {
            return a + b;
        }

        //Metodo per sommare due numeri decimali
        public static double CalcolaSommaDecimali(double c, double d)
        { 
            return c + d; 
        }
        //Metodo per sottrarre due numeri interi
        public static int CalcolaSottrazioneInteri(int e, int f) 
        {
            return e - f;
        }
        //Metodo per sottrarre due numeri decimali
        public static double CalcolaSottrazioneDecimali(double g, double h)
        { 
            return g - h; 
        }
        //Metodo per moltiplicare due numeri interi
        public static int CalcolaMoltiplicazioneInteri (int i, int l) 
        {
            return i * l;
        }
        //Metodo per moltiplicare due numeri decimali
        public static double CalcolaMoltiplicazioneDecimali (double m, double n)
        {
            return m * n;
        }
        //Metodo per calcolare valore assoluto di un numero intero
        public static int CalcolaValoreAssolutoInteri(int o) 
        {
            if (o < 0)
            {
                return o * -1;
            } else
            {
                return o;
            }
        }
        //Metodo per calcolare valore assoluto di un numero intero
        public static double CalcolaValoreAssolutoDecimali(double p)
        {
            if (p < 0)
            {
                return p * -1;
            }
            else
            {
                return p;
            }
        }
        //Metodo per calcolare il minimo tra due numeri interi
        public static int CalcolaMinimoTraDueInteri(int q, int r)
        {
            if (q < r)
            {
                return q;
            } else
            {
                return r;
            }
        }
        //Metodo per calcolare il minimo tra due numeri decimali
        public static double CalcolaMinimoTraDueDecimali(double s, double t)
        {
            if (s < t)
            {
                return s;
            }
            else
            {
                return t;
            }
        }
        //Metodo per calcolare il massimo tra due numeri interi
        public static int CalcolaMassimoTraDueInteri(int u, int v)
        {
            if (u > v)
            {
                return u;
            }
            else
            {
                return v;
            }
        }
        //Metodo per calcolare il massimo tra due numeri decimali
        public static double CalcolaMassimoTraDueDecimali(double w, double x)
        {
            if (w > x)
            {
                return w;
            }
            else
            {
                return x;
            }
        }

        //BONUS
        public static int ElevareDueNumeriAPotenza (int y, int z)
        {
           
            int accumulatore = 1;

            for (int i = 0; i < z; i++) 
            {
                accumulatore *= y;

            }
            return accumulatore;            
        }

    }
}
