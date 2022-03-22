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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz ? ", "Çıkış Bildirisi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                Application.Exit();
            }
        }

        List<String> users = new List<string>();

        private void OKBtn_Click(object sender, EventArgs e)
        {
            if (userName.Text == "" || password.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmadan doğru bilgileri giriniz .. ", "UYARI !! ", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }


            string userInfo = userName.Text + "#" + password.Text;
            foreach(String item in users)
            {
                if (item == userInfo)
                {
                    MainForm mf = new MainForm();
                   
                    mf.Show();
                    this.Hide();
                    return;
                }
            }


               // MessageBox.Show("Lütfen boş alan bırakmadan doğru bilgileri giriniz .. ", "UYARI !! ", MessageBoxButtons.OK,MessageBoxIcon.Information);


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Tüm kullanıcıları yükle
            //StreamReader --> Dosya içerisinden veri okumayı sağlar.
            // Application.StartupPath --> uygulamanın çalıştığı dizini döner. Yani direk C dosyasında projemin olduğu yerde txt dosyasını arar.

            try
            {
                using (StreamReader reader = new StreamReader(Application.StartupPath + "\\user.txt"))
                {
                    string veri;
                    while ((veri = reader.ReadLine()) != null)
                    {
                        users.Add(veri);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata oluştu . " + ex.Message);
            }

            
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
