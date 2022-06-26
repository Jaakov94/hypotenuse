using System;

namespace hypotenuse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wartości przyprostokątnych");
            Console.WriteLine("A= ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("B= ");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt(a * a + b * b);
            if (a>0 && b>0)
            {
                Console.WriteLine("Przeciwprostokątna ma długość: " + c);                
            }
            else
            {
                Console.WriteLine("a i b muszą być większe od 0");
             }
        }
    }
}
    
       
 