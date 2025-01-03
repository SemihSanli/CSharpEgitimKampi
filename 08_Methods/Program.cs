using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region metotlar
            //void geriye değer döndürmeyen metotlardır

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //CustomerList();
            //void sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}
            //sum();
            #endregion
            #region geriye değer döndürmeyen string parametreli metotlar
            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Semih Şanlı");
            //void CustomerCard(string name,string surname)
            // {
            //     Console.WriteLine("Müşteri: " + name + "" + surname);
            // }
            // CustomerCard("Semih","Şanlı");
            #endregion
            #region  geriye değer döndürmeyen int parametreli metotlar
            //void Sum(int num1,int num2,int num3)
            //{
            //    int result = num1+ num2+num3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);
            #endregion
            #region geriye değer döndüren metotlar
            //string CustomerName()
            //{
            //    return ("Buse yıldız");
            //}
            //CustomerName();
            //string studentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(studentCard());
            #endregion
            #region geriye değer döndüren parametreli metotlar
            //string CountryCard(string countryName,string Capital,string flagColor)
            //{
            //    string cardInfo = "Ülke: "+countryName +" " +"Başken:" +Capital + " " + "Bayrak Rengi: "+ flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x= Console.ReadLine();
            //Console.Write("Başkenti giriniz: ");
            //y= Console.ReadLine();
            //Console.Write("Bayrak rengini giriniz: ");
            //z= Console.ReadLine();
            //Console.WriteLine(CountryCard(x, y, z));
            #endregion
            #region geriye değer döndüren int parametreli metotlar
            //int Sum(int num1,int num2)
            //{
            //    int result = num1 + num2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));


            #endregion
            #region  örnek uygulama
            //string examResult(string student, int ex1, int ex2, int ex3)
            //{
            //    int result = (ex1 + ex2 + ex3) / 3;
            //    if (result >= 50)
            //    {
            //        return "Öğrenci sınavı geçti";
            //    }
            //    else
            //    {
            //        return "Öğrenci başarısız oldu";
            //    }

            //}
            //Console.WriteLine(examResult("Ali", 25, 41, 85));
            //Console.Read();
            #endregion
        }
    }
}
