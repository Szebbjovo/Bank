namespace Bank
{
    partial class Cim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cim));
            this.RegisterSubmit = new System.Windows.Forms.Button();
            this.VezetekNev = new System.Windows.Forms.TextBox();
            this.KeresztNev = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.passwordCHeck = new System.Windows.Forms.TextBox();
            this.Vnev = new System.Windows.Forms.Label();
            this.knev = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BirthDayPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterSubmit
            // 
            this.RegisterSubmit.Location = new System.Drawing.Point(56, 374);
            this.RegisterSubmit.Name = "RegisterSubmit";
            this.RegisterSubmit.Size = new System.Drawing.Size(75, 23);
            this.RegisterSubmit.TabIndex = 0;
            this.RegisterSubmit.Text = "Submit";
            this.RegisterSubmit.UseVisualStyleBackColor = true;
            this.RegisterSubmit.Click += new System.EventHandler(this.RegisterSubmit_Click);
            // 
            // VezetekNev
            // 
            this.VezetekNev.Location = new System.Drawing.Point(12, 75);
            this.VezetekNev.Name = "VezetekNev";
            this.VezetekNev.Size = new System.Drawing.Size(212, 20);
            this.VezetekNev.TabIndex = 1;
            this.VezetekNev.TextChanged += new System.EventHandler(this.VezetekNev_TextChanged);
            // 
            // KeresztNev
            // 
            this.KeresztNev.Location = new System.Drawing.Point(12, 140);
            this.KeresztNev.Name = "KeresztNev";
            this.KeresztNev.Size = new System.Drawing.Size(212, 20);
            this.KeresztNev.TabIndex = 2;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(12, 194);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(212, 20);
            this.passwordField.TabIndex = 3;
            // 
            // passwordCHeck
            // 
            this.passwordCHeck.Location = new System.Drawing.Point(12, 245);
            this.passwordCHeck.Name = "passwordCHeck";
            this.passwordCHeck.Size = new System.Drawing.Size(212, 20);
            this.passwordCHeck.TabIndex = 5;
            // 
            // Vnev
            // 
            this.Vnev.AutoSize = true;
            this.Vnev.Location = new System.Drawing.Point(12, 59);
            this.Vnev.Name = "Vnev";
            this.Vnev.Size = new System.Drawing.Size(60, 13);
            this.Vnev.TabIndex = 6;
            this.Vnev.Text = "First Name:";
            // 
            // knev
            // 
            this.knev.AutoSize = true;
            this.knev.Location = new System.Drawing.Point(12, 124);
            this.knev.Name = "knev";
            this.knev.Size = new System.Drawing.Size(61, 13);
            this.knev.TabIndex = 7;
            this.knev.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password again:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Registration";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BirthDayPicker
            // 
            this.BirthDayPicker.Location = new System.Drawing.Point(12, 348);
            this.BirthDayPicker.Name = "BirthDayPicker";
            this.BirthDayPicker.Size = new System.Drawing.Size(200, 20);
            this.BirthDayPicker.TabIndex = 31;
            this.BirthDayPicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Please select your birthday";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(304, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 426);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(12, 300);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID:";
            // 
            // Cim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BirthDayPicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.knev);
            this.Controls.Add(this.Vnev);
            this.Controls.Add(this.passwordCHeck);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.KeresztNev);
            this.Controls.Add(this.VezetekNev);
            this.Controls.Add(this.RegisterSubmit);
            this.Name = "Cim";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterSubmit;
        private System.Windows.Forms.TextBox VezetekNev;
        private System.Windows.Forms.TextBox KeresztNev;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox passwordCHeck;
        private System.Windows.Forms.Label Vnev;
        private System.Windows.Forms.Label knev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker BirthDayPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label2;
    }
}