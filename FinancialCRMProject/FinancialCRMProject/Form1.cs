using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCRMProject.Models;
namespace FinancialCRMProject
{
    public partial class FrmDashboard : Form
    {
       

        public FrmDashboard()
        {
            InitializeComponent();
        }
        
        FrmBilling frb = new FrmBilling();
        FrmBanks frbnks = new FrmBanks();
        Expenses ex = new Expenses();
        Categories ctgr = new Categories();
        BankTransactions bt = new BankTransactions();
        int count = 0;
        FinancalCrmDbEntities db = new FinancalCrmDbEntities();
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
           lblTotalBalance.Text = totalBalance.ToString();


            var lastBankProcessAmount =db.BankProcessId.OrderByDescending(x=>x.BankProcessId1).Take(1).Select(y=>y.Amount).FirstOrDefault();
            LblLastBPA.Text = lastBankProcessAmount.ToString() + "TL";

            //Chart 1 Code
            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();
            chart1.Series.Clear();
            var series = chart1.Series.Add("Para Miktarları");
            foreach(var item in bankData)
            {
                series.Points.AddXY(item.BankTitle,item.BankBalance);
            }
            //Chart 2 Code
            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();
            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            foreach (var item in billData)
            {
                series2.Points.AddXY(item.BillTitle,item.BillAmount);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if(count % 4 == 1)
            {
                var suFaturasi=db.Bills.Where(x=>x.BillTitle== "Su Faturası").Select(y=>y.BillAmount).FirstOrDefault();
                lblbilltitle.Text = "Su Faturası";
                lblBAmouth.Text = suFaturasi.ToString() + "TL";
            }
            if (count % 4 == 2)
            {
                var dogalgazFaturasi = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblbilltitle.Text = "Doğalgaz Faturası";
                lblBAmouth.Text = dogalgazFaturasi.ToString() + "TL";
            }
            if (count % 4 == 3)
            {
                var internetFaturasi = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblbilltitle.Text = "İnternet Faturası";
                lblBAmouth.Text = internetFaturasi.ToString() + "TL";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctgr.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frbnks.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frb.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ex.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bt.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
         
        }
    }
}
