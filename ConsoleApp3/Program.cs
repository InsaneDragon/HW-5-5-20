using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static List<string> GameList = new List<string>() { "CS:GO", "DOTA 2", "League of Legends", "PUBG" };
        public static Dictionary<int, string> PhoneNumbers = new Dictionary<int, string>() { { 992, "Dushanbe" }, { 008, "Russia" } };
        public static int ListCount { get { return GameList.Count; } }
        public static int DictCount { get { return PhoneNumbers.Count; } }
        static void Main(string[] args)
        {
            GameList.Add("Mobile Legends");//Add Element to List//
            string game = GameList[0];//Getting element by index
            Console.WriteLine("Length:" + ListCount);//Getting List Length
            foreach (var item in GameList)//Writing All List elements
            {
                Console.WriteLine(GameList.IndexOf(item) + "." + item);
            }
            Console.WriteLine("==========================");
            PhoneNumbers.Add(567, "USA");//Add Element to Dictionary
            Console.WriteLine(PhoneNumbers.ElementAt(0).Value);//Getting Dictionary value by index 
            Console.WriteLine("Length:" + DictCount);//Get Dictionary Length
            foreach (var item in PhoneNumbers)//All Dictionary Elements
            {
                Console.WriteLine("Key:" + item.Key + "," + "Value:" + item.Value);
            }
            Console.WriteLine(PhoneNumbers[992]);//Get element by key
            Console.ReadKey();
        }
    }
}
