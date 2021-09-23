
namespace P10ZadaniePogoda
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblWynik = new System.Windows.Forms.Label();
            this.pcbObrazek = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPogoda = new System.Windows.Forms.Button();
            this.txtNazwaMiasta = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbHistoria = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbObrazek)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(326, 205);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblWynik);
            this.tabPage1.Controls.Add(this.pcbObrazek);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnPogoda);
            this.tabPage1.Controls.Add(this.txtNazwaMiasta);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(318, 179);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pogoda";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWynik.Location = new System.Drawing.Point(153, 100);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(76, 25);
            this.lblWynik.TabIndex = 4;
            this.lblWynik.Text = "label2";
            // 
            // pcbObrazek
            // 
            this.pcbObrazek.Image = global::P10ZadaniePogoda.Properties.Resources.cloud;
            this.pcbObrazek.Location = new System.Drawing.Point(6, 64);
            this.pcbObrazek.Name = "pcbObrazek";
            this.pcbObrazek.Size = new System.Drawing.Size(131, 96);
            this.pcbObrazek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbObrazek.TabIndex = 3;
            this.pcbObrazek.TabStop = false;
            this.pcbObrazek.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa Miasta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPogoda
            // 
            this.btnPogoda.Location = new System.Drawing.Point(6, 6);
            this.btnPogoda.Name = "btnPogoda";
            this.btnPogoda.Size = new System.Drawing.Size(93, 52);
            this.btnPogoda.TabIndex = 1;
            this.btnPogoda.Text = "Podaj pogode";
            this.btnPogoda.UseVisualStyleBackColor = true;
            this.btnPogoda.Click += new System.EventHandler(this.btnPogoda_Click);
            // 
            // txtNazwaMiasta
            // 
            this.txtNazwaMiasta.Location = new System.Drawing.Point(105, 38);
            this.txtNazwaMiasta.Name = "txtNazwaMiasta";
            this.txtNazwaMiasta.Size = new System.Drawing.Size(100, 20);
            this.txtNazwaMiasta.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbHistoria);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(318, 179);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbHistoria
            // 
            this.lbHistoria.FormattingEnabled = true;
            this.lbHistoria.Location = new System.Drawing.Point(6, 6);
            this.lbHistoria.Name = "lbHistoria";
            this.lbHistoria.Size = new System.Drawing.Size(297, 160);
            this.lbHistoria.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 230);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbObrazek)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pcbObrazek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPogoda;
        private System.Windows.Forms.TextBox txtNazwaMiasta;
        private System.Windows.Forms.Label lblWynik;
        private System.Windows.Forms.ListBox lbHistoria;
    }
}

