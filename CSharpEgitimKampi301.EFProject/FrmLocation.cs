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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void BtnList_Click(object sender, EventArgs e)
        {
            var values = db.Tbl_Location.ToList();
            dataGridView1.DataSource = values;  
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.Tbl_Guide.Select(x=> new
            {
                FullName=x.guideName + " " +x.guideSurname,
                x.guideId
            }).ToList();
            CmbGuide.DisplayMember = "FullName" ;
            CmbGuide.ValueMember = "GuideId";
            CmbGuide.DataSource = values;
            
            
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Tbl_Location location = new Tbl_Location();
            location.Capacity = byte.Parse(NmrCapacity.Value.ToString());
            location.City=TxtCity.Text;
            location.Country=TxtCountry.Text;
            location.Price = decimal.Parse(TxtPrice.Text);
            location.DayNight = TxtDN.Text;
            location.GuideId = int.Parse(CmbGuide.SelectedValue.ToString());
            db.Tbl_Location.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi başarılı");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deletedValue = db.Tbl_Location.Find(id);
            db.Tbl_Location.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi başarılı");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var updatedValue = db.Tbl_Location.Find(id);
            updatedValue.DayNight= TxtDN.Text;
            updatedValue.Price = decimal.Parse(TxtPrice.Text);
            updatedValue.Capacity=byte.Parse(NmrCapacity.Text);
            updatedValue.City =TxtCity.Text;
            updatedValue.Country =TxtCountry.Text;
            updatedValue.GuideId = int.Parse(CmbGuide.SelectedValue.ToString()) ;
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
        }
    }
}
