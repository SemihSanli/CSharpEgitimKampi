using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region kategori ekleme
            //Crud-->Create,Read,Update,Delete
            //Console.WriteLine("*****Menü Sipariş işlem paneli*****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Eklemek istediğiniz kategori adı: ");
            //string categoryName=Console.ReadLine();
            //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-33VDDOP\\SQLEXPRESS17;initial Catalog=EgitimKampiDb;" +
            //    "integrated security=true");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Insert Into Tbl_Category (CategoryName) values (@p1)", conn);
            //cmd.Parameters.AddWithValue("@p1", categoryName);
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //Console.Write("Kategori başarıyla eklendi");
            #endregion
            #region ürün ekleme
            //string productName;
            //decimal productPrice;
            ////bool productStatus;
            //Console.Write("Eklemek istediğiniz ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatını belirleyiniz: ");
            //productPrice=decimal.Parse(Console.ReadLine());
            //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-33VDDOP\\SQLEXPRESS17;initial Catalog=EgitimKampiDb;" +
            //    "integrated security=true");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("insert into Tbl_Product(ProductName,ProductPrice,ProductStatus)values (@productName,@productPrice,@productStatus)", conn);
            //cmd.Parameters.AddWithValue("@productName", productName);
            //cmd.Parameters.AddWithValue("@productPrice", productPrice);
            //cmd.Parameters.AddWithValue("@productStatus", true);
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //Console.Write("Ürün başarıyla eklendi");
            #endregion
            #region ürün listeleme
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-33VDDOP\\SQLEXPRESS17;initial Catalog=EgitimKampiDb;" +
            //    "integrated security=true");
            //connection.Open();
            //SqlCommand cmd = new SqlCommand("Select * from Tbl_Product",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow rows in dataTable.Rows)
            //{
            //    foreach (var items in rows.ItemArray)
            //    {
            //        Console.WriteLine(items.ToString());
            //    }
            //}
            //connection.Close();
            #endregion
            #region ürün silme işlemi
            //Console.Write("Silinecek ürünün id'si: ");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-33VDDOP\\SQLEXPRESS17;initial Catalog=EgitimKampiDb;" +
            //    "integrated security=true");
            //connection.Open();
            //SqlCommand cmd = new SqlCommand("Delete from Tbl_Product where ProductID=@productid",connection);
            //cmd.Parameters.AddWithValue("@productid", productId);
            //cmd.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Silme işlemi tamamlandı");
            #endregion
            #region güncelleme
            //Console.Write("Güncellenecek ürün Id: ");
            //int productId=int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek ürün Adı: ");
            //string productName=Console.ReadLine();
            //Console.Write("Güncellenecek ürün Fiyatı: ");
            //decimal productPrice=decimal.Parse(Console.ReadLine());
            
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-33VDDOP\\SQLEXPRESS17;initial Catalog=EgitimKampiDb;" +
            //    "integrated security=true");
            //connection.Open();
            //SqlCommand cmd = new SqlCommand("Update Tbl_Product Set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId", connection);
            //cmd.Parameters.AddWithValue("@productName", productName);
            //cmd.Parameters.AddWithValue("@productPrice", productPrice);
            //cmd.Parameters.AddWithValue("@productId", productId);
            //cmd.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Ürün başarı ile güncellendi");
            #endregion
            Console.Read();
        }
    }
}
