using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set2_Probleme_Vonhala_Raul
{
    internal class Program
    {
        static void Prob1()
        {
            int n, nr = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1} ");
                int a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    nr++;
                }

            }
            Console.WriteLine($"In secventa sunt {nr} numere pare");
            Console.ReadKey();

        }
        static void Prob2()
        {
            int n, nrneg = 0, nrpoz = 0, nrzero = 0;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1} ");
                int a = int.Parse((Console.ReadLine()));
                if (a == 0)
                    nrzero++;
                if (a < 0)
                    nrneg++;
                if (a > 0)
                    nrpoz++;

            }
            Console.WriteLine($"In secventa sunt {nrneg} numere negative, {nrzero} numere de 0 si {nrpoz} numere pozitive");
            Console.ReadKey();

        }
        static void Prob3()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            int sum = 0, p = 1;
            int i = 1;
            if (n > 0)
                sum = sum + n * (n + 1) / 2;
            while (i <= n)
            {
                p = p * i;
                i++;
            }
            Console.WriteLine($"Suma este {sum}, iar produsul este {p}");
            Console.ReadKey();

        }
        static void Prob4()
        {
            int n;
            Console.WriteLine("Introduceti n ");
            n = int.Parse(Console.ReadLine());
            int poz = 0;
            Console.WriteLine("Introduceti numarul care sa se caute in secventa ");
            int a = int.Parse((Console.ReadLine()));
            bool ok = true;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1} ");
                int x = int.Parse((Console.ReadLine()));
                poz = i;
                if (a == x)
                    ok = true;
                else ok = false;


            }
            if (ok == true)
                Console.WriteLine($"Numarul se afla pe pozitia {poz} ");
            else
                Console.WriteLine("-1");
            Console.ReadKey();
        }
        static void Prob5()
        {
            int n;
            Console.WriteLine("Introduceti n ");
            n = int.Parse(Console.ReadLine());
            int poz = 0, nr = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1} ");
                int a = int.Parse((Console.ReadLine()));
                poz = i;
                if (a == poz)
                    nr++;

            }
            Console.WriteLine($"In secventa sunt {nr} numere egale cu pozitia lor");
            Console.ReadKey();
        }

        static void Prob6()
        {
            int n;
            Console.WriteLine("Introduceti n ");
            int minim = int.MinValue;
            bool ok = true;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1} ");
                int a = int.Parse((Console.ReadLine()));
                if (a < minim)
                    ok = false;
                minim = a;
            }
            if (ok)
                Console.WriteLine("Numerele sunt in ordine crescatoare");
            else
                Console.WriteLine("Numerele nu sunt in ordine crescatoare");
            Console.ReadKey();


        }
        static void Prob7()
        {
            int n;
            Console.WriteLine("Introduceti n ");
            int minim = int.MaxValue;
            int maxim = int.MinValue;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1} ");
                int a = int.Parse((Console.ReadLine()));
                if (a < minim)
                    minim = a;
                if (a > maxim)
                    maxim = a;
            }
            Console.WriteLine($"Minimul secventei este {minim}, iar maximul {maxim} ");
            Console.ReadKey();
        }
        static void Prob8()
        {
            long n, i, a, b, c=0;
            Console.WriteLine("Introduceti n ");
            n = int.Parse((Console.ReadLine()));
            if (n == 1 || n == 2)
                Console.WriteLine("1");
            else
            {
                a = 1;
                b = 1;
                for(i=3;i<=n;i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                Console.WriteLine($"Al {n} termen este {c}");
            }
            Console.ReadKey();
        }
        static void Prob9()
        {
            int n;
            Console.WriteLine("Introduceti n ");
            int minim = int.MinValue;
            bool ok = true;
            bool ok2 = true;
            int maxim = int.MaxValue;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1} ");
                int a = int.Parse((Console.ReadLine()));
                if (a < minim)
                    ok = false;
                minim = a;
                if (a > maxim)
                    ok2 = false;
                maxim = a;
            }
            if (ok || ok2)
            {
                Console.WriteLine("Sirul este monoton");

            }
            else
                Console.WriteLine("Sirul nu este monoton");
            Console.ReadKey();
        }
        
        static void Prob10()
        {
            int n,nr=0,nrmax=0,x,y;
            Console.WriteLine("Introduceti n ");
            n=int.Parse(Console.ReadLine());
            y=int.Parse(Console.ReadLine());
            nr++;
            for (int i = 1; i < n; i++)
            {
                x=int.Parse((Console.ReadLine()));
                if (x == y)
                    nr++;
                else
                {
                    nrmax = nr;
                    nr = 1;
                }
                y = x;
            }
            Console.WriteLine($"Lungimea maxima este {nr} ");
            Console.ReadKey();

        }

        static void Prob11()
        {
            int n;
            Console.WriteLine("Introduceti n ");
            n = int.Parse(Console.ReadLine());
            int s = 0;
            for(int i=0;i<n;i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1} ");
                int a = int.Parse((Console.ReadLine()));
                int cif = 0;
                while(a!=0)
                {
                    cif = cif * 10 + a % 10;
                    a = a / 10;
                }
                s=s + cif;
            }
            Console.WriteLine($"Suma este {s} ");
            Console.ReadKey();
        }

        static void Prob12()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti elementele secventei, separate printr-un spatiu:");

            string[] a = Console.ReadLine().Split(' ');

            int nr = 0;
            bool ok = false;

            for (int i = 0; i < n; i++)
            {
                if (a[i] != "0")
                {
                    // Suntem într-un grup
                    if (!ok)
                    {
                        nr++;
                        ok = true;
                    }
                }
                else
                {
                    // Suntem în afara unui grup
                    ok = false;
                }
            }

            Console.WriteLine($"Numarul de grupuri de numere consecutive este {nr}");
            Console.ReadKey();
        }

        static void Prob13()
        {
            Console.WriteLine("Introduceti secventa de numere separate prin spatiu:");
            string v = Console.ReadLine();
            int nrant = int.MaxValue; 
            bool verif = true;
            foreach (char caracter in v)
            {
                if (caracter == ' ')
                    continue;
                int nr = int.Parse(caracter.ToString());
                if (nr > nrant)
                {
                    if (!verif)
                    {
                        Console.WriteLine("Secventa nu este o secventa crescatoare rotita.");
                        return;
                    }
                }
                else
                {
                    verif = false;
                }
                nrant = nr;
            }

            Console.WriteLine("Secventa este o secventa crescatoare rotita.");
            

        }
        static void Prob14()
        {
            Console.WriteLine("Introduceti secventa de numere separate prin spatiu:");
            string v = Console.ReadLine();

            int nrant = int.MaxValue; 
            bool verif = true;

            foreach (char caracter in v)
            {
                if (caracter == ' ')
                    continue;

                int nr = int.Parse(caracter.ToString());
                if (nr > nrant)
                {
                    if (!verif)
                    {
                        Console.WriteLine("Secventa nu este o secventa monotona rotita.");
                        return;
                    }
                }
                else if (nr < nrant)
                {
                    
                    if (!verif)
                    {
                        Console.WriteLine("Secventa este o secventa monotona rotita.");
                        return;
                    }
                }

                verif = false;
                nrant = nr;
            }

            Console.WriteLine("Secventa este o secventa monotona rotita.");
        }

        static void Prob15()
        {
            Console.WriteLine("Introduceti secventa de numere separate prin spatiu:");
            string v = Console.ReadLine();

            int nrant = int.MinValue;
            bool crescatoare = true;
            bool descrescatoare = false;

            foreach (char caracter in v)
            {
                if (caracter == ' ')
                    continue;

                int nr = int.Parse(caracter.ToString());

                if (nr > nrant)
                {
                    if (descrescatoare)
                    {
                        Console.WriteLine("Secventa nu este bitonica.");
                        return;
                    }
                    crescatoare = true;
                }
                else if (nr < nrant)
                {
                    descrescatoare = true;
                }

                nrant = nr;
            }

           
            if (crescatoare && descrescatoare)
            {
                Console.WriteLine("Secventa este bitonica.");
            }
            else
            {
                Console.WriteLine("Secventa nu este bitonica.");
            }
        }

        static void Prob16()
        {
            Console.WriteLine("Introduceti secventa de numere separate prin spatiu:");
            string v = Console.ReadLine();

            int nrant = int.MinValue;
            bool crescatoare = true;
            bool descrescatoare = false;

            foreach (char caracter in v)
            {
                if (caracter == ' ')
                    continue;

                int nr = int.Parse(caracter.ToString());


                if (nr > nrant)
                {
                    if (descrescatoare)
                    {
                        Console.WriteLine("Secventa nu este o secventa bitonica rotita.");
                        return;
                    }
                    crescatoare = true;
                }
                else if (nr < nrant)
                {
                    descrescatoare = true;
                }

                nrant = nr;
            }


            if (crescatoare && descrescatoare)
            {
                Console.WriteLine("Secventa este o secventa bitonica rotita.");
            }
            else
            {

                if (crescatoare)
                {
                    Console.WriteLine("Secventa este o secventa bitonica rotita.");
                }
                else
                {
                    Console.WriteLine("Secventa nu este o secventa bitonica rotita.");
                }
            }
        }

        static void Prob17()
        {
            Console.WriteLine("Introduceti secventa de 0 si 1 separate prin spatiu:");
            string v = Console.ReadLine();

            int inchis = 0;
            int inchismaxim = 0;

            foreach (char caracter in v)
            {
                
                if (caracter != '0' && caracter != '1')
                {
                    Console.WriteLine("Secventa contine caractere invalide.");
                    return;
                }

                int paranteza = int.Parse(caracter.ToString());

                
                if (paranteza == 0)
                {
                    inchis++;

                  
                    if (inchis > inchismaxim)
                        inchismaxim = inchis;
                }
                else
                {
                    inchis--;

                    
                    if (inchis < 0)
                    {
                        Console.WriteLine("Secventa este incorecta.");
                        return;
                    }
                }
            }

            
            if (inchis == 0)
            {
                Console.WriteLine($"Secventa este corecta și nivelul maxim de incuibare este {inchismaxim}.");
            }
            else
            {
                Console.WriteLine("Secventa este incorecta.");
            }
        }
        static void Main(string[] args)
        {
            Prob1();
            //Prob2();
            //Prob3();
            //Prob4();
            //Prob5();
            //Prob6();
            //Prob7();
            //Prob8();
            //Prob9();
            //Prob10();
            //Prob11();
            //Prob12();
            //Prob13();
            //Prob14();
            //Prob15();
            //Prob16();
            //Prob17();
            Console.ReadKey();
        }
    }
}
