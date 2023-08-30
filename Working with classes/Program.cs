using System;
using System.ComponentModel.Design;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;

namespace Working_with_classes
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void ShowData()
        {
            Console.WriteLine($"X: {x}");
            Console.WriteLine($"Y: {y}");
        }
    }

    public class Counter
    {
        public int x { get; set; }
        public int y { get; set; }
        public Counter(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Increment()
        {
            if (x < y)
            {
                x++;
            }
            else if (x == y)
            {
                x = 0;
            }
            else
                throw new Exception("max hedde catildi");
        }

        public int getCurrent() => x;

        public void Decrement()
        {
            if (x > 0)
                x--;
            else
                Console.WriteLine("Menfi ola bilmez");
        }
    }

    public class Fraction
    {
        public int Suret { get; set; }
        public int Mexrec { get; set; }


        public Fraction()
        {
            this.Suret = 0;
            this.Mexrec = 0;
        }
        public Fraction(int mexrec, int suret)
        {
            this.Mexrec = mexrec;
            this.Suret = suret;
        }

        public int EKOB(int num_1, int num_2)
        {
            int EKOB;
            int savedNum1 = num_1;
            int savedNum2 = num_2;

            while (1 > 0)
            {
                if (num_1 > num_2)
                {
                    num_1 += savedNum1;
                    if (num_1 % num_2 == 0)
                    {
                        EKOB = num_1;
                        break;
                    }
                    else if (num_2 > num_1)
                    {
                        num_2 += savedNum2;
                        if (num_2 % num_1 == 0)
                        {
                            EKOB = num_2;
                            break;

                        }
                    }
                }
            }

            return EKOB;

        }
        public Fraction add(Fraction f2)
        {
            Fraction newF = new();
            if (this.Mexrec == f2.Mexrec) // Mexrecleri beraberdirse
            {
                newF.Suret = f1.Suret + f2.Suret;
                newF.Mexrec = f1.mex
            }
            else // Mexrecleri beraber deyise
            {
                int temp = EKOB(Mexrec, f2.Mexrec)
                newF.Mexrec = EKOB(Mexrec, f2.Mexrec);
                newF.Suret = ((temp / Mexrec) * Suret) + ((temp / f2.Mexrec) * f2.Suret);
            }

            return newF;
        }

        public Fraction substraction(Fraction f2)
        {
            Fraction newF = new();
            if (Mexrec == f2.Mexrec) // Mexrecler beraberdirse
            {
                newF.Suret = Suret - f2.Suret;
                newF.Mexrec = Mexrec;
            }
            else // Mexrecler beraber deyilse
            {
                int temp = EKOB(Mexrec, f2.Mexrec)
                newF.Suret = ((temp / Mexrec) * Suret) - ((temp/ f2.Mexrec) * f2.Suret);
                newF.Mexrec = temp;
            }
            return newF;
        }

        public Fraction multiply(Fraction f2)
        {
            Fraction newF = new();
            newF.Suret = Suret * f2.Suret;
            newF.Mexrec = Mexrec * f2.Mexrec;

            return newF;
        }

        public Fraction divide(Fraction f2)
        {
            Fraction newF = new();
            newF.Suret = Suret * f2.Mexrec;
            newF.Mexrec = f2.Suret * Mexrec;

            return newF;
        }




    }

    class Program
    {
        static void Main()
        {
            Fraction f1 = new(2, 5);
            Fraction f2 = new(3, 4);

            // Add
            Console.WriteLine(f1.add(f2);
            //Substraction
            Console.WriteLine(f1.substraction(f2));
            //Multiply
            Console.WriteLine(f1.multiply(f2));
            //Divide
            Console.WriteLine(f1.divide(f2));
        }
    }
}