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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            #region Toplam Lokasyon Sayısı
            lblLocationCount.Text = db.Tbl_Location.Count().ToString();
            #endregion
            #region Toplam Kapasite
            lblSumCapacity.Text = db.Tbl_Location.Sum(x=>x.Capacity).ToString();
            #endregion
            #region rehber sayısı
            lblGuideCount.Text = db.Tbl_Guide.Count().ToString();
            #endregion
            #region ortalama kapasite
            lblAvarageCapacity.Text = db.Tbl_Location.Average(x => x.Capacity).ToString();
            #endregion
            #region Ortalama Tur Fiyatı
            lblAverageLocation.Text = db.Tbl_Location.Average(x=>x.Price)?.ToString("0.00") + "₺";
            #endregion
            #region Eklenen Son Ülke
            int lastCountryId=db.Tbl_Location.Max(x=>x.locationId);
            lblLastCountryName.Text = db.Tbl_Location.Where(x => x.locationId == lastCountryId).Select(y => y.Country).FirstOrDefault();
            #endregion
            #region kapadokya tur kapasitesi
            lblCappadociaLocationCapacity.Text = db.Tbl_Location.Where(x=>x.City=="Kapadokya").Select(y=>y.Capacity).FirstOrDefault().ToString();
            #endregion
            #region Türkiye Turları Ortalama Kapasite
            lblTurkeyCapacityAverage.Text = db.Tbl_Location.Where(x=>x.Country=="Türkiye").Average(y=>y.Capacity).ToString();
            #endregion
            #region Roma Gezisinin Rehberinin İsmi
            var romeguideId = db.Tbl_Location.Where(x=>x.City=="Roma Turistik").Select(y=>y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text=db.Tbl_Guide.Where(x=>x.guideId==romeguideId).Select(y=>y.guideName+ " "+ y.guideSurname).FirstOrDefault().ToString();
            #endregion
            #region en yüksek kapasiteli tur
            var maxCapacity = db.Tbl_Location.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text = db.Tbl_Location.Where(x=>x.Capacity==maxCapacity).Select(y=>y.City).FirstOrDefault().ToString();
            #endregion
            #region en yüksek fiyatlı lokasyon
            var maxPrice = db.Tbl_Location.Max(x => x.Price);
            lblMaxPriceLocation.Text=db.Tbl_Location.Where(x=>x.Price==maxPrice).Select(y=>y.City).FirstOrDefault().ToString();
            #endregion
            #region ayşegül çınarın tur sayısı
            var guideIdByNameAysegulCınar = db.Tbl_Guide.Where(x => x.guideName == "Ayşegül" && x.guideSurname == "Çınar").Select(y => y.guideId).FirstOrDefault();
            lblAysegulCinarLocation.Text=db.Tbl_Location.Where(x=>x.GuideId==guideIdByNameAysegulCınar).Count().ToString();
            #endregion
        }
    }
}
