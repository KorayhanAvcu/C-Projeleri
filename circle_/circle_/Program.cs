using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circle_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Yaricap Giriniz : ");
            int radius = int.Parse(Console.ReadLine());
            DrawCircleWithStars(radius);

        }
        static void DrawCircleWithStars(int radius)
        {
            for (int y = -radius; y <= radius; y++)
            {
                string row = "";
                for (int x = -radius; x <= radius; x++)
                {
                    double distance = Math.Sqrt(x * x + y * y);
                    if (Math.Abs(distance - radius) < 0.5)
                    {
                        row += "*";
                    }
                    else
                    {
                        row += " ";
                    }
                }
                Console.WriteLine(row);
            }
            Console.Read();
        }
        
    }
 }
