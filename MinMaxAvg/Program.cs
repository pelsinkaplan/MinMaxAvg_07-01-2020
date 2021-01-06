using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayılarList = new List<int>();
            int maxSayı = int.MinValue;
            int minSayı = int.MaxValue;
            double ortalama = 0;

            Console.WriteLine("Aralarda boşluk olacak şekilde sayıları girelim :)\n");
            string sayılar = Console.ReadLine();

            sayılarList = sayılar.Split(' ').Select(Int32.Parse).ToList();

            //for (int i = 0; i < sayılarList.Count; i++)
            //{
            //    if (sayılarList[i] > maxSayı)
            //    {
            //        maxSayı = sayılarList[i];
            //    }
            //    if (sayılarList[i] < minSayı)
            //    {
            //        minSayı = sayılarList[i];
            //    }
            //    ortalama += sayılarList[i];
            //}
            //ortalama /= sayılarList.Count;
            //Console.WriteLine($"Max Sayı : {maxSayı} \nMin Sayı : {minSayı} \nOrtalama : {ortalama}");
            //Console.ReadLine();

            minSayı = sayılarList.Min();
            maxSayı = sayılarList.Max();
            ortalama = sayılarList.Average();

            Console.WriteLine($"\nMax Sayı : {maxSayı} \nMin Sayı : {minSayı} \nOrtalama : {ortalama}");
            Console.ReadLine();

        }
    }
}
