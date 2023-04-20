namespace Image_Converter
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
            this.pickImage = new System.Windows.Forms.Button();
            this.convertImage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pickImage
            // 
            this.pickImage.Location = new System.Drawing.Point(111, 37);
            this.pickImage.Name = "pickImage";
            this.pickImage.Size = new System.Drawing.Size(75, 23);
            this.pickImage.TabIndex = 0;
            this.pickImage.Text = "Select";
            this.pickImage.UseVisualStyleBackColor = true;
            this.pickImage.Click += new System.EventHandler(this.pickImage_Click);
            // 
            // convertImage
            // 
            this.convertImage.Location = new System.Drawing.Point(111, 132);
            this.convertImage.Name = "convertImage";
            this.convertImage.Size = new System.Drawing.Size(75, 23);
            this.convertImage.TabIndex = 2;
            this.convertImage.Text = "Convert";
            this.convertImage.UseVisualStyleBackColor = true;
            this.convertImage.Click += new System.EventHandler(this.convertImage_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 191);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.convertImage);
            this.Controls.Add(this.pickImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pickImage;
        private System.Windows.Forms.Button convertImage;
        private System.Windows.Forms.TextBox textBox1;
    }
}

