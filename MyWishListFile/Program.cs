using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyWishListFIle
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\Alo\Samples\Wishlist";
            string fileName = @"//Mywishlist.txt";
            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myWishList = arrayFromFile.ToList<string>();
            bool loopActive = true;
            while (loopActive)
            {
                Console.WriteLine("Would you like to add a wish? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());
                if(userInput== 'y')
                {
                    Console.WriteLine("Enter your wish:");
                    string userWish = Console.ReadLine();
                    myWishList.Add(userWish);
                }
                else
                {
                    Console.WriteLine("Take care!");
                    loopActive = false;
                }
            }
            Console.Clear();
            foreach (string wish in myWishList)
            {
                Console.WriteLine($"Your wish is {wish}");
            }
            File.WriteAllLines($"{fileLocation}{fileName}",myWishList);
        }
    }
}
