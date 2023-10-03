using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.LebedevIV.Sprint1.TaskReview.V29.Lib
{
    public class DataService : ISprint1Task7V29
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(x - (Math.Cos(Math.Pow(x, 3))) / (x * y - 3) + (Math.Sin(Math.Pow(x, 5))) / (x * y + 5), 3);
        }
    }
}
