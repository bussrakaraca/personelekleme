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

namespace odev
{
    public partial class FormArama : Form
    {
        public FormArama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string pathFile = @"C:\Users\SOVLERA\Downloads\OKUL\odev\odev\data.txt";
            FileStream fs = new FileStream(pathFile, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string veri = sw.ReadLine();
            string[] parcala = veri.Split('|');

            List<Personel> personnels = Personel.DosyadanOku();

            for (int i = 0; i < parcala.Length - 1; i++)
            {
                if (personnels != null)
                {
                    foreach (Personel item in personnels)
                    {
                        if (item.Ad == txtSearch.Text)
                        {
                            MessageBox.Show("Aradığınız personelin kaydı bulundu .. ");
                            FormKayit kayit = new FormKayit();
                            
                            kayit.MdiParent = Program.MainForm;
                            kayit.Hide();
                            kayit.Show();
                            return;
                        }
                    }
                }
            }
               
            MessageBox.Show("Aradığınız personelin kaydı bulunamadı.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

         
        }

        private void FormArama_Load(object sender, EventArgs e)
        {

        }
    }
}
