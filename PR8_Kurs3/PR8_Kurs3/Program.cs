using PR8_Kurs3;
using System.Diagnostics;

namespace PR8_Kurs3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(new string('=', 100));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nВвод:\n");
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine($"{new string(' ', 30)}Предметы первой необходимости");
                Console.Write("Введите название товара: ");
                string nameProductB = Console.ReadLine();

                Console.Write("Введите цену товара: ");
                double priceB = Convert.ToDouble(Console.ReadLine());

                BasicNecessities taxBN = new BasicNecessities(nameProductB, priceB);

                Console.WriteLine();

                Console.WriteLine($"{new string(' ', 30)}Предметы роскоши");
                Console.Write("Введите название товара: ");
                string nameProductL = Console.ReadLine();

                Console.Write("Введите цену товара: ");
                double priceL = Convert.ToDouble(Console.ReadLine());

                LuxuryItems taxLI = new LuxuryItems(nameProductL, priceL);

                Console.WriteLine(new string('=', 100));
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nВывод: \n");
                Console.ForegroundColor = ConsoleColor.Gray;



                Console.WriteLine(taxBN.Print());
                Console.WriteLine(taxLI.Print());
            }
            catch (System.FormatException ex) 
            {
                Console.WriteLine("Неверный формат данных");
            }
        }
    }

    public class BasicNecessities : ITax, IPrintInConsole //Предметы первой необходимости 
    {
        private string nameProduct;
        private double price;
        private string nameClass = "Предметы первой необходимости";

        public string NameProduct
        {
            get { return nameProduct; }
            set { nameProduct = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        //public string NameClass { get { return nameClass; } }




        public BasicNecessities(string nameProduct, double price) 
        {
            NameProduct = nameProduct;
            Price = price;
        }
        public BasicNecessities(){}




        public double AddTax(double price)
        {
            return price + ((price / 100) * 0.5);
        }
        public string Print()
        {
            return $"\nНазвание класса: {nameClass}\nНазвание товара: {nameProduct}\nСтоимость товара без налога: {Math.Round(price, 2)} руб.\nСтоимость товара c налогом: {Math.Round(AddTax(price), 2)} руб.\n";
        }
    }
    public class LuxuryItems : ITax, IPrintInConsole // Предметы роскоши
    {
        private string nameProduct; 
        private double price;
        public static string nameClass = "Предметы роскоши";


        public string NameProduct
        {
            get { return nameProduct; }
            set { nameProduct = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        //public static string NameClass { get { return nameClass; } }




        public LuxuryItems(string nameProduct, double price)
        {
            NameProduct = nameProduct; 
            Price = price;
        }
        public LuxuryItems() { }




        public double AddTax(double price)
        {
            return price + ((price / 100) * 20);
        }
        public string Print()
        {
            return $"\nНазвание класса: {nameClass}\nНазвание товара: {nameProduct}\nСтоимость товара без налога: {Math.Round(price, 2)} руб.\nСтоимость товара c налогом: {Math.Round(AddTax(price), 2)} руб.\n";
        }
    }

}
