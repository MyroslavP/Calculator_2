using System;

namespace Proj2
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                ConsoleKeyInfo PKey;


                Console.Write("\n\nFunkcjonalne menu programu: ");

                Console.WriteLine("\n\nA. Obliczenie wartości (sumy) zadanego szeregu potęgowego ");
                Console.WriteLine("B. Tablicowanie wartości zadanego szeregu potęgowego ");
                Console.WriteLine("C. Tablicowanie wartości pierwiatka kwadratowego, obliczanego metodą Herona, z wartości zadanego szeregu potęgowego ");
                Console.WriteLine("D. Tablicowanie wartości n-tego pierwiatka, obliczanego metodą Newtona, z wartości zadanego szeregu potęgowego ");

                Console.WriteLine("\n\nX. Zakonczenie (wyjscie z) programu ");


                Console.Write("\n\nNacisnij klawisz pszypisany odpowiedniej funkcjonalnosci z ktorej chcesz skorzystac:  ");

                PKey = Console.ReadKey();

                switch (PKey.Key)
                {

                    case ConsoleKey.A: // Suma
                        {

                            Console.Write("\n\n Jeżeli chcesz, aby program realizował obliczenia ze" +
                            "śledzeniem, to naciśnij klawisz T (lub t), \n\t a gdy naciśniesz dowolny inny" + "klawisz, to uznam, że rezygnujesz ze śledzenia: ");

                            bool Trace;

                            if (Console.ReadKey().Key == ConsoleKey.T)
                                Trace = true;
                            else
                                Trace = false;




                            Console.WriteLine("\n\nwpisz, jaki będzie element x ");

                            if (double.TryParse(Console.ReadLine(), out double x)) ;
                            else
                            {
                                Console.WriteLine("\n Error: błędne dane wejściowe");
                                break;

                            }
                            if (Trace == true)
                            {

                                Console.WriteLine("\nelement x będzie " + x);
                            }

                            
                            Console.WriteLine("\nwpisz, jaki będzie element Eps ");

                            if (float.TryParse(Console.ReadLine(), out float Eps) && (Eps >= 0) && (Eps <= 1)) ;
                            else
                            {
                                Console.WriteLine("\n Error: nieprawidłowe wejście lub logika Eps nie pasuje");
                                break;
                            }

                            if (Trace == true)
                            {

                                Console.WriteLine("\nelement Eps będzie " + Eps);
                            }

                            double sum = Sum(x, Eps, out int n);
                            Console.WriteLine("\n"+ "suma szeregu potęgowego: Suma = " + sum + ", i zsumowano " + n + " wyrazów szeregu przy dokłądności obliczeń: Eps =  " + Convert.ToString(Convert.ToDecimal(Eps)) );

                            break;
                        }
                    case ConsoleKey.B: // Wartości zadanego szeregu
                        {

                            Console.Write("\n\n Jeżeli chcesz, aby program realizował obliczenia ze" +
                           "śledzeniem, to naciśnij klawisz T (lub t), \n\t a gdy naciśniesz dowolny inny" + "klawisz, to uznam, że rezygnujesz ze śledzenia: ");

                            bool Trace;

                            if (Console.ReadKey().Key == ConsoleKey.T)
                                Trace = true;
                            else
                                Trace = false;



                            Console.WriteLine("\nwpisz, jaka będzie dolna granica xd ");
                            if (double.TryParse(Console.ReadLine(), out double xd)) ;
                            else
                            {
                                Console.WriteLine("\n Error: błędne dane wejściowe");
                                break;
                            }

                            if (Trace == true)
                            {

                                Console.WriteLine("\nelement xd będzie " + xd);
                            }


                            Console.WriteLine("\nwpisz, jaka będzie górna granica xg ");
                            if (double.TryParse(Console.ReadLine(), out double xg) && xg > xd) ;
                            else
                            {
                                Console.WriteLine("\n Error: niepoprawny wpis lub xd większe niż xg");
                                break;
                            }

                            if (Trace == true)
                            {

                                Console.WriteLine("\nelement xg będzie " + xg);
                            }


                            Console.WriteLine("\nwpisz, jaki będzie element h ");
                            if (double.TryParse(Console.ReadLine(), out double h)) ;
                            else
                            {
                                Console.WriteLine("\n Error: błędne dane wejściowe");
                                break;
                            }

                            if (Trace == true)
                            {

                                Console.WriteLine("\nelement h będzie " + h);
                            }


                            Console.WriteLine("\nwpisz, jaki będzie element Eps ");
                            if (float.TryParse(Console.ReadLine(), out float Eps) && (Eps >= 0) && (Eps <= 1)) ;
                            else
                            {
                                Console.WriteLine("\n Error: nieprawidłowe wejście lub logika Eps nie pasuje");
                                break;
                            }

                            if (Trace == true)
                            {

                                Console.WriteLine("\nelement Eps będzie " + Eps);
                            }


                            double x = xd;

                            Console.WriteLine($"\n{"Zmienna X",5} {"Suma szeregu S(x)",26} {"Liczba zsumowanych wyrazów",30}");
                            Console.WriteLine($"\n{"---------",5} {"-----------------",26} {"--------------------------",30}");
                            while (x < xg)
                            {
                                double sum = Sum(x, Eps, out int n);

                                Console.WriteLine($"\n{Math.Round(x,3),5} {Math.Round(sum,3),25} {n,20}");
                                x += h;

                            }
                            break;
                        }
                    case ConsoleKey.C: // Heron
                        {

                            Console.Write("\n\n Jeżeli chcesz, aby program realizował obliczenia ze" +
                        "śledzeniem, to naciśnij klawisz T (lub t), \n\t a gdy naciśniesz dowolny inny" + "klawisz, to uznam, że rezygnujesz ze śledzenia: ");

                            bool Trace;

                            if (Console.ReadKey().Key == ConsoleKey.T)
                                Trace = true;
                            else
                                Trace = false;






                            Console.WriteLine("\nwpisz, jaka będzie dolna granica xd ");
                            if (double.TryParse(Console.ReadLine(), out double xd)) ;
                            else
                            {
                                Console.WriteLine("\n Error: błędne dane wejściowe");
                                break;
                            }

                            if (Trace == true)
                            {

                                Console.WriteLine("\nelement xd będzie " + xd);
                            }


                            Console.WriteLine("\nwpisz, jaka będzie górna granica xg ");
                            if (double.TryParse(Console.ReadLine(), out double xg) && xg > xd) ;
                            else
                            {
                                Console.WriteLine("\n Error: niepoprawny wpis lub xd większe niż xg");
                                break;
                            }

                            if (Trace == true)
                            {

                                Console.WriteLine("\nelement xg będzie " + xg);
                            }


                            Console.WriteLine("\nwpisz, jaki będzie element h ");
                            if (double.TryParse(Console.ReadLine(), out double h)) ;
                            else
                            {
                                Console.WriteLine("\n Error: błędne dane wejściowe");
                                break;
                            }

                            if (Trace == true)
                            {

                                Console.WriteLine("\nelement h będzie " + h);
                            }


                            Console.WriteLine("\nwpisz, jaki będzie element Eps ");
                            if (float.TryParse(Console.ReadLine(), out float Eps) && (Eps >= 0) && (Eps <= 1)) ;
                            else
                            {
                                Console.WriteLine("\n Error: nieprawidłowe wejście lub logika Eps nie pasuje");
                                break;
                            }

                            if (Trace == true)
                            {

                                Console.WriteLine("\nelement Eps będzie " + Eps);
                            }

                            double x = xd;
                            Console.WriteLine($"\n{"Zmienna X",5} {"Suma szeregu S(x)",26} {"Liczba zsumowanych wyrazów",30} {"Pierwiastek kwadratowy",26} {"Licznik iteracji",22}");
                            Console.WriteLine($"\n{"---------",5} {"-----------------",26} {"--------------------------",30} {"----------------------",26} {"----------------",22}");
                            while (x < xg)
                            {

                                double sum = Sum(x, Eps, out int n1);
                                double her = Heron(sum, Eps, out int n2);
                                

                                Console.WriteLine($"\n{Math.Round(x,3),5} {Math.Round(sum,2),25} {n1,20} {Math.Round(her,2),33} {n2,24}");
                                x += h;

                            }
                            break;
                        }
                    case ConsoleKey.D: // Newton
                        {

                            Console.Write("\n\n Jeżeli chcesz, aby program realizował obliczenia ze" +
                     "śledzeniem, to naciśnij klawisz T (lub t), \n\t a gdy naciśniesz dowolny inny" + "klawisz, to uznam, że rezygnujesz ze śledzenia: ");

                            bool Trace;

                            if (Console.ReadKey().Key == ConsoleKey.T)
                                Trace = true;
                            else
                                Trace = false;






                            Console.WriteLine("\nwpisz, jaka będzie dolna granica xd ");
                            if (double.TryParse(Console.ReadLine(), out double xd)) ;
                            else
                            {
                                Console.WriteLine("\n Error: błędne dane wejściowe");
                                break;
                            }

                            if (Trace == true)
                            {

                                Console.WriteLine("\nelement xd będzie " + xd);
                            }


                            Console.WriteLine("\nwpisz, jaka będzie górna granica xg ");
                            if (double.TryParse(Console.ReadLine(), out double xg) && xg > xd) ;
                            else
                            {
                                Console.WriteLine("\n Error: niepoprawny wpis lub xd większe niż xg");
                                break;
                            }

                            if (Trace == true)
                            {

                                Console.WriteLine("\nelement xg będzie " + xg);
                            }


                            Console.WriteLine("\nwpisz, jaki będzie element h ");
                            if (double.TryParse(Console.ReadLine(), out double h)) ;
                            else
                            {
                                Console.WriteLine("\n Error: błędne dane wejściowe");
                                break;
                            }

                            if (Trace == true)
                            {

                                Console.WriteLine("\nelement h będzie " + h);
                            }


                            Console.WriteLine("\nwpisz, jaki będzie element Eps ");
                            if (float.TryParse(Console.ReadLine(), out float Eps) && (Eps >= 0) && (Eps <= 1)) ;
                            else
                            {
                                Console.WriteLine("\n Error: nieprawidłowe wejście lub logika Eps nie pasuje");
                                break;
                            }

                            if (Trace == true)
                            {

                                Console.WriteLine("\nelement Eps będzie " + Eps);
                            }


                            double x = xd;
                            int m = 1;

                            Console.WriteLine($"\n{"Zmienna X",5} {"Suma szeregu S(x)",26} {"Liczba zsumowanych wyrazów",30} {"N-ty pierwiastek z wartości szeregu",40} {"Liczba wykonanych iteracj",28}");
                            Console.WriteLine($"\n{"---------",5} {"-----------------",26} {"--------------------------",30} {"-----------------------------------",40} {"-------------------------",28}");
                            while (x < xg)
                            {
                                double sum = Sum(x, Eps, out int n1);
                                double newt = Newton(sum, m, Eps, out int n2);

                                Console.WriteLine($"\n{Math.Round(x,3),5} {Math.Round(sum,3),25} {n1,25} {Math.Round(newt,2),35} {n2,31}");
                                
                                x += h;
                                m++;
                            }
                            break;
                        }
                    case ConsoleKey.X:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }

            }
            static double Newton(double a, int n, double Eps, out int mpcount)
            {
                double mpxi, mpprev;
                mpcount = 0;

                mpxi = a;

                do
                {
                    mpprev = mpxi;
                    mpxi = ((n - 1) * mpprev + a / (float)Math.Pow(mpprev, n - 1)) / n;
                    mpcount++;
                } while (Math.Abs(mpxi - mpprev) >= Eps);

                return mpxi;
            }
            static double Sum(double x, double Eps, out int n)
            {

                double mpsum = 0;
                double mpprev = Eps + 1;
                n = 0;
                while (Math.Abs(mpsum - mpprev) >= Eps)
                {
                    double fact;

                    double up = Math.Pow((x + 1), n);

                    fact = 1;
                    for (int j = 1; j <= n; j++)
                    {
                        fact *= j;
                    }

                    mpprev = mpsum;

                    mpsum += up / fact;

                    n++;

                }
                return mpsum;
            }
            static double Heron(double x, double Eps, out int n)
            {
                double mpy = 3;
                double mp_prev = mpy + 2 * Eps;
                n = 0;
                while (Math.Abs(mpy - mp_prev) >= Eps)
                {
                    mp_prev = mpy;
                    mpy = 0.5 * (mpy + x / mpy);
                    n++;
                }
                return mpy;
            }
        }
    }
}