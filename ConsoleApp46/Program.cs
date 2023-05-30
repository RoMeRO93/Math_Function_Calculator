using System;

namespace ProiectCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Bun venit! Alege o optiune:");
            Console.WriteLine("1. Adunare");
            Console.WriteLine("2. Scadere");
            Console.WriteLine("3. Inmultire");
            Console.WriteLine("4. Impartire");
            Console.WriteLine("5. Ridicare la putere");
            Console.WriteLine("6. Radical");
            Console.WriteLine("7. Logaritm");
            Console.WriteLine("0. Iesire");

            bool shouldExit = false;
            while (!shouldExit)
            {
                Console.Write("Optiunea ta: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Introdu primul numar: ");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Introdu al doilea numar: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        double sum = calculator.Adunare(num1, num2);
                        Console.WriteLine("Rezultatul adunarii este: " + sum);
                        break;

                    case "2":
                        Console.Write("Introdu primul numar: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Introdu al doilea numar: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        double dif = calculator.Scadere(num1, num2);
                        Console.WriteLine("Rezultatul scaderii este: " + dif);
                        break;

                    case "3":
                        Console.Write("Introdu primul numar: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Introdu al doilea numar: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        double prod = calculator.Inmultire(num1, num2);
                        Console.WriteLine("Rezultatul inmultirii este: " + prod);
                        break;

                    case "4":
                        Console.Write("Introdu primul numar: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Introdu al doilea numar: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                        if (num2 == 0)
                        {
                            Console.WriteLine("Eroare: Nu se poate imparti la zero!");
                        }
                        else
                        {
                            double div = calculator.Impartire(num1, num2);
                            Console.WriteLine("Rezultatul impartirii este: " + div);
                        }
                        break;

                    case "5":
                        Console.Write("Introdu numarul: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Introdu puterea: ");
                        int power = Convert.ToInt32(Console.ReadLine());
                        double result = calculator.RidicareLaPutere(num1, power);
                        Console.WriteLine("Rezultatul ridicarii la putere este: " + result);
                        break;

                    case "6":
                        Console.Write("Introdu numarul: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        if (num1 < 0)
                        {
                            Console.WriteLine("Eroare: Radicalul se poate calcula doar pentru numere pozitive!");
                        }
                        else
                        {
                            double radical = calculator.Radical(num1);
                            Console.WriteLine("Rezultatul radicalului este: " + radical);
                        }
                        break;

                    case "7":
                        
                        Console.Write("Introdu numarul: ");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Introdu baza logaritmului: ");
                        double baza = Convert.ToDouble(Console.ReadLine());
                        double logaritmul = calculator.Logaritm(num1, baza);
                        Console.WriteLine("Rezultatul logaritmului este: " + logaritmul);
                        break;

                    case "0":
                        shouldExit = true;
                        break;

                    default:
                        Console.WriteLine("Optiune invalida. Te rog sa alegi o optiune valida.");
                        break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("La revedere!");
        }
    }

    class Calculator
    {
        public double Adunare(double a, double b)
        {
            return a + b;
        }

        public double Scadere(double a, double b)
        {
            return a - b;
        }

        public double Inmultire(double a, double b)
        {
            return a * b;
        }

        public double Impartire(double a, double b)
        {
            return a / b;
        }

        public double RidicareLaPutere(double numar, int putere)
        {
            return Math.Pow(numar, putere);
        }

        public double Radical(double numar)
        {
            return Math.Sqrt(numar);
        }

        public double Logaritm(double numar, double baza)
        {
            return Math.Log(numar, baza);
        }
    }
}
