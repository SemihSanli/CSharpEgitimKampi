using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if
            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "Semih")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}
            //string capital, country;
            //Console.Write("Lütfen başkenti giriniz: ");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();
            //if (capital == "ankara" & country=="türkiye")
            //{
            //    Console.Write("Veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı bilgi");
            //}
            //int num;
            //Console.Write("Sayıyı giriniz: ");
            //num=int.Parse(Console.ReadLine());
            //if (num == 5)
            //{
            //    Console.Write("Sayı Doğru");
            //}
            //else
            //{
            //    Console.Write("Hatalı");
            //}
            //int exam1, exam2, exam3, average;
            //string result="Hata!";
            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());
            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalamsı: " + average);
            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}
            //Console.Write(result);
            //string city;
            //Console.Write("Lütfen şehir giriniz: ");
            //city = Console.ReadLine();
            //if (city == "adana" |city=="bursa " | city=="trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{

            //    Console.WriteLine("Şehir yok");

            //}
            //;
            #endregion
            #region mod işlemleri
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);
            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int num1=int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.sayıyı girini: ");
            //int num2 = int.Parse(Console.ReadLine());
            //int result=num1%num2;
            //Console.Write("1.sayıyının 2.sayıya bölümünden kalan: " + result);
            //Console.ReadKey();
            // Console.Write("Lütfen sayıyı giriniz: ");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.Write("Sayı çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir");
            //}
            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team=char.Parse(Console.ReadLine());
            //if (team == 'G' | team == 'g')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if(team=='f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}


            #endregion
            #region Örnek Proje uygulaması
            //Console.WriteLine("C# EĞİTİM KAMPI RESTORANT");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("1-Ana yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-içecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("--------------------------------");
            //Console.WriteLine();
            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem= Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("-------------Ana Yemekler------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek");
            //    Console.WriteLine("2-Ezogelin");
            //    Console.WriteLine("-------------Çorbalar------------");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Margarita");
            //    Console.WriteLine("2-Füme Etli");
            //    Console.WriteLine("3-Karışık");
            //    Console.WriteLine("-------------Pizzalar------------");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kazandibi");
            //    Console.WriteLine("2-Sütlaç");
            //    Console.WriteLine("-------------Tatlılar------------");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------İçecekler------------");
            //    Console.WriteLine();

            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Kola");
            //    Console.WriteLine("3-Fanta");
            //    Console.WriteLine("4-Ayran");
            //    Console.WriteLine("5-Soda");
            //    Console.WriteLine("-------------İçecekler------------");

            //}

            #endregion
            #region switch Case
            // Console.Write("Lütfen ay girişi yapınız: ");
            // int monthNumber= int.Parse(Console.ReadLine());
            //switch(monthNumber)
            // {
            //     case 1: Console.Write("Ocak");break;
            //     case 2: Console.Write("Şubat");break;
            //     case 3: Console.Write("Mart");break;
            //     case 4: Console.Write("Nisan");break;
            //     case 5: Console.Write("Mayıs");break;
            //     case 7: Console.Write("Temmuz");break;
            //     case 8: Console.Write("Ağustos");break;
            //     case 9: Console.Write("Eylül");break;
            //     case 10: Console.Write("Ekim");break;
            //     case 11: Console.Write("Kasım");break;
            //     case 12: Console.Write("Aralık");break;
            //     default: Console.Write("Hatalı veri girişi");break;

            // }
            // Console.ReadKey();
            #endregion
            #region switchCase hesap makinesi
            //int num1, num2, result;
            //char symbol;
            //Console.Write("1.sayıyı giriniz: ");
            //num1=int.Parse(Console.ReadLine());
            //Console.Write("2.sayıyı giriniz: ");
            //num2 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz (+,-,*,/): ");
            //symbol=char.Parse(Console.ReadLine());
            //switch (symbol)
            //{
            //    case '+':
            //        result = num1+ num2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //    case '/':
            //        result = num1 / num2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;
            //    default: Console.WriteLine("Lütfen yapmak istediğiniz işlemi belirtiniz !! ");
            //        break;
            //Console.ReadKey();
        }
        #endregion
        }
    }
  

