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
            this.UserDatakerlekmenj = new System.Windows.Forms.Label();
            this.ShowData = new System.Windows.Forms.Button();
            this.AddMonnnny = new System.Windows.Forms.Button();
            this.MonneytakeOut = new System.Windows.Forms.Button();
            this.monniadas = new System.Windows.Forms.NumericUpDown();
            this.monnikivetel = new System.Windows.Forms.NumericUpDown();
            this.confirmAddation = new System.Windows.Forms.Button();
            this.takeaOutconfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.monniadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monnikivetel)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDatakerlekmenj
            // 
            this.UserDatakerlekmenj.AutoSize = true;
            this.UserDatakerlekmenj.Location = new System.Drawing.Point(12, 9);
            this.UserDatakerlekmenj.Name = "UserDatakerlekmenj";
            this.UserDatakerlekmenj.Size = new System.Drawing.Size(149, 13);
            this.UserDatakerlekmenj.TabIndex = 0;
            this.UserDatakerlekmenj.Text = "Udvozoljuk ujra kedves ugyfel";
            this.UserDatakerlekmenj.Click += new System.EventHandler(this.label1_Click);
            // 
            // ShowData
            // 
            this.ShowData.Location = new System.Drawing.Point(375, 12);
            this.ShowData.Name = "ShowData";
            this.ShowData.Size = new System.Drawing.Size(122, 23);
            this.ShowData.TabIndex = 1;
            this.ShowData.Text = "Show My datas";
            this.ShowData.UseVisualStyleBackColor = true;
            this.ShowData.Click += new System.EventHandler(this.ShowData_Click);
            // 
            // AddMonnnny
            // 
            this.AddMonnnny.Location = new System.Drawing.Point(375, 68);
            this.AddMonnnny.Name = "AddMonnnny";
            this.AddMonnnny.Size = new System.Drawing.Size(122, 23);
            this.AddMonnnny.TabIndex = 2;
            this.AddMonnnny.Text = "Add monnye$$$";
            this.AddMonnnny.UseVisualStyleBackColor = true;
            this.AddMonnnny.Click += new System.EventHandler(this.AddMonnnny_Click);
            // 
            // MonneytakeOut
            // 
            this.MonneytakeOut.Location = new System.Drawing.Point(375, 119);
            this.MonneytakeOut.Name = "MonneytakeOut";
            this.MonneytakeOut.Size = new System.Drawing.Size(122, 23);
            this.MonneytakeOut.TabIndex = 3;
            this.MonneytakeOut.Text = "Take out monney";
            this.MonneytakeOut.UseVisualStyleBackColor = true;
            this.MonneytakeOut.Click += new System.EventHandler(this.MonneytakeOut_Click);
            // 
            // monniadas
            // 
            this.monniadas.Location = new System.Drawing.Point(516, 71);
            this.monniadas.Name = "monniadas";
            this.monniadas.Size = new System.Drawing.Size(95, 20);
            this.monniadas.TabIndex = 4;
            this.monniadas.Visible = false;
            // 
            // monnikivetel
            // 
            this.monnikivetel.Location = new System.Drawing.Point(516, 122);
            this.monnikivetel.Name = "monnikivetel";
            this.monnikivetel.Size = new System.Drawing.Size(95, 20);
            this.monnikivetel.TabIndex = 5;
            this.monnikivetel.Visible = false;
            // 
            // confirmAddation
            // 
            this.confirmAddation.Location = new System.Drawing.Point(627, 71);
            this.confirmAddation.Name = "confirmAddation";
            this.confirmAddation.Size = new System.Drawing.Size(39, 23);
            this.confirmAddation.TabIndex = 6;
            this.confirmAddation.Text = "Add";
            this.confirmAddation.UseVisualStyleBackColor = true;
            this.confirmAddation.Visible = false;
            // 
            // takeaOutconfirm
            // 
            this.takeaOutconfirm.Location = new System.Drawing.Point(627, 117);
            this.takeaOutconfirm.Name = "takeaOutconfirm";
            this.takeaOutconfirm.Size = new System.Drawing.Size(39, 25);
            this.takeaOutconfirm.TabIndex = 7;
            this.takeaOutconfirm.Text = "Get";
            this.takeaOutconfirm.UseVisualStyleBackColor = true;
            this.takeaOutconfirm.Visible = false;
            // 
            // UserDatalabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}