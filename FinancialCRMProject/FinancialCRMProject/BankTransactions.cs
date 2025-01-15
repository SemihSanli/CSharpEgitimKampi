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


namespace FinancialCRMProject
{
    public partial class BankTransactions : Form
    {
        
        public BankTransactions()
        {
            InitializeComponent();
        }
        FinancalCrmDbEntities db = new FinancalCrmDbEntities();
        private void BankTransactions_Load(object sender, EventArgs e)
        {
            var values = db.BankProcessId.ToList();
            dataGridView1.DataSource = values;
        }
    }
}
