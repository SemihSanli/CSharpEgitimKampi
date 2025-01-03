using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");
            //Console.WriteLine("****** Yemek Kategorileri ******");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("****** Yemek Kategorileri ******");
            #endregion
            #region StringDeğişkenler
            ////Değişkenler
            //string name;
            //name = "Semih";
            //Console.WriteLine(name);
            //string customerName;
            //string customerSurname;
            //string customerPhoneNum;
            //string customerEmail,district,city;
            //customerName = "Ahmet";
            //customerSurname = "Hamdi";
            //customerPhoneNum = "+90 535 482 22 12";
            //customerEmail = "trail@gmail.com";
            //district = "Konak";
            //city = "İzmir";
            //Console.WriteLine("******* Rezervasyon Kartı *********");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("Müşteri  : " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim : " + customerPhoneNum);
            //Console.WriteLine("E-mail Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //customerName = "Hakan";
            //customerSurname = "Tanık";
            //customerPhoneNum = "+90 532 325 15 10";
            //customerEmail = "Hatrail@gmail.com";
            //district = "Mersin";
            //city = "Adana";
            //Console.WriteLine("Müşteri  : " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim : " + customerPhoneNum);
            //Console.WriteLine("E-mail Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            #endregion
            #region Int Değişkenler
            //int num = 24;
            //Console.WriteLine(num);
            int hamburgerPrice = 300;
            int CokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;
            Console.WriteLine("***** Restorant Menu Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger: " + hamburgerPrice);
            Console.WriteLine("----Pizza: " + pizzaPrice);
            Console.WriteLine("----Kızartmalar: " + friesPrice);
            Console.WriteLine("----Limonata: " + lemonadePrice);
            Console.WriteLine("----Kola: " + CokePrice);
            Console.WriteLine("----Su: " + waterPrice);
            Console.WriteLine();
            Console.WriteLine("***** Restorant Menu Fiyatı *****");
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;  
            int totalHamburgerPrice = 0;
            hamburgerCount = 3;
            int totalCokePrice = 0;
            cokeCount = 3;
            int totalfriesPrice = 0;
            friesCount = 1;
            int totalwaterPrice = 0;
            waterCount = 3;
            int totallemonadePrice = 0;
            lemonadeCount = 0;
            int totalPizzaPrice = 0;
            pizzaCount = 8;
            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "TL");
            totalCokePrice = cokeCount * CokePrice;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "TL");
            Console.WriteLine("--------------------------------------------");
            totalfriesPrice = friesCount * friesPrice;
            Console.WriteLine("Kızartma Fiyatı: " + totalfriesPrice + "TL");
            Console.WriteLine("--------------------------------------------");
            totalwaterPrice = waterCount * waterPrice;
            Console.WriteLine("Su Fiyatı: " + totalwaterPrice + "TL");
            Console.WriteLine("-------------------------------------------");
            totallemonadePrice =lemonadeCount * lemonadePrice;
            Console.WriteLine("Limonata Fiyatı: " + totallemonadePrice + "TL");
            Console.WriteLine("--------------------------------------------");
            totalPizzaPrice = pizzaCount * pizzaPrice;
            Console.WriteLine("Pizza Fiyatı: " + totalPizzaPrice + "TL");
            Console.WriteLine("--------------------------------------------");
            int totalprice = totalCokePrice + totalfriesPrice + totalwaterPrice + totallemonadePrice + totalHamburgerPrice + totalPizzaPrice;
            Console.WriteLine("Toplam Fiyat: " + totalprice);
            #endregion
            Console.Read();
        }
    }
}
