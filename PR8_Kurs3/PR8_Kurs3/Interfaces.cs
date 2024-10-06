using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR8_Kurs3
{
    internal interface ITax
    {
        public string NameProduct { get; set; }
        public double Price { get; set; }

        public static string nameClass;



        //public static string NameClass {  get { return nameClass; } }

        public double AddTax(double price);
    }
    internal interface IPrintInConsole
    {
        public string Print();
    }
}
