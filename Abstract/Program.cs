using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Имя кошки");
            string nameCat = Console.ReadLine();
            Console.WriteLine("Имя собаки");
            string nameDog = Console.ReadLine();
            Dag dag = new Dag(nameDog);
            Cat cat = new Cat(nameCat);
            Console.WriteLine("Инфо кошка");
            cat.ShowInfo();
            Console.WriteLine("Инфо собака");
            dag.ShowInfo();
            Console.ReadKey();
        }
    }
}
