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
using System.Windows.Forms.DataVisualization.Charting;

namespace FinancialCRMProject
{
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
        }
        FrmDashboard frd = new FrmDashboard();

        FinancalCrmDbEntities db = new FinancalCrmDbEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı Adı ve şifre boş bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                
            }
            
            using (var context = new FinancalCrmDbEntities()) 
            { 
                var user =context.Users.FirstOrDefault(x=>x.UserName==username && x.Password==password);

                if(user != null)
                {
                    MessageBox.Show("Giriş Onaylandı");
                    frd.Show();
                }
                else 
                {
                    MessageBox.Show("Giriş Bilgileri Hatalı Lütfen Tekrar Deneyiniz");
                }
            }
        }
    }
}
