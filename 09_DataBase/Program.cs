using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DataBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net
            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            string tableNumber;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(" " + "1-Kategoriler");
            Console.WriteLine(" " +"2-Ürünler");
            Console.WriteLine(" " +"3-Siparişler");
            Console.WriteLine(" " +"4-Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("---------------------------------------------");
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-33VDDOP\\SQLEXPRESS17;initial Catalog=EgitimKampiDb;" +
                "integrated security=true");
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Category",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            connection.Close();
            foreach(DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
