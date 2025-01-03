using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region doubleDegiskenler
            //double number;
            //number = 4.32;
            //Console.WriteLine(number);
            //Console.Read();
            //Console.WriteLine("***** FİYAT LİSTESİ *****");
            //Console.WriteLine();
            //double applePrice, orangePrice, bananaPrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;
            //Console.WriteLine("----- Elma Birim Fiyatı: " + applePrice +"TL");
            //Console.WriteLine("----- Portakal Birim Fiyatı: " + orangePrice + "TL");
            //Console.WriteLine("----- Çilek Birim Fiyatı: " + strawberryPrice + "TL");
            //Console.WriteLine("----- Patates Birim Fiyatı: " + potatoPrice + "TL");
            //Console.WriteLine("----- Domates Birim Fiyatı: " + tomatoPrice + "TL");
            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;
            //Console.WriteLine("--------------------------------------");
            //double appleTotalPrice = appleGram * applePrice;
            //Console.WriteLine("Alınan Ürün Elma /" + "Birim Fiyat: " + applePrice + "/ Gramaj: " + appleGram + " / Toplam Fiyat: " + appleTotalPrice); ;
            //Console.WriteLine("--------------------------------------");
            //double orangeTotalPrice = orangeGram * orangePrice;
            //Console.WriteLine("Alınan Ürün Portakal /" + "Birim Fiyat: " + orangePrice + "/ Gramaj: " +orangeGram + " / Toplam Fiyat: " + orangeTotalPrice); ;
            //Console.WriteLine("--------------------------------------");
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //Console.WriteLine("Alınan Ürün Elma /" + "Birim Fiyat: " + strawberryPrice + "/ Gramaj: " + strawberryGram + " / Toplam Fiyat: " + strawberryTotalPrice); ;
            //Console.WriteLine("--------------------------------------");
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //Console.WriteLine("Alınan Ürün Elma /" + "Birim Fiyat: " + potatoPrice + "/ Gramaj: " + potatoGram + " / Toplam Fiyat: " + potatoTotalPrice); ;
            //Console.WriteLine("--------------------------------------");
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //Console.WriteLine("Alınan Ürün Elma /" + "Birim Fiyat: " + tomatoPrice + "/ Gramaj: " + tomatoGram + " / Toplam Fiyat: " + tomatoTotalPrice); ;

            //Console.WriteLine("--------------------------------------");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice +strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışverişin toplam tutarı: " + shoppingTotalPrice +"TL");
            //Console.Read();
            #endregion
            #region charDegiskenler
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            //Console.Read();
            #endregion
            #region klavyeden veri girişleri string değişkenler
            //Console.WriteLine("***** C# Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();
            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIdentityNumber;
            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();
            //Console.Write("İlçe bilgisi: ");
            //passangerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi: ");
            //passangerCity = Console.ReadLine();
            //Console.Write("Yolcu Yaş: ");
            //passangerAge = Console.ReadLine();
            //Console.Write("Yolcu TC Numarası: ");
            //passangerIdentityNumber = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine("Yolcu Ad: "+passangerName +" " + "Yolcu Soyad: " + passangerSurname+" " + " İlçe: " + passangerDistrict + " " + "Şehir:  " + passangerCity+" " + "Yaş:  " + passangerAge+" " + "TC Kimlik No: " + passangerIdentityNumber);
            //Console.ReadKey();
            #endregion
            #region klavyede tam sayı girişleri ve dönüşümleri
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;
            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız televizyon sayıısnı giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());
            //int totalPrice=shoesCount*shoesPrice + computerCount*computerPrice + chairCount*chairPrice + tvCount*tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);
            //Console.ReadKey();
            #endregion
            #region klavyeden Ondalık Sayı İşlemleri
            //double exam1, exam2,exam3, result;
            //Console.Write("Lütfen 1.sınav notunu giriniz: ");
            //exam1=double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.sınav notunu giriniz: ");
            //exam2=double.Parse(Console.ReadLine());
            //Console.Write("Lütfen 3.sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);
            //Console.ReadKey();
            #endregion
            #region klavyeden karakter girişleri
            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);
            //Console.ReadKey();
            #endregion
        }
    }
}
