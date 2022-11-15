// Программа находит точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
using System;

namespace ConsoleApp2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Class1 newLine = new Class1();

            Console.WriteLine("Значения для построения первой прямой");
            int[] line1 = newLine.createLine();

            Console.WriteLine("Значения для построения второй прямой");
            int[] line2 = newLine.createLine();

            Class1 M = new Class1();
            M.pointOf_intersectionOf_twoLines(line1, line2);
        }
    }
}
