namespace Odev2
{
    partial class Form1
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
            this.txtIslemSayisi = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCikanArac = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblkat1siradakiler = new System.Windows.Forms.Label();
            this.ikincikatGrpbox = new System.Windows.Forms.GroupBox();
            this.lblIkinciKat = new System.Windows.Forms.Label();
            this.bdrmkatGrpbox = new System.Windows.Forms.GroupBox();
            this.lblBodrumKat = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblOtopark = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ikincikatGrpbox.SuspendLayout();
            this.bdrmkatGrpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIslemSayisi
            // 
            this.txtIslemSayisi.Location = new System.Drawing.Point(712, 268);
            this.txtIslemSayisi.Margin = new System.Windows.Forms.Padding(2);
            this.txtIslemSayisi.Name = "txtIslemSayisi";
            this.txtIslemSayisi.Size = new System.Drawing.Size(224, 20);
            this.txtIslemSayisi.TabIndex = 19;
            this.txtIslemSayisi.Text = "5 saniyede yapılan işlem sayısı";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Enabled = false;
            this.btnHesapla.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(769, 206);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(2);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(109, 41);
            this.btnHesapla.TabIndex = 18;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCikanArac);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(712, 92);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(224, 58);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Çıkan Arabalar";
            // 
            // lblCikanArac
            // 
            this.lblCikanArac.AutoSize = true;
            this.lblCikanArac.Location = new System.Drawing.Point(4, 24);
            this.lblCikanArac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCikanArac.Name = "lblCikanArac";
            this.lblCikanArac.Size = new System.Drawing.Size(45, 13);
            this.lblCikanArac.TabIndex = 3;
            this.lblCikanArac.Text = "Cikanlar";
            this.lblCikanArac.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblkat1siradakiler);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(226, 92);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(224, 380);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Birinci Kattaki Arabalar";
            // 
            // lblkat1siradakiler
            // 
            this.lblkat1siradakiler.AutoSize = true;
            this.lblkat1siradakiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkat1siradakiler.Location = new System.Drawing.Point(4, 23);
            this.lblkat1siradakiler.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblkat1siradakiler.Name = "lblkat1siradakiler";
            this.lblkat1siradakiler.Size = new System.Drawing.Size(32, 15);
            this.lblkat1siradakiler.TabIndex = 2;
            this.lblkat1siradakiler.Text = "Kat1";
            this.lblkat1siradakiler.Visible = false;
            // 
            // ikincikatGrpbox
            // 
            this.ikincikatGrpbox.Controls.Add(this.lblIkinciKat);
            this.ikincikatGrpbox.ForeColor = System.Drawing.SystemColors.Control;
            this.ikincikatGrpbox.Location = new System.Drawing.Point(500, 92);
            this.ikincikatGrpbox.Margin = new System.Windows.Forms.Padding(2);
            this.ikincikatGrpbox.Name = "ikincikatGrpbox";
            this.ikincikatGrpbox.Padding = new System.Windows.Forms.Padding(2);
            this.ikincikatGrpbox.Size = new System.Drawing.Size(190, 380);
            this.ikincikatGrpbox.TabIndex = 13;
            this.ikincikatGrpbox.TabStop = false;
            this.ikincikatGrpbox.Text = "2.Kat";
            // 
            // lblIkinciKat
            // 
            this.lblIkinciKat.AutoSize = true;
            this.lblIkinciKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIkinciKat.Location = new System.Drawing.Point(11, 24);
            this.lblIkinciKat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIkinciKat.Name = "lblIkinciKat";
            this.lblIkinciKat.Size = new System.Drawing.Size(32, 15);
            this.lblIkinciKat.TabIndex = 2;
            this.lblIkinciKat.Text = "Kat2";
            this.lblIkinciKat.Visible = false;
            // 
            // bdrmkatGrpbox
            // 
            this.bdrmkatGrpbox.Controls.Add(this.lblBodrumKat);
            this.bdrmkatGrpbox.ForeColor = System.Drawing.SystemColors.Control;
            this.bdrmkatGrpbox.Location = new System.Drawing.Point(15, 92);
            this.bdrmkatGrpbox.Margin = new System.Windows.Forms.Padding(2);
            this.bdrmkatGrpbox.Name = "bdrmkatGrpbox";
            this.bdrmkatGrpbox.Padding = new System.Windows.Forms.Padding(2);
            this.bdrmkatGrpbox.Size = new System.Drawing.Size(175, 380);
            this.bdrmkatGrpbox.TabIndex = 15;
            this.bdrmkatGrpbox.TabStop = false;
            this.bdrmkatGrpbox.Text = "Bodrum Kat";
            // 
            // lblBodrumKat
            // 
            this.lblBodrumKat.AutoSize = true;
            this.lblBodrumKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBodrumKat.Location = new System.Drawing.Point(11, 24);
            this.lblBodrumKat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBodrumKat.Name = "lblBodrumKat";
            this.lblBodrumKat.Size = new System.Drawing.Size(36, 15);
            this.lblBodrumKat.TabIndex = 0;
            this.lblBodrumKat.Text = "Kat-1";
            this.lblBodrumKat.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(244, 37);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 41);
            this.button3.TabIndex = 14;
            this.button3.Text = "Arabaları Listele";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(712, 37);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 41);
            this.button2.TabIndex = 12;
            this.button2.Text = "Araba Çıkar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblOtopark
            // 
            this.lblOtopark.AutoSize = true;
            this.lblOtopark.BackColor = System.Drawing.Color.Transparent;
            this.lblOtopark.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOtopark.ForeColor = System.Drawing.Color.Beige;
            this.lblOtopark.Location = new System.Drawing.Point(430, 8);
            this.lblOtopark.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOtopark.Name = "lblOtopark";
            this.lblOtopark.Size = new System.Drawing.Size(236, 38);
            this.lblOtopark.TabIndex = 11;
            this.lblOtopark.Text = "KATLI OTOPARK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(988, 494);
            this.Controls.Add(this.txtIslemSayisi);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ikincikatGrpbox);
            this.Controls.Add(this.bdrmkatGrpbox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblOtopark);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ikincikatGrpbox.ResumeLayout(false);
            this.ikincikatGrpbox.PerformLayout();
            this.bdrmkatGrpbox.ResumeLayout(false);
            this.bdrmkatGrpbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIslemSayisi;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCikanArac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblkat1siradakiler;
        private System.Windows.Forms.GroupBox ikincikatGrpbox;
        private System.Windows.Forms.Label lblIkinciKat;
        private System.Windows.Forms.GroupBox bdrmkatGrpbox;
        private System.Windows.Forms.Label lblBodrumKat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblOtopark;
    }
}

