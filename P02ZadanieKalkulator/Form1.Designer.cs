
namespace P02ZadanieKalkulator
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
            this.btnSiedem = new System.Windows.Forms.Button();
            this.btnOsiem = new System.Windows.Forms.Button();
            this.btnDziewiec = new System.Windows.Forms.Button();
            this.btnSzesc = new System.Windows.Forms.Button();
            this.btnPiec = new System.Windows.Forms.Button();
            this.btnCZtery = new System.Windows.Forms.Button();
            this.btnTrzy = new System.Windows.Forms.Button();
            this.btnDwa = new System.Windows.Forms.Button();
            this.btnJeden = new System.Windows.Forms.Button();
            this.txtWyswietlacz = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnDzielenie = new System.Windows.Forms.Button();
            this.btnMnozenie = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnWynik = new System.Windows.Forms.Button();
            this.btnCzysc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSiedem
            // 
            this.btnSiedem.Location = new System.Drawing.Point(9, 33);
            this.btnSiedem.Name = "btnSiedem";
            this.btnSiedem.Size = new System.Drawing.Size(43, 40);
            this.btnSiedem.TabIndex = 0;
            this.btnSiedem.Text = "7";
            this.btnSiedem.UseVisualStyleBackColor = true;
            this.btnSiedem.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnOsiem
            // 
            this.btnOsiem.Location = new System.Drawing.Point(58, 33);
            this.btnOsiem.Name = "btnOsiem";
            this.btnOsiem.Size = new System.Drawing.Size(43, 40);
            this.btnOsiem.TabIndex = 1;
            this.btnOsiem.Text = "8";
            this.btnOsiem.UseVisualStyleBackColor = true;
            this.btnOsiem.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnDziewiec
            // 
            this.btnDziewiec.Location = new System.Drawing.Point(107, 33);
            this.btnDziewiec.Name = "btnDziewiec";
            this.btnDziewiec.Size = new System.Drawing.Size(43, 40);
            this.btnDziewiec.TabIndex = 2;
            this.btnDziewiec.Text = "9";
            this.btnDziewiec.UseVisualStyleBackColor = true;
            this.btnDziewiec.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnSzesc
            // 
            this.btnSzesc.Location = new System.Drawing.Point(107, 79);
            this.btnSzesc.Name = "btnSzesc";
            this.btnSzesc.Size = new System.Drawing.Size(43, 40);
            this.btnSzesc.TabIndex = 5;
            this.btnSzesc.Text = "6";
            this.btnSzesc.UseVisualStyleBackColor = true;
            this.btnSzesc.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnPiec
            // 
            this.btnPiec.Location = new System.Drawing.Point(58, 79);
            this.btnPiec.Name = "btnPiec";
            this.btnPiec.Size = new System.Drawing.Size(43, 40);
            this.btnPiec.TabIndex = 4;
            this.btnPiec.Text = "5";
            this.btnPiec.UseVisualStyleBackColor = true;
            this.btnPiec.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnCZtery
            // 
            this.btnCZtery.Location = new System.Drawing.Point(9, 79);
            this.btnCZtery.Name = "btnCZtery";
            this.btnCZtery.Size = new System.Drawing.Size(43, 40);
            this.btnCZtery.TabIndex = 3;
            this.btnCZtery.Text = "4";
            this.btnCZtery.UseVisualStyleBackColor = true;
            this.btnCZtery.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnTrzy
            // 
            this.btnTrzy.Location = new System.Drawing.Point(107, 125);
            this.btnTrzy.Name = "btnTrzy";
            this.btnTrzy.Size = new System.Drawing.Size(43, 40);
            this.btnTrzy.TabIndex = 8;
            this.btnTrzy.Text = "3";
            this.btnTrzy.UseVisualStyleBackColor = true;
            this.btnTrzy.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnDwa
            // 
            this.btnDwa.Location = new System.Drawing.Point(58, 125);
            this.btnDwa.Name = "btnDwa";
            this.btnDwa.Size = new System.Drawing.Size(43, 40);
            this.btnDwa.TabIndex = 7;
            this.btnDwa.Text = "2";
            this.btnDwa.UseVisualStyleBackColor = true;
            this.btnDwa.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnJeden
            // 
            this.btnJeden.Location = new System.Drawing.Point(9, 125);
            this.btnJeden.Name = "btnJeden";
            this.btnJeden.Size = new System.Drawing.Size(43, 40);
            this.btnJeden.TabIndex = 6;
            this.btnJeden.Text = "1";
            this.btnJeden.UseVisualStyleBackColor = true;
            this.btnJeden.Click += new System.EventHandler(this.btnJeden_Click);
            // 
            // txtWyswietlacz
            // 
            this.txtWyswietlacz.Location = new System.Drawing.Point(9, 7);
            this.txtWyswietlacz.Name = "txtWyswietlacz";
            this.txtWyswietlacz.Size = new System.Drawing.Size(195, 20);
            this.txtWyswietlacz.TabIndex = 9;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(161, 125);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(43, 40);
            this.btnPlus.TabIndex = 12;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnDzielenie
            // 
            this.btnDzielenie.Location = new System.Drawing.Point(161, 79);
            this.btnDzielenie.Name = "btnDzielenie";
            this.btnDzielenie.Size = new System.Drawing.Size(43, 40);
            this.btnDzielenie.TabIndex = 11;
            this.btnDzielenie.Text = "/";
            this.btnDzielenie.UseVisualStyleBackColor = true;
            this.btnDzielenie.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnMnozenie
            // 
            this.btnMnozenie.Location = new System.Drawing.Point(161, 33);
            this.btnMnozenie.Name = "btnMnozenie";
            this.btnMnozenie.Size = new System.Drawing.Size(43, 40);
            this.btnMnozenie.TabIndex = 10;
            this.btnMnozenie.Text = "*";
            this.btnMnozenie.UseVisualStyleBackColor = true;
            this.btnMnozenie.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(161, 171);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(43, 40);
            this.btnMinus.TabIndex = 16;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnCyfra_Click);
            // 
            // btnWynik
            // 
            this.btnWynik.Location = new System.Drawing.Point(107, 171);
            this.btnWynik.Name = "btnWynik";
            this.btnWynik.Size = new System.Drawing.Size(43, 40);
            this.btnWynik.TabIndex = 15;
            this.btnWynik.Text = "=";
            this.btnWynik.UseVisualStyleBackColor = true;
            this.btnWynik.Click += new System.EventHandler(this.btnWynik_Click);
            // 
            // btnCzysc
            // 
            this.btnCzysc.Location = new System.Drawing.Point(58, 171);
            this.btnCzysc.Name = "btnCzysc";
            this.btnCzysc.Size = new System.Drawing.Size(43, 40);
            this.btnCzysc.TabIndex = 14;
            this.btnCzysc.Text = "C";
            this.btnCzysc.UseVisualStyleBackColor = true;
            this.btnCzysc.Click += new System.EventHandler(this.btnCzysc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 228);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnWynik);
            this.Controls.Add(this.btnCzysc);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDzielenie);
            this.Controls.Add(this.btnMnozenie);
            this.Controls.Add(this.txtWyswietlacz);
            this.Controls.Add(this.btnTrzy);
            this.Controls.Add(this.btnDwa);
            this.Controls.Add(this.btnJeden);
            this.Controls.Add(this.btnSzesc);
            this.Controls.Add(this.btnPiec);
            this.Controls.Add(this.btnCZtery);
            this.Controls.Add(this.btnDziewiec);
            this.Controls.Add(this.btnOsiem);
            this.Controls.Add(this.btnSiedem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSiedem;
        private System.Windows.Forms.Button btnOsiem;
        private System.Windows.Forms.Button btnDziewiec;
        private System.Windows.Forms.Button btnSzesc;
        private System.Windows.Forms.Button btnPiec;
        private System.Windows.Forms.Button btnCZtery;
        private System.Windows.Forms.Button btnTrzy;
        private System.Windows.Forms.Button btnDwa;
        private System.Windows.Forms.Button btnJeden;
        private System.Windows.Forms.TextBox txtWyswietlacz;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnDzielenie;
        private System.Windows.Forms.Button btnMnozenie;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnWynik;
        private System.Windows.Forms.Button btnCzysc;
    }
}

