namespace QR_Code_Generator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_color = new QR_Code_Generator.PictureButton();
            this.btn_save = new QR_Code_Generator.PictureButton();
            this.btn_text = new QR_Code_Generator.PictureButton();
            this.btn_email = new QR_Code_Generator.PictureButton();
            this.btn_web = new QR_Code_Generator.PictureButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(53)))), ((int)(((byte)(77)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(462, 303);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImage = global::QR_Code_Generator.Properties.Resources.icons8_bug_32px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(733, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 38);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pictureBox1.Location = new System.Drawing.Point(480, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Feedback";
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_color.Image_ = global::QR_Code_Generator.Properties.Resources.icons8_cursor_80px;
            this.btn_color.Location = new System.Drawing.Point(480, 316);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(102, 38);
            this.btn_color.TabIndex = 7;
            this.btn_color.Text_ = "Color";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_save.Image_ = global::QR_Code_Generator.Properties.Resources.icons8_save_80px;
            this.btn_save.Location = new System.Drawing.Point(624, 316);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(102, 38);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text_ = "Save";
            // 
            // btn_text
            // 
            this.btn_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btn_text.Image_ = global::QR_Code_Generator.Properties.Resources.icons8_text_32px;
            this.btn_text.Location = new System.Drawing.Point(12, 12);
            this.btn_text.Name = "btn_text";
            this.btn_text.Size = new System.Drawing.Size(150, 33);
            this.btn_text.TabIndex = 4;
            this.btn_text.Text_ = "Text";
            // 
            // btn_email
            // 
            this.btn_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_email.Image_ = global::QR_Code_Generator.Properties.Resources.icons8_secured_letter_50px;
            this.btn_email.Location = new System.Drawing.Point(168, 12);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(150, 33);
            this.btn_email.TabIndex = 3;
            this.btn_email.Text_ = "Email";
            // 
            // btn_web
            // 
            this.btn_web.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btn_web.Image_ = global::QR_Code_Generator.Properties.Resources.icons8_website_80px;
            this.btn_web.Location = new System.Drawing.Point(324, 12);
            this.btn_web.Name = "btn_web";
            this.btn_web.Size = new System.Drawing.Size(150, 33);
            this.btn_web.TabIndex = 2;
            this.btn_web.Text_ = "Website";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(781, 366);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_text);
            this.Controls.Add(this.btn_email);
            this.Controls.Add(this.btn_web);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "QR Code Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private PictureButton btn_web;
        private PictureButton btn_email;
        private PictureButton btn_text;
        private PictureButton btn_save;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private PictureButton btn_color;
    }
}

