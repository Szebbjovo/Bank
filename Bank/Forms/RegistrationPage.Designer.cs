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
            this.BirthDayPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernamming = new System.Windows.Forms.TextBox();
            this.UsernaME = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterSubmit
            // 
            this.RegisterSubmit.Location = new System.Drawing.Point(51, 464);
            this.RegisterSubmit.Name = "RegisterSubmit";
            this.RegisterSubmit.Size = new System.Drawing.Size(75, 23);
            this.RegisterSubmit.TabIndex = 0;
            this.RegisterSubmit.Text = "Submit";
            this.RegisterSubmit.UseVisualStyleBackColor = true;
            this.RegisterSubmit.Click += new System.EventHandler(this.RegisterSubmit_Click);
            // 
            // VezetekNev
            // 
            this.VezetekNev.Location = new System.Drawing.Point(8, 121);
            this.VezetekNev.Name = "VezetekNev";
            this.VezetekNev.Size = new System.Drawing.Size(212, 20);
            this.VezetekNev.TabIndex = 1;
            this.VezetekNev.TextChanged += new System.EventHandler(this.VezetekNev_TextChanged);
            // 
            // KeresztNev
            // 
            this.KeresztNev.Location = new System.Drawing.Point(8, 184);
            this.KeresztNev.Name = "KeresztNev";
            this.KeresztNev.Size = new System.Drawing.Size(243, 20);
            this.KeresztNev.TabIndex = 2;
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(8, 284);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(243, 20);
            this.passwordField.TabIndex = 3;
            // 
            // passwordCHeck
            // 
            this.passwordCHeck.Location = new System.Drawing.Point(8, 333);
            this.passwordCHeck.Name = "passwordCHeck";
            this.passwordCHeck.Size = new System.Drawing.Size(243, 20);
            this.passwordCHeck.TabIndex = 5;
            // 
            // Vnev
            // 
            this.Vnev.AutoSize = true;
            this.Vnev.Location = new System.Drawing.Point(5, 105);
            this.Vnev.Name = "Vnev";
            this.Vnev.Size = new System.Drawing.Size(60, 13);
            this.Vnev.TabIndex = 6;
            this.Vnev.Text = "First Name:";
            // 
            // knev
            // 
            this.knev.AutoSize = true;
            this.knev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.knev.Location = new System.Drawing.Point(4, 161);
            this.knev.Name = "knev";
            this.knev.Size = new System.Drawing.Size(100, 20);
            this.knev.TabIndex = 7;
            this.knev.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(4, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(4, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password again:";
            // 
            // BirthDayPicker
            // 
            this.BirthDayPicker.Location = new System.Drawing.Point(8, 438);
            this.BirthDayPicker.Name = "BirthDayPicker";
            this.BirthDayPicker.Size = new System.Drawing.Size(243, 20);
            this.BirthDayPicker.TabIndex = 31;
            this.BirthDayPicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Please select your birthday";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(435, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(587, 481);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(8, 385);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(243, 20);
            this.ID.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "ID:";
            // 
            // usernamming
            // 
            this.usernamming.Location = new System.Drawing.Point(8, 232);
            this.usernamming.Name = "usernamming";
            this.usernamming.Size = new System.Drawing.Size(243, 20);
            this.usernamming.TabIndex = 36;
            // 
            // UsernaME
            // 
            this.UsernaME.AutoSize = true;
            this.UsernaME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.UsernaME.Location = new System.Drawing.Point(4, 209);
            this.UsernaME.Name = "UsernaME";
            this.UsernaME.Size = new System.Drawing.Size(96, 20);
            this.UsernaME.TabIndex = 37;
            this.UsernaME.Text = "Username:";
            this.UsernaME.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1047, 140);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // Cim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1020, 499);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.UsernaME);
            this.Controls.Add(this.usernamming);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BirthDayPicker);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.DateTimePicker BirthDayPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernamming;
        private System.Windows.Forms.Label UsernaME;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}