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

namespace odev
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void personelKayıtEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormKayit"] == null)
            {
                FormKayit frmKayit = new FormKayit();
                frmKayit.MdiParent = this;
                frmKayit.Show();
                frmKayit.Location = new Point(20, 20);

            }
            else
            {
                MessageBox.Show("Personel Kayıt Ekranı zaten mevcut ! ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void personelAramaEkranıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FormArama"] == null)
            {

                FormArama frmArama = new FormArama();
                frmArama.MdiParent = this;
                frmArama.Show();
                frmArama.Location = new Point(200, 550);
            }
            else
            {
                MessageBox.Show("Personel Arama Ekranı zaten mevcut ! ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
    }
}
