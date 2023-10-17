namespace bolum1odev1_847
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
            this.txtOdeme = new System.Windows.Forms.TextBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.btnOde = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOdeme
            // 
            this.txtOdeme.Location = new System.Drawing.Point(108, 55);
            this.txtOdeme.Name = "txtOdeme";
            this.txtOdeme.Size = new System.Drawing.Size(129, 20);
            this.txtOdeme.TabIndex = 0;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(22, 58);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(65, 13);
            this.lblTutar.TabIndex = 1;
            this.lblTutar.Text = "toplam tutar:";
            // 
            // btnOde
            // 
            this.btnOde.Location = new System.Drawing.Point(25, 289);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(209, 37);
            this.btnOde.TabIndex = 2;
            this.btnOde.Text = "ödeme yap";
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb5);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Controls.Add(this.rb4);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Location = new System.Drawing.Point(25, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 166);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ödeme şekli";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(15, 28);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(71, 17);
            this.rb1.TabIndex = 4;
            this.rb1.TabStop = true;
            this.rb1.Text = "tek çekim";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(15, 51);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(119, 17);
            this.rb2.TabIndex = 5;
            this.rb2.TabStop = true;
            this.rb2.Text = "2 taksit( %5 ek fiyat)";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(15, 77);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(119, 17);
            this.rb3.TabIndex = 6;
            this.rb3.TabStop = true;
            this.rb3.Text = "3 taksit( %5 ek fiyat)";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(15, 100);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(125, 17);
            this.rb4.TabIndex = 7;
            this.rb4.TabStop = true;
            this.rb4.Text = "4 taksit( %10 ek fiyat)";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Location = new System.Drawing.Point(15, 123);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(125, 17);
            this.rb5.TabIndex = 8;
            this.rb5.TabStop = true;
            this.rb5.Text = "5 taksit( %10 ek fiyat)";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.txtOdeme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOdeme;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
    }
}

