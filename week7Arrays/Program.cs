using System;

namespace week7Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal valida mida ta hommikusöögiks sööb


            Console.WriteLine("Palun valige mida te soovite hommiksöögiks süüa");
            string[] food = { "Võileib justuga", "Jogurt", "Krõbinad", "Pelmeenid" };

            food[3] = "Munad";
            food[1] = "Jogurt";
             
            Console.WriteLine("Menüüs: ");

            for(int i = 0; i< food.Length; i++)
            {
                Console.WriteLine(food[i]);
            }


            Console.WriteLine("vali toit (Sisesta number 1 - 4");
            int userchoice = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine($"Oled valinud {food[userchoice]}");

        }
    }
}
