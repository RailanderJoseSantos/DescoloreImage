namespace AulaPraticaCG_01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_catioro = new System.Windows.Forms.PictureBox();
            this.pictureBox_catioro2 = new System.Windows.Forms.PictureBox();
            this.button_Converter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_catioro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_catioro2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_catioro
            // 
            this.pictureBox_catioro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_catioro.BackgroundImage")));
            this.pictureBox_catioro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_catioro.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_catioro.Name = "pictureBox_catioro";
            this.pictureBox_catioro.Size = new System.Drawing.Size(388, 453);
            this.pictureBox_catioro.TabIndex = 0;
            this.pictureBox_catioro.TabStop = false;
            this.pictureBox_catioro.Click += new System.EventHandler(this.pictureBox_catioro_Click);
            // 
            // pictureBox_catioro2
            // 
            this.pictureBox_catioro2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_catioro2.Location = new System.Drawing.Point(422, 12);
            this.pictureBox_catioro2.Name = "pictureBox_catioro2";
            this.pictureBox_catioro2.Size = new System.Drawing.Size(300, 453);
            this.pictureBox_catioro2.TabIndex = 1;
            this.pictureBox_catioro2.TabStop = false;
            // 
            // button_Converter
            // 
            this.button_Converter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Converter.BackColor = System.Drawing.Color.Black;
            this.button_Converter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Converter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Converter.ForeColor = System.Drawing.Color.White;
            this.button_Converter.Location = new System.Drawing.Point(90, 480);
            this.button_Converter.Name = "button_Converter";
            this.button_Converter.Size = new System.Drawing.Size(166, 48);
            this.button_Converter.TabIndex = 2;
            this.button_Converter.Text = "Converter";
            this.button_Converter.UseVisualStyleBackColor = false;
            this.button_Converter.Click += new System.EventHandler(this.button_Converter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(902, 540);
            this.Controls.Add(this.button_Converter);
            this.Controls.Add(this.pictureBox_catioro2);
            this.Controls.Add(this.pictureBox_catioro);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_catioro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_catioro2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_catioro;
        private System.Windows.Forms.PictureBox pictureBox_catioro2;
        private System.Windows.Forms.Button button_Converter;
    }
}

