using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialCRMProject.Models;
using System.Windows.Forms;
using System.Resources;

namespace FinancialCRMProject
{
    public partial class Expenses : Form
    {
       

        FinancalCrmDbEntities db = new FinancalCrmDbEntities();
        public Expenses()
        {
            InitializeComponent();
        }
       
        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            var expenses1 = db.Spendings.OrderByDescending(x => x.SpendingId).Take(1).FirstOrDefault();
            txtExpenses1.Text = expenses1.SpendingTitle + " " + " /" + " " + expenses1.SpendingAmount + " " + " /" + " " + expenses1.SpendingDate;
            var expenses2 = db.Spendings.OrderByDescending(x => x.SpendingId).Take(2).Skip(1).FirstOrDefault();
            txtExpenses2.Text = expenses2.SpendingTitle + " " + " /" + " " + expenses2.SpendingAmount + " " + " /" + " " + expenses2.SpendingDate;
            var expenses3 = db.Spendings.OrderByDescending(x => x.SpendingId).Take(3).Skip(2).FirstOrDefault();
            txtExpenses3.Text = expenses3.SpendingTitle + " " + " /" + " " + expenses3.SpendingAmount + " " + " /" + " " + expenses3.SpendingDate;

            //var values = db.Categories.ToList();
            //cmbCategories.DataSource = values;
            //cmbCategories.DisplayMember = "CategoryName";
            //cmbCategories.ValueMember = "CategoryId";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string title = txtTitleName.Text;
            decimal amount = decimal.Parse(txtAmount.Text);
            int category = int.Parse(txtCategory.Text);
            DateTime date = DateTime.Parse(MskDate.Text);

            Spendings spend = new Spendings();
            spend.SpendingTitle = title;
            spend.SpendingAmount = amount;
            spend.CategoryId = category;
            spend.SpendingDate = date;
            db.Spendings.Add(spend);
            db.SaveChanges();
            MessageBox.Show("Yeni Harcama Başarıyla Eklendi");
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSID.Text);
            var removeValues = db.Spendings.Find(id);
            db.Spendings.Remove(removeValues);
            db.SaveChanges();
            MessageBox.Show("Harcama,Listeden Başarıyla Kaldırıldı");
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
          string title = txtTitleName.Text;
            decimal amount = decimal.Parse(txtAmount.Text);
            int category = int.Parse(txtCategory.Text);
            DateTime date = DateTime.Parse(MskDate.Text);
            int id = int.Parse(txtSID.Text);
            var updatedValues = db.Spendings.Find(id);

            updatedValues.SpendingTitle = title;
            updatedValues.SpendingAmount = amount;
            updatedValues.CategoryId = category;
            updatedValues.SpendingDate = date;

            db.SaveChanges();
            MessageBox.Show("İstenilen Harcama Bilgileri Başarıyla Güncellendi");
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
