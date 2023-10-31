using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Site_Emlak_Programı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int id = 0;
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-BJO2DGU\\SQLEXPRESS;Initial Catalog=siteler;Integrated Security=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * from siteBilgi",baglan);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr["id"].ToString();
                ekle.SubItems.Add(dr["site"].ToString());
                ekle.SubItems.Add(dr["oda"].ToString());
                ekle.SubItems.Add(dr["metre"].ToString());
                ekle.SubItems.Add(dr["fiyat"].ToString());
                ekle.SubItems.Add(dr["blok"].ToString());
                ekle.SubItems.Add(dr["daire"].ToString());
                ekle.SubItems.Add(dr["adSoyad"].ToString());
                ekle.SubItems.Add(dr["telefon"].ToString());
                ekle.SubItems.Add(dr["notlar"].ToString());
                ekle.SubItems.Add(dr["satkira"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
                Zambak Sitesi
                Papatya Sitesi
                Gül Sitesi
                Menekşe Sitesi
            
            */
            if(cmSite.Text=="ZambakSit")
            {
                btnZambak.BackColor = Color.Yellow;
                btnPapatya.BackColor = Color.Gray;
                btnGül.BackColor = Color.Gray;
                btnMenekşe.BackColor = Color.Gray;
            }
            if (cmSite.Text == "PapatyaSit")
            {
                btnZambak.BackColor = Color.Gray;
                btnPapatya.BackColor = Color.Yellow;
                btnGül.BackColor = Color.Gray;
                btnMenekşe.BackColor = Color.Gray;
            }
            if (cmSite.Text == "GülSit")
            {
                btnZambak.BackColor = Color.Gray;
                btnPapatya.BackColor = Color.Gray;
                btnGül.BackColor = Color.Yellow;
                btnMenekşe.BackColor = Color.Gray;
            }
            if (cmSite.Text == "MenekşeSit")
            {
                btnZambak.BackColor = Color.Gray;
                btnPapatya.BackColor = Color.Gray;
                btnGül.BackColor = Color.Gray;
                btnMenekşe.BackColor = Color.Yellow;
            }

        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
baglan.Open();                                              //1    2   3    4     5     6    7     8        9      10     11
SqlCommand komutekle = new SqlCommand("insert into siteBilgi (id,site,oda,metre,fiyat,blok,daire,adSoyad,telefon,notlar,satkira) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)",baglan);
            komutekle.Parameters.AddWithValue("@p1",txId.Text);
            komutekle.Parameters.AddWithValue("@p2", cmSite.Text);
            komutekle.Parameters.AddWithValue("@p3", cmOdaSayisi.Text);
            komutekle.Parameters.AddWithValue("@p4", txMetre.Text);
            komutekle.Parameters.AddWithValue("@p5", txFiyat.Text);
            komutekle.Parameters.AddWithValue("@p6", cmBlok.Text);
            komutekle.Parameters.AddWithValue("@p7", txDaire.Text);
            komutekle.Parameters.AddWithValue("@p8", txAdSoyad.Text);
            komutekle.Parameters.AddWithValue("@p9", txTel.Text);
            komutekle.Parameters.AddWithValue("@p10", txNot.Text);
            komutekle.Parameters.AddWithValue("@p11", cmSatKira.Text);
            komutekle.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komutsil = new SqlCommand("delete from siteBilgi where id =@k1", baglan);
            komutsil.Parameters.AddWithValue("@k1", txId.Text);
            komutsil.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = 0; 
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txId.Text = listView1.SelectedItems[0].SubItems[0].Text;
            cmSite.Text = listView1.SelectedItems[0].SubItems[1].Text;
            cmSatKira.Text = listView1.SelectedItems[0].SubItems[10].Text;
            cmOdaSayisi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txMetre.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txFiyat.Text = listView1.SelectedItems[0].SubItems[4].Text;
            cmBlok.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txDaire.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txAdSoyad.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txTel.Text = listView1.SelectedItems[0].SubItems[8].Text;
            txNot.Text = listView1.SelectedItems[0].SubItems[9].Text;
        }

        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komutduzenle = new SqlCommand("Update siteBilgi Set site=@v2, oda=@v3, metre=@v4, fiyat =@v5, blok=@v6, daire= @v7, adSoyad=@v8,telefon=@v9, notlar=@v10, satkira=@v11 Where id=@v1", baglan);
            komutduzenle.Parameters.AddWithValue("@v1",txId.Text);
            komutduzenle.Parameters.AddWithValue("@v2", cmSite.Text);
            komutduzenle.Parameters.AddWithValue("@v3", cmOdaSayisi.Text);
            komutduzenle.Parameters.AddWithValue("@v4", txMetre.Text);
            komutduzenle.Parameters.AddWithValue("@v5", txFiyat.Text);
            komutduzenle.Parameters.AddWithValue("@v6", cmBlok.Text);
            komutduzenle.Parameters.AddWithValue("@v7", txDaire.Text);
            komutduzenle.Parameters.AddWithValue("@v8", txAdSoyad.Text);
            komutduzenle.Parameters.AddWithValue("@v9", txTel.Text);
            komutduzenle.Parameters.AddWithValue("@v10", txNot.Text);
            komutduzenle.Parameters.AddWithValue("@v11", cmSatKira.Text);
            komutduzenle.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
        }
    }
}
