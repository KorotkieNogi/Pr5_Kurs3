using System.Xml.Linq;

namespace PR5C_kurs3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите простое животное: ");
            string NameAnimal = Console.ReadLine();

            Console.Write("Введите вес животного: ");
            string WightAnimal = Console.ReadLine();

            Console.Write("Введите породу животного: ");
            string BreedAnimal = Console.ReadLine();

            Console.Write("Введите дату рождения животного: ");
            string DateAnimal = Console.ReadLine();

            Animals animals1 = new Animals(NameAnimal, WightAnimal, BreedAnimal, DateAnimal);
            Console.WriteLine("\nИнформация о животном: " + animals1.GetInfo());





            Console.Write("\n\nВведите имя котика: ");
            string NameKitten = Console.ReadLine();

            Console.Write("Введите вес котика: ");
            string WightKitten = Console.ReadLine();

            Console.Write("Введите породу котика: ");
            string BreedKitten = Console.ReadLine();

            Console.Write("Введите дату рождения котика: ");
            string DateKitten = Console.ReadLine();

            Kitten kitten = new Kitten(NameKitten, WightKitten, BreedKitten, DateKitten);              //"беляшь", "8 кг", "Сиамский", "15.09.2021"
            Console.WriteLine("\nИнформация о котике: " + kitten.GetInfoAboutKitten() + "\n");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Котик ловит мышку: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(kitten.CatchMouse() + "\n");
            Console.ForegroundColor = ConsoleColor.White;




            Console.Write("\n\nВведите имя Попугайчика: ");
            string NameParrot = Console.ReadLine();

            Console.Write("Введите вес Попугайчика: ");
            string WightParrot = Console.ReadLine();

            Console.Write("Введите породу Попугайчика: ");
            string BreedParrot = Console.ReadLine();

            Console.Write("Введите дату рождения Попугайчика: ");
            string DateParrot = Console.ReadLine();

            Parrot parrot1 = new Parrot(NameParrot, WightParrot, BreedParrot, DateParrot);
            Console.WriteLine("\nИнформация о Попугайчике: " + parrot1.GetInfoAboutParrot());

        }
    }
    public class Animals
    {
        private string name; 
        private string wight;
        private string breed; 
        private string dateBirthday;

        public string Name 
        { 
            get { return name; }
            set { name = value; } 
        }
        public string Wight 
        {
            get {return wight; }
            set {wight = value; } 
        }
        public string Breed 
        {
            get {return breed; }
            set {breed = value; } 
        }
        public string DateBirthday
        {
            get { return dateBirthday; }
            set { dateBirthday = value; } 
        }

        public Animals(string name, string wight, string breed, string dateBirthday)
        {
            this.name = name;
            this.wight = wight; 
            this.breed = breed;
            this.dateBirthday = dateBirthday;
        }
        public Animals(){}
        public string GetInfo()
        {
            return $"\nИмя животного: {name}\nВес: {wight}\nПорода: {breed}\nДата рождения: {dateBirthday}";
        }
    }
    class Kitten : Animals
    {
        public Kitten(string name, string wight, string breed, string dateBirthday)
            : base(name, wight, breed, dateBirthday)
        {
            Name = name;
            Wight = wight;
            Breed = breed;
            DateBirthday = dateBirthday;
        }
        
        public Kitten() { }

        public string GetInfoAboutKitten()
        {
            return GetInfo();
        }
        public bool CatchMouse()
        {
            Random random = new Random();

            int Accidentally = random.Next(0, 101);

            Console.Write("Число " + Accidentally + " ");

            if (Accidentally > 50)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                return true;
                
            }
            
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return false;
            }

        }
    }
    class Parrot : Animals
    {
        public Parrot(string name, string wight, string breed, string dateBirthday) 
            : base(name, wight, breed, dateBirthday)
        {
            Name = name;
            Wight = wight;
            Breed = breed;
            DateBirthday = dateBirthday;

        }
        public Parrot() { }
        public string GetInfoAboutParrot()
        {
            return GetInfo();
        }
    }

}
