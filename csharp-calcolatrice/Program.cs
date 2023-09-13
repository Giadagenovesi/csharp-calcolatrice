namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] calcoliEseguibili = { "Somma di due numeri interi", "Somma di due numeri double", "Differenza tra due numeri interi", "Differenza tra due numeri double", "Moltiplicazione di due numeri interi", "Moltiplicazione di due numeri double", "Valore assoluto di un numero intero", "Valore assoluto di un numero double", "Minimo tra due numeri interi", "Minimo tra due numeri double", "Massimo tra due numeri interi", "Massimo tra due numeri double", "Eleva a potenza" };

            int operazioneScelta;

            Console.WriteLine("Quale operazione matematica vorresti eseguire");
            for (int i = 0; i < calcoliEseguibili.Length; i++) 
            {
                Console.WriteLine($"{i + 1}. {calcoliEseguibili[i]}");
            }

            operazioneScelta = int.Parse(Console.ReadLine());

            switch (operazioneScelta)
            {
                //Somma di due numeri interi
                case 1:
                    Console.WriteLine("Inserisci i due numeri interi che vuoi sommare");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine()); 
                    
                    int risultato = CalcoliHelper.CalcolaSommaInteri(a, b);

                    Console.WriteLine(risultato);
                    break;

                //Somma di due numeri double
                case 2:
                    Console.WriteLine("Inserisci i due numeri decimali che vuoi sommare");
                    double c = double.Parse(Console.ReadLine());
                    double d = double.Parse(Console.ReadLine());

                    double risultato2 = CalcoliHelper.CalcolaSommaDecimali(c, d);
                    Console.WriteLine(risultato2);
                    break;

                //Differenza tra due numeri interi
                case 3:
                    Console.WriteLine("Inserisci i due numeri interi che vuoi sottrarre");
                    int e = int.Parse(Console.ReadLine());
                    int f  = int.Parse(Console.ReadLine());

                    int risultato3 = CalcoliHelper.CalcolaSottrazioneInteri(e, f);

                    Console.WriteLine(risultato3);
                    break;
                //Differenza tra due numeri double
                case 4:
                    Console.WriteLine("Inserisci i due numeri decimali che vuoi sottrarre");
                    double g = double.Parse(Console.ReadLine());
                    double h = double.Parse(Console.ReadLine());

                    double risultato4 = CalcoliHelper.CalcolaSottrazioneDecimali(g, h);

                    Console.WriteLine(Math.Round(risultato4, 2));
                    break;

                //Moltiplicazione di due numeri interi
                case 5:
                    Console.WriteLine("Inserisci i due numeri interi che vuoi moltiplicare");
                    int i = int.Parse(Console.ReadLine());
                    int l = int.Parse(Console.ReadLine());

                    int risultato5 = CalcoliHelper.CalcolaMoltiplicazioneInteri(i, l);
                    Console.WriteLine(risultato5);
                    break;

                //Moltiplicazione di due numeri double
                case 6:
                    Console.WriteLine("Inserisci i due numeri decimali che vuoi moltiplicare");
                    double m = double.Parse(Console.ReadLine());
                    double n = double.Parse(Console.ReadLine());

                    double risultato6 = CalcoliHelper.CalcolaMoltiplicazioneDecimali(m, n);
                    Console.WriteLine(Math.Round(risultato6, 2)); 
                    break;

                //Valore assoluto di un numero intero
                case 7:
                    Console.WriteLine("Inserisci il numero intero di cui vuoi conoscere il valore assoluto");
                    int o = int.Parse(Console.ReadLine());

                    int risultato7 = CalcoliHelper.CalcolaValoreAssolutoInteri(o);
                    Console.WriteLine(risultato7);
                break;

                //Valore assoluto di un numero intero
                case 8:
                    Console.WriteLine("Inserisci il numero decimale di cui vuoi conoscere il valore assoluto");
                    double p = double.Parse(Console.ReadLine());

                    double risultato8 = CalcoliHelper.CalcolaValoreAssolutoDecimali(p);
                    Console.WriteLine(risultato8);
                    break;

                //Minimo tra due numeri interi
                case 9:
                    Console.WriteLine("Inserisci i due numeri interi  di cui vuoi conoscere il minimo");
                    int q = int.Parse(Console.ReadLine());
                    int r = int.Parse(Console.ReadLine());

                    int risultato9 = CalcoliHelper.CalcolaMinimoTraDueInteri(q, r);
                    Console.WriteLine(risultato9);
                    break;

                //Minimo tra due numeri double
                case 10:
                    Console.WriteLine("Inserisci i due numeri decimali  di cui vuoi conoscere il minimo");
                    double s = double.Parse(Console.ReadLine());
                    double t = double.Parse(Console.ReadLine());

                    double risultato10 = CalcoliHelper.CalcolaMinimoTraDueDecimali(s, t);
                    Console.WriteLine(risultato10);
                    break;

                //Massimo tra due numeri interi
                case 11:
                    Console.WriteLine("Inserisci i due numeri interi  di cui vuoi conoscere il massimo");
                    int u = int.Parse(Console.ReadLine());
                    int v = int.Parse(Console.ReadLine());

                    int risultato11 = CalcoliHelper.CalcolaMassimoTraDueInteri(u, v);
                    Console.WriteLine(risultato11);
                    break;

                //Minimo tra due numeri double
                case 12:
                    Console.WriteLine("Inserisci i due numeri decimali  di cui vuoi conoscere il massimo");
                    double w = double.Parse(Console.ReadLine());
                    double x = double.Parse(Console.ReadLine());

                    double risultato12 = CalcoliHelper.CalcolaMassimoTraDueDecimali(w, x);
                    Console.WriteLine(risultato12);
                    break;

                //BONUS
                case 13:
                    Console.WriteLine("inserisci il numero che vuoi elevare a potenza");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine("inserisci il numero che vuoi che corrisponda  alla potenza");
                    int z = int.Parse(Console.ReadLine());

                    int risultato13 = CalcoliHelper.ElevareDueNumeriAPotenza(y, z);
                    Console.WriteLine(risultato13);
                    break;

            }

        }
    }
}