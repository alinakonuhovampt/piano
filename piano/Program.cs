using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            int[] a = { };

            Console.WriteLine("Выберите октаву: F3, F7, F8");

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.F7)
                {
                    a = Octave(7);
                    Console.WriteLine("Октава изменена на 7");
                }
                else if (key.Key == ConsoleKey.F3)
                {
                    a = Octave(3);
                    Console.WriteLine("Октава изменена на 3");
                }
                else if (key.Key == ConsoleKey.F5)
                {
                    a = Octave(5);
                    Console.WriteLine("Октава изменена на 5");
                }

                if (key.Key == ConsoleKey.A)
                {
                    Beep(a[0]);
                }
                else if ((key.Key == ConsoleKey.Q) || (key.Key == ConsoleKey.A) || (key.Key == ConsoleKey.Z))
                {
                    Beep(a[2]);
                }
                else if ((key.Key == ConsoleKey.W) || (key.Key == ConsoleKey.S) || (key.Key == ConsoleKey.X))
                {
                    Beep(a[3]);
                }
                else if ((key.Key == ConsoleKey.E) || (key.Key == ConsoleKey.D) || (key.Key == ConsoleKey.C))
                {
                    Beep(a[4]);
                }
                else if ((key.Key == ConsoleKey.R) || (key.Key == ConsoleKey.F) || (key.Key == ConsoleKey.V))
                {
                    Beep(a[5]);
                }
                else if ((key.Key == ConsoleKey.T) || (key.Key == ConsoleKey.G) || (key.Key == ConsoleKey.B))
                {
                    Beep(a[6]);
                }
                else if ((key.Key == ConsoleKey.Y) || (key.Key == ConsoleKey.H) || (key.Key == ConsoleKey.N))
                {
                    Beep(a[7]);
                }
                else if ((key.Key == ConsoleKey.U) || (key.Key == ConsoleKey.J) || (key.Key == ConsoleKey.M))
                {
                    Beep(a[8]);
                }
                else if ((key.Key == ConsoleKey.I) || (key.Key == ConsoleKey.K))
                {
                    Beep(a[9]);
                }
                else if ((key.Key == ConsoleKey.O) || (key.Key == ConsoleKey.L))
                {
                    Beep(a[10]);
                }
                else if (key.Key == ConsoleKey.P)
                {
                    Beep(a[11]);
                }


            }
        }

        static void Beep(int tap)
        {
            Console.Beep(tap, 500);
        }

        static int[] Octave(int octave)
        {
            int[] seven = { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
            int[] third = { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
            int[] five = { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };

            if (octave == 7)
            {
                return seven;
            }
            else if (octave == 3)
            {
                return third;
            }
            else if (octave == 5)
            {
                return five;
            }
            else
            {
                return null;
            }
        }
    }
}