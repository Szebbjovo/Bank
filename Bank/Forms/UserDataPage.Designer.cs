namespace Bank.Forms
{
    partial class UserDatalabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDatalabel));
            this.UserDatakerlekmenj = new System.Windows.Forms.Label();
            this.ShowData = new System.Windows.Forms.Button();
            this.AddMonnnny = new System.Windows.Forms.Button();
            this.MonneytakeOut = new System.Windows.Forms.Button();
            this.monniadas = new System.Windows.Forms.NumericUpDown();
            this.monnikivetel = new System.Windows.Forms.NumericUpDown();
            this.confirmAddation = new System.Windows.Forms.Button();
            this.takeaOutconfirm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.monniadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monnikivetel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDatakerlekmenj
            // 
            this.UserDatakerlekmenj.AutoSize = true;
            this.UserDatakerlekmenj.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDatakerlekmenj.Location = new System.Drawing.Point(307, 165);
            this.UserDatakerlekmenj.Name = "UserDatakerlekmenj";
            this.UserDatakerlekmenj.Size = new System.Drawing.Size(177, 32);
            this.UserDatakerlekmenj.TabIndex = 0;
            this.UserDatakerlekmenj.Text = "Üdvözöljük";
            this.UserDatakerlekmenj.Click += new System.EventHandler(this.label1_Click);
            // 
            // ShowData
            // 
            this.ShowData.Location = new System.Drawing.Point(12, 165);
            this.ShowData.Name = "ShowData";
            this.ShowData.Size = new System.Drawing.Size(122, 23);
            this.ShowData.TabIndex = 1;
            this.ShowData.Text = "Show My datas";
            this.ShowData.UseVisualStyleBackColor = true;
            this.ShowData.Click += new System.EventHandler(this.ShowData_Click);
            // 
            // AddMonnnny
            // 
            this.AddMonnnny.Location = new System.Drawing.Point(12, 214);
            this.AddMonnnny.Name = "AddMonnnny";
            this.AddMonnnny.Size = new System.Drawing.Size(122, 23);
            this.AddMonnnny.TabIndex = 2;
            this.AddMonnnny.Text = "Add monnye$$$";
            this.AddMonnnny.UseVisualStyleBackColor = true;
            this.AddMonnnny.Click += new System.EventHandler(this.AddMonnnny_Click);
            // 
            // MonneytakeOut
            // 
            this.MonneytakeOut.Location = new System.Drawing.Point(12, 263);
            this.MonneytakeOut.Name = "MonneytakeOut";
            this.MonneytakeOut.Size = new System.Drawing.Size(122, 23);
            this.MonneytakeOut.TabIndex = 3;
            this.MonneytakeOut.Text = "Take out monney";
            this.MonneytakeOut.UseVisualStyleBackColor = true;
            this.MonneytakeOut.Click += new System.EventHandler(this.MonneytakeOut_Click);
            // 
            // monniadas
            // 
            this.monniadas.Location = new System.Drawing.Point(140, 217);
            this.monniadas.Name = "monniadas";
            this.monniadas.Size = new System.Drawing.Size(95, 20);
            this.monniadas.TabIndex = 4;
            this.monniadas.Visible = false;
            // 
            // monnikivetel
            // 
            this.monnikivetel.Location = new System.Drawing.Point(140, 266);
            this.monnikivetel.Name = "monnikivetel";
            this.monnikivetel.Size = new System.Drawing.Size(95, 20);
            this.monnikivetel.TabIndex = 5;
            this.monnikivetel.Visible = false;
            // 
            // confirmAddation
            // 
            this.confirmAddation.Location = new System.Drawing.Point(241, 217);
            this.confirmAddation.Name = "confirmAddation";
            this.confirmAddation.Size = new System.Drawing.Size(39, 23);
            this.confirmAddation.TabIndex = 6;
            this.confirmAddation.Text = "Add";
            this.confirmAddation.UseVisualStyleBackColor = true;
            this.confirmAddation.Visible = false;
            this.confirmAddation.Click += new System.EventHandler(this.confirmAddation_Click);
            // 
            // takeaOutconfirm
            // 
            this.takeaOutconfirm.Location = new System.Drawing.Point(241, 266);
            this.takeaOutconfirm.Name = "takeaOutconfirm";
            this.takeaOutconfirm.Size = new System.Drawing.Size(39, 25);
            this.takeaOutconfirm.TabIndex = 7;
            this.takeaOutconfirm.Text = "Get";
            this.takeaOutconfirm.UseVisualStyleBackColor = true;
            this.takeaOutconfirm.Visible = false;
            this.takeaOutconfirm.Click += new System.EventHandler(this.takeaOutconfirm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1031, 140);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // UserDatalabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1028, 639);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.takeaOutconfirm);
            this.Controls.Add(this.confirmAddation);
            this.Controls.Add(this.monnikivetel);
            this.Controls.Add(this.monniadas);
            this.Controls.Add(this.MonneytakeOut);
            this.Controls.Add(this.AddMonnnny);
            this.Controls.Add(this.ShowData);
            this.Controls.Add(this.UserDatakerlekmenj);
            this.Name = "UserDatalabel";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.monniadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monnikivetel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserDatakerlekmenj;
        private System.Windows.Forms.Button ShowData;
        private System.Windows.Forms.Button AddMonnnny;
        private System.Windows.Forms.Button MonneytakeOut;
        private System.Windows.Forms.NumericUpDown monniadas;
        private System.Windows.Forms.NumericUpDown monnikivetel;
        private System.Windows.Forms.Button confirmAddation;
        private System.Windows.Forms.Button takeaOutconfirm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}