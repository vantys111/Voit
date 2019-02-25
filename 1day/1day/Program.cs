using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1day
{
    class Firm
    {
        private string name;
        public string Name { get; set; }
        private string addres;
        public string Addres { get; set; }
        private int year;
        public int Year { get; set; }
        public void print()
        {
            Console.WriteLine("Название" + Name + "Адресс" + Addres + "Год основания" + Year);
        }
        public void vrite()
        {
            Console.WriteLine("Введите название");
            name = Console.ReadLine();
            Console.WriteLine("Введите адрес");
            addres = Console.ReadLine();
            Console.WriteLine("Введите год основания");
            year = int.Parse(Console.ReadLine());
        }
        public Firm()
        {
            Name = "ооо Воробей";
            Addres = "ул. Октябрьская 57";
            Year = 1990;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Firm name = new Firm();
            name.print();
            Console.ReadKey();
        }
    }
}
