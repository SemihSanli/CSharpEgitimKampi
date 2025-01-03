using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel dizi örnekleri
            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";
            //Console.WriteLine(colors[0] );
            //string[] cities = new string[2];
            //cities[0] = "İzmir";
            //cities[1] = "İstanbul";
            //cities[2] = "Ankara";
            //Console.WriteLine("Dizinin 1.elamanı: " + cities[0] +"2.elemanı: " + cities[1] );
            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 40;
            //numbers[2] = 100;
            //numbers[3] = 24;
            //numbers[8] = 1;
            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);

            #endregion
            #region dizideki tüm elemanları listeleme
            //string[] colors = { "Sarı", "Kırmızı", "Mavi", "Yeşil", "Turuncu" };
            //for(int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}
            //int[] numbers = { 4, 85, 96, 74, 125, 635, 488, 520, 7456, 2365, 1120 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] %3== 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNum = myArray[0];
            //for(int i=0;i<myArray.Length;i++)
            //{
            //    if (myArray[i] > maxNum)
            //    {
            //        maxNum = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNum);
            #endregion
            #region kullanıcıdan değer alma
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}.Şehrini giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------------");
            //for (int i = 0;i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}
            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);
            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897,748, 39, 220 };
            //Console.WriteLine("Çift Sayılar: ");
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("Tek Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
                
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            #endregion
            Console.Read();
        }
    }
}
