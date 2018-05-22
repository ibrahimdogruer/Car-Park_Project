namespace Odev1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnKuyruk = new System.Windows.Forms.Button();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnOncelik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnAzbekleyen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOncelik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAz = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 225);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(500, 542);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnKuyruk
            // 
            this.btnKuyruk.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnKuyruk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKuyruk.Location = new System.Drawing.Point(539, 24);
            this.btnKuyruk.Name = "btnKuyruk";
            this.btnKuyruk.Size = new System.Drawing.Size(164, 65);
            this.btnKuyruk.TabIndex = 1;
            this.btnKuyruk.Text = "KUYRUK İLE  ÇIKIŞ YAP";
            this.btnKuyruk.UseVisualStyleBackColor = false;
            this.btnKuyruk.Click += new System.EventHandler(this.btnKuyruk_Click);
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(280, 43);
            this.txtSayi.Multiline = true;
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(135, 30);
            this.txtSayi.TabIndex = 2;
            this.txtSayi.TextChanged += new System.EventHandler(this.txtSayi_TextChanged);
            // 
            // btnOncelik
            // 
            this.btnOncelik.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOncelik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOncelik.Location = new System.Drawing.Point(727, 24);
            this.btnOncelik.Name = "btnOncelik";
            this.btnOncelik.Size = new System.Drawing.Size(162, 65);
            this.btnOncelik.TabIndex = 3;
            this.btnOncelik.Text = "ÖNCELİK KUYRUĞU İLE ÇIKIŞ YAP";
            this.btnOncelik.UseVisualStyleBackColor = false;
            this.btnOncelik.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(110, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Araç Sayısını Giriniz:";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(280, 89);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(135, 37);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Araç Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnAzbekleyen
            // 
            this.btnAzbekleyen.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAzbekleyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAzbekleyen.Location = new System.Drawing.Point(911, 24);
            this.btnAzbekleyen.Name = "btnAzbekleyen";
            this.btnAzbekleyen.Size = new System.Drawing.Size(161, 65);
            this.btnAzbekleyen.TabIndex = 6;
            this.btnAzbekleyen.Text = "DAHA AZ BEKLEYEN ARABALAR";
            this.btnAzbekleyen.UseVisualStyleBackColor = false;
            this.btnAzbekleyen.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "KUYRUKDAN ÇIKAN ARABALAR";
            // 
            // txtOncelik
            // 
            this.txtOncelik.Location = new System.Drawing.Point(539, 225);
            this.txtOncelik.Multiline = true;
            this.txtOncelik.Name = "txtOncelik";
            this.txtOncelik.Size = new System.Drawing.Size(500, 542);
            this.txtOncelik.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(583, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "ÖNCELİKLİ KUYRUKDAN ÇIKAN ARABALAR";
            // 
            // txtAz
            // 
            this.txtAz.Location = new System.Drawing.Point(1059, 225);
            this.txtAz.Multiline = true;
            this.txtAz.Name = "txtAz";
            this.txtAz.Size = new System.Drawing.Size(500, 542);
            this.txtAz.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1157, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "DAHA AZ BEKLEYEN ARABALAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1585, 788);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOncelik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAzbekleyen);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOncelik);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.btnKuyruk);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnKuyruk;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnOncelik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnAzbekleyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOncelik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAz;
        private System.Windows.Forms.Label label4;
    }
}

