using System;

namespace ThereDigitNumberDisection
{
    class Program
    {
        static void Main(string[] args)
        {
            int u, t, h;
            int nums = int.Parse(Console.ReadLine());

            if (nums >= 100 && nums <= 999)
            {
                u = nums % 10;
                t = (nums / 10) % 10;
                h = (nums / 100) % 10;
                Console.WriteLine("Стотици = " + h);
                Console.WriteLine("Десетици = " + t);
                Console.WriteLine("Единици = " + u);
            }
            else Console.WriteLine("Числото не е трицифрено!");
            
        }
       
    }
}
