using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LebedevIV.Sprint1.TaskReview.V29.Lib;

namespace Tyuiu.LebedevIV.Sprint1.TaskReview.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Лебедев И.В. | ИИПб-23-3";

      

            Console.WriteLine(" Введите x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Введите y");
            double y = Convert.ToDouble(Console.ReadLine());
            var result = ds.Calculate(x,y);

            Console.WriteLine($"Результат {result}");
            Console.ReadKey();
        }
    }
}
