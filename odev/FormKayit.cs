using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using odev.Properties;

namespace odev
{
    public partial class FormKayit : Form
    {
        public FormKayit()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtMeslek.Clear();
            txtGSM.Clear();
            txtIsTelefonu.Clear();
            radioBtnBekar.Checked = false;
            radioBtnEvli.Checked = false;
            radioBtnErkek.Checked = false;
            radioBtnKadin.Checked = false;
            txtAdres.Clear();
            numericUpDownMaas.Value = 0;
            txtEmail.Clear();
            dateTimePicker1.Value = DateTime.Today;
        }

      


        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "" || txtSoyad.Text == "" || txtMeslek.Text == "" || numericUpDownMaas.Value == 0 || txtEmail.Text == "" || txtAdres.Text == "" || radioBtnErkek.Checked == false && radioBtnKadin.Checked == false || radioBtnEvli.Checked == false && radioBtnBekar.Checked == false)
            {
                MessageBox.Show("Boş Alan bırakamazsınız !!!");
            }
            else
            {
                Personel personel = new Personel(txtAd.Text, txtSoyad.Text);
                personel.Dogum_Tarihi = dateTimePicker1.Value;
                personel.Meslek = txtMeslek.Text;
                personel.Maas = (int)numericUpDownMaas.Value;
                personel.email = txtEmail.Text;
                personel.adres = txtAdres.Text;
                personel.ajanda[0] = new Ajanda("İş", txtIsTelefonu.Text);
                personel.ajanda[1] = new Ajanda("Gsm", txtGSM.Text);

                if (radioBtnEvli.Checked)
                {
                    personel.Medeni_Durum = MEDENİDURUM.EVLİ;
                }
                if (radioBtnBekar.Checked)
                {
                    personel.Medeni_Durum = MEDENİDURUM.BEKAR;
                }
                if (radioBtnKadin.Checked)
                {
                    personel.Cinsiyet = CINSIYET.KADIN;
                }
                if (radioBtnErkek.Checked)
                {
                    personel.Cinsiyet = CINSIYET.ERKEK;
                }

                Personel[] record = new Personel[11];
                record[0] = personel;
                personel.DosyayaYaz(record);
                MessageBox.Show("Kayıt işlemi data.txt ' ye başarıyla kaydedilmiştir.");
            }

           

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioBtnKadin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnErkek_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioBtnBekar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownMaas_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMeslek_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtIsTelefonu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGSM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormKayit_Load(object sender, EventArgs e)
        {
            //Personel prs = new Personel("", "");
            //if (prs == null)
            //    return;


            //txtAd.Text = prs.Ad;
            //txtSoyad.Text = prs.Soyad;
            //txtEmail.Text = prs.email;
            //txtAdres.Text = prs.adres;
            //txtMeslek.Text = prs.Meslek;
            //numericUpDownMaas.Maximum = prs.Maas + 1000;
            //numericUpDownMaas.Value = prs.Maas;

            //txtIsTelefonu.Text = prs.ajanda[0].TelNo;
            //txtGSM.Text = prs.ajanda[1].TelNo;

            //if (prs.Cinsiyet == CINSIYET.ERKEK)
            //{
            //    radioBtnErkek.Checked = true;
            //}
            //else
            //{
            //    radioBtnKadin.Checked = true;
            //}
            //if (prs.Medeni_Durum == MEDENİDURUM.BEKAR)
            //{
            //    radioBtnBekar.Checked = true; ;
            //}
            //else
            //{
            //    radioBtnEvli.Checked = true;
            //}
        }
    }
}


