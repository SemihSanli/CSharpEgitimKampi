using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FinancialCRMProject.Models;

namespace FinancialCRMProject
{
    public partial class Categories : Form
    {
        FinancalCrmDbEntities db = new FinancalCrmDbEntities();
        public Categories()
        {
            InitializeComponent();
        }
        

       

        private void BtnList_Click(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

      

        private void BtnlDel_Click(object sender, EventArgs e)
        {
            int id =int.Parse(txtID.Text);
            var removeValues = db.Categories.Find(id);
            db.Categories.Remove(removeValues);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı Bir Şekilde Uygulandı", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            string title = txtTitleName.Text;
            int id = int.Parse(txtID.Text);
            var updatedValues = db.Categories.Find(id);
            updatedValues.CategoryName = title;
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı Bir Şekilde Uygulandı", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //string title = txtTitleName.Text;
            //Categories categories = new Categories();
            //categories.Name = title;
            //db.Categories.Add(categories);
            //db.SaveChanges();
            //Console.WriteLine("Ekleme İşlemi Başarıyla Gerçekleştirildi");
        }
    }
}
