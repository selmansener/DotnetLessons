namespace TankerNakliyeMaliyet
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMesafe = new System.Windows.Forms.TextBox();
            this.lblMesafe = new System.Windows.Forms.Label();
            this.chbGidisDonus = new System.Windows.Forms.CheckBox();
            this.txtTankerKiraBedeli = new System.Windows.Forms.TextBox();
            this.lblTankerKiraBedeli = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMesafe
            // 
            this.txtMesafe.Location = new System.Drawing.Point(12, 88);
            this.txtMesafe.Name = "txtMesafe";
            this.txtMesafe.Size = new System.Drawing.Size(216, 23);
            this.txtMesafe.TabIndex = 0;
            // 
            // lblMesafe
            // 
            this.lblMesafe.AutoSize = true;
            this.lblMesafe.Location = new System.Drawing.Point(12, 70);
            this.lblMesafe.Name = "lblMesafe";
            this.lblMesafe.Size = new System.Drawing.Size(73, 15);
            this.lblMesafe.TabIndex = 1;
            this.lblMesafe.Text = "Mesafe (km)";
            // 
            // chbGidisDonus
            // 
            this.chbGidisDonus.AutoSize = true;
            this.chbGidisDonus.Location = new System.Drawing.Point(12, 117);
            this.chbGidisDonus.Name = "chbGidisDonus";
            this.chbGidisDonus.Size = new System.Drawing.Size(115, 19);
            this.chbGidisDonus.TabIndex = 2;
            this.chbGidisDonus.Text = "Gidiş Dönüş mü?";
            this.chbGidisDonus.UseVisualStyleBackColor = true;
            // 
            // txtTankerKiraBedeli
            // 
            this.txtTankerKiraBedeli.Location = new System.Drawing.Point(274, 88);
            this.txtTankerKiraBedeli.Name = "txtTankerKiraBedeli";
            this.txtTankerKiraBedeli.Size = new System.Drawing.Size(206, 23);
            this.txtTankerKiraBedeli.TabIndex = 3;
            // 
            // lblTankerKiraBedeli
            // 
            this.lblTankerKiraBedeli.AutoSize = true;
            this.lblTankerKiraBedeli.Location = new System.Drawing.Point(274, 70);
            this.lblTankerKiraBedeli.Name = "lblTankerKiraBedeli";
            this.lblTankerKiraBedeli.Size = new System.Drawing.Size(99, 15);
            this.lblTankerKiraBedeli.TabIndex = 4;
            this.lblTankerKiraBedeli.Text = "Tanker Kira Bedeli";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(500, 87);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 5;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Enabled = false;
            this.txtSonuc.Location = new System.Drawing.Point(12, 165);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(216, 23);
            this.txtSonuc.TabIndex = 6;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(12, 147);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(102, 15);
            this.lblSonuc.TabIndex = 7;
            this.lblSonuc.Text = "Sonuç (KDV hariç)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 671);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblTankerKiraBedeli);
            this.Controls.Add(this.txtTankerKiraBedeli);
            this.Controls.Add(this.chbGidisDonus);
            this.Controls.Add(this.lblMesafe);
            this.Controls.Add(this.txtMesafe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtMesafe;
        private Label lblMesafe;
        private CheckBox chbGidisDonus;
        private TextBox txtTankerKiraBedeli;
        private Label lblTankerKiraBedeli;
        private Button btnHesapla;
        private TextBox txtSonuc;
        private Label lblSonuc;
    }
}