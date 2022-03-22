namespace odev
{
    partial class FormKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnKadin = new System.Windows.Forms.RadioButton();
            this.radioBtnErkek = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBtnEvli = new System.Windows.Forms.RadioButton();
            this.radioBtnBekar = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMeslek = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIsTelefonu = new System.Windows.Forms.TextBox();
            this.txtGSM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.numericUpDownMaas = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(143, 31);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(180, 25);
            this.txtAd.TabIndex = 3;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(93, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(71, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(143, 62);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(180, 25);
            this.txtSoyad.TabIndex = 3;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doğum Tarihi : ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(52, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cinsiyet :  ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(5, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Medeni Durum : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 25);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnKadin);
            this.groupBox1.Controls.Add(this.radioBtnErkek);
            this.groupBox1.Location = new System.Drawing.Point(143, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 47);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioBtnKadin
            // 
            this.radioBtnKadin.AutoSize = true;
            this.radioBtnKadin.Location = new System.Drawing.Point(102, 19);
            this.radioBtnKadin.Name = "radioBtnKadin";
            this.radioBtnKadin.Size = new System.Drawing.Size(63, 22);
            this.radioBtnKadin.TabIndex = 1;
            this.radioBtnKadin.TabStop = true;
            this.radioBtnKadin.Text = "Kadın";
            this.radioBtnKadin.UseVisualStyleBackColor = true;
            this.radioBtnKadin.CheckedChanged += new System.EventHandler(this.radioBtnKadin_CheckedChanged);
            // 
            // radioBtnErkek
            // 
            this.radioBtnErkek.AutoSize = true;
            this.radioBtnErkek.Location = new System.Drawing.Point(25, 19);
            this.radioBtnErkek.Name = "radioBtnErkek";
            this.radioBtnErkek.Size = new System.Drawing.Size(62, 22);
            this.radioBtnErkek.TabIndex = 0;
            this.radioBtnErkek.TabStop = true;
            this.radioBtnErkek.Text = "Erkek";
            this.radioBtnErkek.UseVisualStyleBackColor = true;
            this.radioBtnErkek.CheckedChanged += new System.EventHandler(this.radioBtnErkek_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtnEvli);
            this.groupBox2.Controls.Add(this.radioBtnBekar);
            this.groupBox2.Location = new System.Drawing.Point(143, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 47);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radioBtnEvli
            // 
            this.radioBtnEvli.AutoSize = true;
            this.radioBtnEvli.Location = new System.Drawing.Point(102, 19);
            this.radioBtnEvli.Name = "radioBtnEvli";
            this.radioBtnEvli.Size = new System.Drawing.Size(49, 22);
            this.radioBtnEvli.TabIndex = 1;
            this.radioBtnEvli.TabStop = true;
            this.radioBtnEvli.Text = "Evli";
            this.radioBtnEvli.UseVisualStyleBackColor = true;
            this.radioBtnEvli.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioBtnBekar
            // 
            this.radioBtnBekar.AutoSize = true;
            this.radioBtnBekar.Location = new System.Drawing.Point(25, 19);
            this.radioBtnBekar.Name = "radioBtnBekar";
            this.radioBtnBekar.Size = new System.Drawing.Size(62, 22);
            this.radioBtnBekar.TabIndex = 0;
            this.radioBtnBekar.TabStop = true;
            this.radioBtnBekar.Text = "Bekar";
            this.radioBtnBekar.UseVisualStyleBackColor = true;
            this.radioBtnBekar.CheckedChanged += new System.EventHandler(this.radioBtnBekar_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(76, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Maaş : ";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtMeslek
            // 
            this.txtMeslek.Location = new System.Drawing.Point(143, 129);
            this.txtMeslek.Name = "txtMeslek";
            this.txtMeslek.Size = new System.Drawing.Size(180, 25);
            this.txtMeslek.TabIndex = 3;
            this.txtMeslek.TextChanged += new System.EventHandler(this.txtMeslek_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(59, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Meslek : ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(39, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "İş Telefon : ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(70, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "GSM : ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtIsTelefonu
            // 
            this.txtIsTelefonu.Location = new System.Drawing.Point(146, 34);
            this.txtIsTelefonu.Name = "txtIsTelefonu";
            this.txtIsTelefonu.Size = new System.Drawing.Size(180, 28);
            this.txtIsTelefonu.TabIndex = 3;
            this.txtIsTelefonu.TextChanged += new System.EventHandler(this.txtIsTelefonu_TextChanged);
            // 
            // txtGSM
            // 
            this.txtGSM.Location = new System.Drawing.Point(146, 64);
            this.txtGSM.Name = "txtGSM";
            this.txtGSM.Size = new System.Drawing.Size(180, 28);
            this.txtGSM.TabIndex = 3;
            this.txtGSM.TextChanged += new System.EventHandler(this.txtGSM_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(67, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "Email : ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(146, 94);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 28);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(65, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "Adres : ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(146, 127);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(180, 96);
            this.txtAdres.TabIndex = 3;
            this.txtAdres.TextChanged += new System.EventHandler(this.txtAdres_TextChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearBtn.Location = new System.Drawing.Point(369, 298);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(122, 34);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "TEMİZLE";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveBtn.Location = new System.Drawing.Point(586, 265);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(122, 67);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "KAYDET";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // numericUpDownMaas
            // 
            this.numericUpDownMaas.Location = new System.Drawing.Point(143, 271);
            this.numericUpDownMaas.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownMaas.Name = "numericUpDownMaas";
            this.numericUpDownMaas.Size = new System.Drawing.Size(180, 25);
            this.numericUpDownMaas.TabIndex = 10;
            this.numericUpDownMaas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numericUpDownMaas);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtMeslek);
            this.groupBox3.Controls.Add(this.txtAd);
            this.groupBox3.Controls.Add(this.txtSoyad);
            this.groupBox3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 320);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personel Bilgileri";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtAdres);
            this.groupBox4.Controls.Add(this.txtIsTelefonu);
            this.groupBox4.Controls.Add(this.txtEmail);
            this.groupBox4.Controls.Add(this.txtGSM);
            this.groupBox4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(369, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(339, 247);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İletişim Bilgileri";
            // 
            // FormKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(728, 348);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.clearBtn);
            this.Name = "FormKayit";
            this.Text = "FormKayit";
            this.Load += new System.EventHandler(this.FormKayit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnKadin;
        private System.Windows.Forms.RadioButton radioBtnErkek;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBtnEvli;
        private System.Windows.Forms.RadioButton radioBtnBekar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMeslek;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIsTelefonu;
        private System.Windows.Forms.TextBox txtGSM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button saveBtn;
        public System.Windows.Forms.NumericUpDown numericUpDownMaas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}