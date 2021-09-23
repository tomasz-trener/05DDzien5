
namespace P01AplikacjaOkienkowaWstep
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
            this.btnPowitanie = new System.Windows.Forms.Button();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPowitanie
            // 
            this.btnPowitanie.Location = new System.Drawing.Point(194, 21);
            this.btnPowitanie.Name = "btnPowitanie";
            this.btnPowitanie.Size = new System.Drawing.Size(144, 97);
            this.btnPowitanie.TabIndex = 0;
            this.btnPowitanie.Text = "Uruchom mnie";
            this.btnPowitanie.UseVisualStyleBackColor = true;
            this.btnPowitanie.Click += new System.EventHandler(this.btnPowitanie_Click);
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(194, 142);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(144, 20);
            this.txtImie.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.btnPowitanie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPowitanie;
        private System.Windows.Forms.TextBox txtImie;
    }
}

