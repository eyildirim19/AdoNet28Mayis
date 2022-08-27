namespace AdoNet
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
            this.btnBaglan = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(97, 57);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(136, 49);
            this.btnBaglan.TabIndex = 0;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(150, 162);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(159, 49);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 324);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnBaglan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnBaglan;
        private Button btnEkle;
    }
}