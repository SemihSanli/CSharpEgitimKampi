using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void BtnList_Click(object sender, EventArgs e)
        {
            
            var values = db.Tbl_Guide.ToList();
            dataGridView1.DataSource=values;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Tbl_Guide guide = new Tbl_Guide();
            guide.guideName = TxtName.Text;
            guide.guideSurname = TxtSurname.Text;
            db.Tbl_Guide.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla eklendi");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var removeValue = db.Tbl_Guide.Find(id);
            db.Tbl_Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla silindi");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var updateValue = db.Tbl_Guide.Find(id);
            updateValue.guideName = TxtName.Text;
            updateValue.guideSurname= TxtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla güncellendi", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void BtnId_Click(object sender, EventArgs e)
        {
            int id=int.Parse(TxtId.Text);
            var values = db.Tbl_Guide.Where(x => x.guideId == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
