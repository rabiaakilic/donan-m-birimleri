namespace DONANIM_BİRİMLERİ
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnKonturolet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "mouse",
            "yazcı",
            "klavye",
            "hoparlör",
            "kamera",
            "tarayıcı",
            "projeksiyon"});
            this.listBox1.Location = new System.Drawing.Point(50, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(161, 121);
            this.listBox1.TabIndex = 0;
            // 
            // btnKonturolet
            // 
            this.btnKonturolet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKonturolet.Location = new System.Drawing.Point(50, 170);
            this.btnKonturolet.Name = "btnKonturolet";
            this.btnKonturolet.Size = new System.Drawing.Size(161, 48);
            this.btnKonturolet.TabIndex = 1;
            this.btnKonturolet.Text = "KONTUROL ET";
            this.btnKonturolet.UseVisualStyleBackColor = true;
            this.btnKonturolet.Click += new System.EventHandler(this.btnKonturolet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 280);
            this.Controls.Add(this.btnKonturolet);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnKonturolet;
    }
}

