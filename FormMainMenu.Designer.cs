
namespace PayrollSystem
{
    partial class FormMainMenu
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
            this.panel = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonLogOut = new PayrollSystem.Custom_Controls.CustomButton();
            this.buttonGeneratePay = new PayrollSystem.Custom_Controls.CustomButton();
            this.buttonAdminInfo = new PayrollSystem.Custom_Controls.CustomButton();
            this.buttonAddEmp = new PayrollSystem.Custom_Controls.CustomButton();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(193)))));
            this.panel.Controls.Add(this.labelHeader);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(482, 70);
            this.panel.TabIndex = 0;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(120, 19);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(241, 33);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Welcome Admin";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.Color.LightCoral;
            this.buttonLogOut.BackgroundColor = System.Drawing.Color.LightCoral;
            this.buttonLogOut.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonLogOut.BorderRadius = 10;
            this.buttonLogOut.BorderSize = 0;
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogOut.FontColor = System.Drawing.Color.White;
            this.buttonLogOut.ForeColor = System.Drawing.Color.White;
            this.buttonLogOut.Location = new System.Drawing.Point(319, 212);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(140, 100);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonGeneratePay
            // 
            this.buttonGeneratePay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.buttonGeneratePay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.buttonGeneratePay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonGeneratePay.BorderRadius = 10;
            this.buttonGeneratePay.BorderSize = 0;
            this.buttonGeneratePay.FlatAppearance.BorderSize = 0;
            this.buttonGeneratePay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGeneratePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGeneratePay.FontColor = System.Drawing.Color.White;
            this.buttonGeneratePay.ForeColor = System.Drawing.Color.White;
            this.buttonGeneratePay.Location = new System.Drawing.Point(23, 98);
            this.buttonGeneratePay.Name = "buttonGeneratePay";
            this.buttonGeneratePay.Size = new System.Drawing.Size(436, 100);
            this.buttonGeneratePay.TabIndex = 1;
            this.buttonGeneratePay.Text = "Generate Payroll";
            this.buttonGeneratePay.UseVisualStyleBackColor = false;
            this.buttonGeneratePay.Click += new System.EventHandler(this.buttonGeneratePay_Click);
            // 
            // buttonAdminInfo
            // 
            this.buttonAdminInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.buttonAdminInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.buttonAdminInfo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonAdminInfo.BorderRadius = 10;
            this.buttonAdminInfo.BorderSize = 0;
            this.buttonAdminInfo.FlatAppearance.BorderSize = 0;
            this.buttonAdminInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdminInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdminInfo.FontColor = System.Drawing.Color.White;
            this.buttonAdminInfo.ForeColor = System.Drawing.Color.White;
            this.buttonAdminInfo.Location = new System.Drawing.Point(171, 212);
            this.buttonAdminInfo.Name = "buttonAdminInfo";
            this.buttonAdminInfo.Size = new System.Drawing.Size(140, 100);
            this.buttonAdminInfo.TabIndex = 3;
            this.buttonAdminInfo.Text = "View\r\nAdmin Info";
            this.buttonAdminInfo.UseVisualStyleBackColor = false;
            this.buttonAdminInfo.Click += new System.EventHandler(this.buttonAdminInfo_Click);
            // 
            // buttonAddEmp
            // 
            this.buttonAddEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.buttonAddEmp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.buttonAddEmp.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonAddEmp.BorderRadius = 10;
            this.buttonAddEmp.BorderSize = 0;
            this.buttonAddEmp.FlatAppearance.BorderSize = 0;
            this.buttonAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddEmp.FontColor = System.Drawing.Color.White;
            this.buttonAddEmp.ForeColor = System.Drawing.Color.White;
            this.buttonAddEmp.Location = new System.Drawing.Point(23, 212);
            this.buttonAddEmp.Name = "buttonAddEmp";
            this.buttonAddEmp.Size = new System.Drawing.Size(140, 100);
            this.buttonAddEmp.TabIndex = 2;
            this.buttonAddEmp.Text = "Add\r\nEmployee";
            this.buttonAddEmp.UseVisualStyleBackColor = false;
            this.buttonAddEmp.Click += new System.EventHandler(this.buttonAddEmp_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 344);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonGeneratePay);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.buttonAdminInfo);
            this.Controls.Add(this.buttonAddEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neosoft";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainMenu_FormClosing);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_Controls.CustomButton buttonAddEmp;
        private Custom_Controls.CustomButton buttonAdminInfo;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelHeader;
        private Custom_Controls.CustomButton buttonGeneratePay;
        private Custom_Controls.CustomButton buttonLogOut;
    }
}