using FinancialCRMProject.Models;
using System;
using System.Linq;
using System.Windows.Forms;
namespace FinancialCRMProject
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }
        FinancalCrmDbEntities db = new FinancalCrmDbEntities();
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            //BANKA BAKİYLERİ
            var ziraatBankBalance = db.Banks.Where(x=>x.BankTitle=="Ziraat Bankası").Select(y=>y.BankBalance).FirstOrDefault();
            var garantiBankBalance = db.Banks.Where(x => x.BankTitle == "Garanti Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var yapikrediBankBalance = db.Banks.Where(x => x.BankTitle == "YapıKredi Bankası").Select(y => y.BankBalance).FirstOrDefault();
            LblZB.Text = ziraatBankBalance.ToString() + " ₺";
            LblGB.Text = garantiBankBalance.ToString() + " ₺";
            LblYKB.Text = yapikrediBankBalance.ToString() + " ₺";


            //BANKA HAREKETLERİ
            var bankProcess1 = db.BankProcessId.OrderByDescending(x => x.BankProcessId1).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcess1.Description + " "+ " /"+" " + bankProcess1.Amount + " "+ " /" +" "+ bankProcess1.ProcessDate;

            var bankProcess2 = db.BankProcessId.OrderByDescending(x => x.BankProcessId1).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcess2.Description + " " + " /" + " " + bankProcess2.Amount + " " + " /" + " " + bankProcess2.ProcessDate;

            var bankProcess3 = db.BankProcessId.OrderByDescending(x => x.BankProcessId1).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcess3.Description + " " + " /" + " " + bankProcess3.Amount + " " + " /" + " " + bankProcess3.ProcessDate;

            var bankProcess4 = db.BankProcessId.OrderByDescending(x => x.BankProcessId1).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcess4.Description + " " + " /" + " " + bankProcess4.Amount + " " + " /" + " " + bankProcess4.ProcessDate;

            var bankProcess5 = db.BankProcessId.OrderByDescending(x => x.BankProcessId1).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcess5.Description + " " + " /" + " " + bankProcess5.Amount + " " + " /" + " " + bankProcess5.ProcessDate;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBilling billing = new FrmBilling();
            billing.Show();
        }
    }
}
