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
            this.SuspendLayout();
            // 
            // UserDatakerlekmenj
            // 
            this.UserDatakerlekmenj.AutoSize = true;
            this.UserDatakerlekmenj.Location = new System.Drawing.Point(370, 162);
            this.UserDatakerlekmenj.Name = "UserDatakerlekmenj";
            this.UserDatakerlekmenj.Size = new System.Drawing.Size(25, 13);
            this.UserDatakerlekmenj.TabIndex = 0;
            this.UserDatakerlekmenj.Text = "456";
            this.UserDatakerlekmenj.Click += new System.EventHandler(this.label1_Click);
            // 
            // ShowData
            // 
            this.ShowData.Location = new System.Drawing.Point(561, 332);
            this.ShowData.Name = "ShowData";
            this.ShowData.Size = new System.Drawing.Size(75, 23);
            this.ShowData.TabIndex = 1;
            this.ShowData.Text = "My Data";
            this.ShowData.UseVisualStyleBackColor = true;
            this.ShowData.Click += new System.EventHandler(this.ShowData_Click);
            // 
            // UserDatalabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowData);
            this.Controls.Add(this.UserDatakerlekmenj);
            this.Name = "UserDatalabel";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserDatakerlekmenj;
        private System.Windows.Forms.Button ShowData;
    }
}