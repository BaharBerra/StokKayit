using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokKayit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        SqlConnection baglanti = new SqlConnection("Data Source = LAPTOP-OVAEQ4V5\\SQLEXPRESS ; Initial Catalog = STOK1 ; Integrated Security = True ");

 private void button1_Click(object sender, EventArgs e)
        { //EKLE
            String t1 = textBox1.Text;//MalzemeKodu
            String t2 = textBox2.Text;//MalzemeAdi
            String t3 = textBox3.Text;//YillikSatis
            String t4 = textBox4.Text;//BirimFiyat
            String t5 = textBox5.Text;//MinStok
            String t6 = textBox6.Text;//Tsursi

            baglanti.Open();
            SqlCommand komut = new SqlCommand(" INSERT INTO Malzemeler (MalzemeKodu ,MalzemeAdi, YillikSatis , BirimFiyat , MiniStok , TSuresi ) VALUES ( '" + t1 + "', '" + t2 + "', '" + t3 + "', '" + t4 + "', '" + t5 + "', '" + t6 + "' )", baglanti ) ;
            komut.ExecuteNonQuery();
            baglanti.Close();
            listele();


        }
        private void button2_Click(object sender, EventArgs e)
        {//SİL

            String t1 = textBox1.Text; // seçilen satırın malzeme kodunu al
            baglanti .Open();
            SqlCommand komut = new SqlCommand("DELETE FROM Malzemeler WHERE MalzemeKodu = ('" + t1 + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti .Close();
            listele();
        }
        private void button3_Click(object sender, EventArgs e)
        { //GÜNCELLE
            String t1 = textBox1.Text;//MalzemeKodu
            String t2 = textBox2.Text;//MalzemeAdi
            String t3 = textBox3.Text;//YillikSatis
            String t4 = textBox4.Text;//BirimFiyat
            String t5 = textBox5.Text;//MinStok
            String t6 = textBox6.Text;//Tsursi

            baglanti .Open();
            SqlCommand komut = new SqlCommand( "UPDATE Malzemeler SET MalzemeKodu ='"+t1+ "',MalzemeAdi = '"+ t2 + "',YillikSatis ='"+t3+ "',BirimFiyat ='"+t4+"',MiniStok ='" + t5+"', TSuresi= '"+t6+ "' WHERE MalzemeKodu='"+t1+"'   ", baglanti);
            komut .ExecuteNonQuery();
            baglanti .Close();
            listele();


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { // seçilen datanın tıklanarak bilgiyi otomatik ekrana girmesi için
            textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();

        }

        private void listele()// veritabanı kayıtlarının görüntülenmesi
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(" Select * from Malzemeler ", baglanti );
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;   
            baglanti.Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       
    }

}
