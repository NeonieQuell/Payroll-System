
namespace PayrollSystem
{
    partial class FormGeneratePayroll
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.dataGridViewEmp = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxEmpID = new System.Windows.Forms.TextBox();
            this.labelEmpID = new System.Windows.Forms.Label();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.labelDept = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.textBoxRatePerDay = new System.Windows.Forms.TextBox();
            this.labelRatePerDay = new System.Windows.Forms.Label();
            this.textBoxHoursWork = new System.Windows.Forms.TextBox();
            this.labelWorkDays = new System.Windows.Forms.Label();
            this.textBoxGrossMonthlyIncome = new System.Windows.Forms.TextBox();
            this.textBoxSSS = new System.Windows.Forms.TextBox();
            this.labelGrossMonthlyIncome = new System.Windows.Forms.Label();
            this.labelSSS = new System.Windows.Forms.Label();
            this.textBoxTax = new System.Windows.Forms.TextBox();
            this.labelTax = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxNumOTHours = new System.Windows.Forms.TextBox();
            this.labelNumOTHours = new System.Windows.Forms.Label();
            this.labelNetIncome = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelListEmp = new System.Windows.Forms.Label();
            this.buttonCalcNetIncome = new PayrollSystem.Custom_Controls.CustomButton();
            this.buttonBack = new PayrollSystem.Custom_Controls.CustomButton();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(193)))));
            this.panel.Controls.Add(this.labelHeader);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1382, 70);
            this.panel.TabIndex = 0;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(574, 19);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(250, 33);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Generate Payroll";
            // 
            // dataGridViewEmp
            // 
            this.dataGridViewEmp.AllowUserToAddRows = false;
            this.dataGridViewEmp.AllowUserToDeleteRows = false;
            this.dataGridViewEmp.AllowUserToResizeColumns = false;
            this.dataGridViewEmp.AllowUserToResizeRows = false;
            this.dataGridViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmp.Location = new System.Drawing.Point(434, 120);
            this.dataGridViewEmp.Name = "dataGridViewEmp";
            this.dataGridViewEmp.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmp.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmp.Size = new System.Drawing.Size(926, 656);
            this.dataGridViewEmp.TabIndex = 7;
            this.dataGridViewEmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmp_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBoxEmpID);
            this.groupBox1.Controls.Add(this.labelEmpID);
            this.groupBox1.Controls.Add(this.textBoxDepartment);
            this.groupBox1.Controls.Add(this.textBoxLName);
            this.groupBox1.Controls.Add(this.textBoxFName);
            this.groupBox1.Controls.Add(this.labelLName);
            this.groupBox1.Controls.Add(this.labelFName);
            this.groupBox1.Controls.Add(this.textBoxPosition);
            this.groupBox1.Controls.Add(this.labelDept);
            this.groupBox1.Controls.Add(this.labelPosition);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 208);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primary Information";
            // 
            // textBoxEmpID
            // 
            this.textBoxEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmpID.Location = new System.Drawing.Point(25, 50);
            this.textBoxEmpID.Name = "textBoxEmpID";
            this.textBoxEmpID.ReadOnly = true;
            this.textBoxEmpID.Size = new System.Drawing.Size(341, 22);
            this.textBoxEmpID.TabIndex = 1;
            // 
            // labelEmpID
            // 
            this.labelEmpID.AutoSize = true;
            this.labelEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpID.Location = new System.Drawing.Point(22, 31);
            this.labelEmpID.Name = "labelEmpID";
            this.labelEmpID.Size = new System.Drawing.Size(86, 16);
            this.labelEmpID.TabIndex = 0;
            this.labelEmpID.Text = "Employee ID";
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDepartment.Location = new System.Drawing.Point(25, 158);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.ReadOnly = true;
            this.textBoxDepartment.Size = new System.Drawing.Size(157, 22);
            this.textBoxDepartment.TabIndex = 7;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLName.Location = new System.Drawing.Point(209, 104);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.ReadOnly = true;
            this.textBoxLName.Size = new System.Drawing.Size(157, 22);
            this.textBoxLName.TabIndex = 5;
            // 
            // textBoxFName
            // 
            this.textBoxFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFName.Location = new System.Drawing.Point(25, 104);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.ReadOnly = true;
            this.textBoxFName.Size = new System.Drawing.Size(157, 22);
            this.textBoxFName.TabIndex = 3;
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLName.Location = new System.Drawing.Point(206, 85);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(73, 16);
            this.labelLName.TabIndex = 4;
            this.labelLName.Text = "Last Name";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFName.Location = new System.Drawing.Point(22, 85);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(73, 16);
            this.labelFName.TabIndex = 2;
            this.labelFName.Text = "First Name";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPosition.Location = new System.Drawing.Point(209, 158);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.ReadOnly = true;
            this.textBoxPosition.Size = new System.Drawing.Size(157, 22);
            this.textBoxPosition.TabIndex = 9;
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDept.Location = new System.Drawing.Point(22, 139);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(78, 16);
            this.labelDept.TabIndex = 6;
            this.labelDept.Text = "Department";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(209, 139);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(56, 16);
            this.labelPosition.TabIndex = 8;
            this.labelPosition.Text = "Position";
            // 
            // textBoxRatePerDay
            // 
            this.textBoxRatePerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRatePerDay.Location = new System.Drawing.Point(209, 50);
            this.textBoxRatePerDay.Name = "textBoxRatePerDay";
            this.textBoxRatePerDay.ReadOnly = true;
            this.textBoxRatePerDay.Size = new System.Drawing.Size(157, 22);
            this.textBoxRatePerDay.TabIndex = 3;
            // 
            // labelRatePerDay
            // 
            this.labelRatePerDay.AutoSize = true;
            this.labelRatePerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRatePerDay.Location = new System.Drawing.Point(206, 31);
            this.labelRatePerDay.Name = "labelRatePerDay";
            this.labelRatePerDay.Size = new System.Drawing.Size(89, 16);
            this.labelRatePerDay.TabIndex = 2;
            this.labelRatePerDay.Text = "Rate Per Day";
            // 
            // textBoxHoursWork
            // 
            this.textBoxHoursWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHoursWork.Location = new System.Drawing.Point(25, 50);
            this.textBoxHoursWork.Name = "textBoxHoursWork";
            this.textBoxHoursWork.ReadOnly = true;
            this.textBoxHoursWork.Size = new System.Drawing.Size(157, 22);
            this.textBoxHoursWork.TabIndex = 1;
            // 
            // labelWorkDays
            // 
            this.labelWorkDays.AutoSize = true;
            this.labelWorkDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkDays.Location = new System.Drawing.Point(22, 31);
            this.labelWorkDays.Name = "labelWorkDays";
            this.labelWorkDays.Size = new System.Drawing.Size(123, 16);
            this.labelWorkDays.TabIndex = 0;
            this.labelWorkDays.Text = "Num. of Work Days";
            // 
            // textBoxGrossMonthlyIncome
            // 
            this.textBoxGrossMonthlyIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGrossMonthlyIncome.Location = new System.Drawing.Point(25, 104);
            this.textBoxGrossMonthlyIncome.Name = "textBoxGrossMonthlyIncome";
            this.textBoxGrossMonthlyIncome.ReadOnly = true;
            this.textBoxGrossMonthlyIncome.Size = new System.Drawing.Size(341, 22);
            this.textBoxGrossMonthlyIncome.TabIndex = 5;
            // 
            // textBoxSSS
            // 
            this.textBoxSSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSSS.Location = new System.Drawing.Point(209, 158);
            this.textBoxSSS.Name = "textBoxSSS";
            this.textBoxSSS.Size = new System.Drawing.Size(157, 22);
            this.textBoxSSS.TabIndex = 9;
            // 
            // labelGrossMonthlyIncome
            // 
            this.labelGrossMonthlyIncome.AutoSize = true;
            this.labelGrossMonthlyIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrossMonthlyIncome.Location = new System.Drawing.Point(22, 85);
            this.labelGrossMonthlyIncome.Name = "labelGrossMonthlyIncome";
            this.labelGrossMonthlyIncome.Size = new System.Drawing.Size(133, 16);
            this.labelGrossMonthlyIncome.TabIndex = 4;
            this.labelGrossMonthlyIncome.Text = "Gross Montly Income";
            // 
            // labelSSS
            // 
            this.labelSSS.AutoSize = true;
            this.labelSSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSSS.Location = new System.Drawing.Point(206, 139);
            this.labelSSS.Name = "labelSSS";
            this.labelSSS.Size = new System.Drawing.Size(35, 16);
            this.labelSSS.TabIndex = 8;
            this.labelSSS.Text = "SSS";
            // 
            // textBoxTax
            // 
            this.textBoxTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTax.Location = new System.Drawing.Point(25, 158);
            this.textBoxTax.Name = "textBoxTax";
            this.textBoxTax.Size = new System.Drawing.Size(157, 22);
            this.textBoxTax.TabIndex = 7;
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTax.Location = new System.Drawing.Point(22, 139);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(31, 16);
            this.labelTax.TabIndex = 6;
            this.labelTax.Text = "Tax";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.textBoxNumOTHours);
            this.groupBox2.Controls.Add(this.labelNumOTHours);
            this.groupBox2.Controls.Add(this.textBoxGrossMonthlyIncome);
            this.groupBox2.Controls.Add(this.labelSSS);
            this.groupBox2.Controls.Add(this.labelGrossMonthlyIncome);
            this.groupBox2.Controls.Add(this.labelWorkDays);
            this.groupBox2.Controls.Add(this.textBoxRatePerDay);
            this.groupBox2.Controls.Add(this.textBoxHoursWork);
            this.groupBox2.Controls.Add(this.labelRatePerDay);
            this.groupBox2.Controls.Add(this.textBoxSSS);
            this.groupBox2.Controls.Add(this.textBoxTax);
            this.groupBox2.Controls.Add(this.labelTax);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 265);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salary Information";
            // 
            // textBoxNumOTHours
            // 
            this.textBoxNumOTHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumOTHours.Location = new System.Drawing.Point(108, 217);
            this.textBoxNumOTHours.Name = "textBoxNumOTHours";
            this.textBoxNumOTHours.Size = new System.Drawing.Size(157, 22);
            this.textBoxNumOTHours.TabIndex = 11;
            // 
            // labelNumOTHours
            // 
            this.labelNumOTHours.AutoSize = true;
            this.labelNumOTHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumOTHours.Location = new System.Drawing.Point(105, 198);
            this.labelNumOTHours.Name = "labelNumOTHours";
            this.labelNumOTHours.Size = new System.Drawing.Size(149, 16);
            this.labelNumOTHours.TabIndex = 10;
            this.labelNumOTHours.Text = "Num. of Overtime Hours";
            // 
            // labelNetIncome
            // 
            this.labelNetIncome.AutoSize = true;
            this.labelNetIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNetIncome.Location = new System.Drawing.Point(18, 36);
            this.labelNetIncome.Name = "labelNetIncome";
            this.labelNetIncome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNetIncome.Size = new System.Drawing.Size(56, 37);
            this.labelNetIncome.TabIndex = 0;
            this.labelNetIncome.Text = "₱0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelNetIncome);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(24, 615);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 95);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Net Income";
            // 
            // labelListEmp
            // 
            this.labelListEmp.AutoSize = true;
            this.labelListEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListEmp.ForeColor = System.Drawing.Color.Black;
            this.labelListEmp.Location = new System.Drawing.Point(784, 88);
            this.labelListEmp.Name = "labelListEmp";
            this.labelListEmp.Size = new System.Drawing.Size(220, 29);
            this.labelListEmp.TabIndex = 6;
            this.labelListEmp.Text = "List of Employees";
            // 
            // buttonCalcNetIncome
            // 
            this.buttonCalcNetIncome.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonCalcNetIncome.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonCalcNetIncome.BorderColor = System.Drawing.Color.Transparent;
            this.buttonCalcNetIncome.BorderRadius = 40;
            this.buttonCalcNetIncome.BorderSize = 0;
            this.buttonCalcNetIncome.Enabled = false;
            this.buttonCalcNetIncome.FlatAppearance.BorderSize = 0;
            this.buttonCalcNetIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalcNetIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcNetIncome.FontColor = System.Drawing.Color.White;
            this.buttonCalcNetIncome.ForeColor = System.Drawing.Color.White;
            this.buttonCalcNetIncome.Location = new System.Drawing.Point(247, 736);
            this.buttonCalcNetIncome.Name = "buttonCalcNetIncome";
            this.buttonCalcNetIncome.Size = new System.Drawing.Size(181, 40);
            this.buttonCalcNetIncome.TabIndex = 4;
            this.buttonCalcNetIncome.Text = "Calculate Net Income";
            this.buttonCalcNetIncome.UseVisualStyleBackColor = false;
            this.buttonCalcNetIncome.Click += new System.EventHandler(this.buttonCalcNetIncome_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.LightCoral;
            this.buttonBack.BackgroundColor = System.Drawing.Color.LightCoral;
            this.buttonBack.BorderColor = System.Drawing.Color.Transparent;
            this.buttonBack.BorderRadius = 40;
            this.buttonBack.BorderSize = 0;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.FontColor = System.Drawing.Color.White;
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(153, 736);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(88, 40);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormGeneratePayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1382, 791);
            this.Controls.Add(this.labelListEmp);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonCalcNetIncome);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewEmp);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.buttonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormGeneratePayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neosoft";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGeneratePayroll_FormClosing);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom_Controls.CustomButton buttonBack;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.DataGridView dataGridViewEmp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxRatePerDay;
        private System.Windows.Forms.Label labelRatePerDay;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox textBoxHoursWork;
        private System.Windows.Forms.Label labelWorkDays;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.TextBox textBoxGrossMonthlyIncome;
        private System.Windows.Forms.TextBox textBoxSSS;
        private System.Windows.Forms.Label labelGrossMonthlyIncome;
        private System.Windows.Forms.Label labelSSS;
        private System.Windows.Forms.TextBox textBoxTax;
        private System.Windows.Forms.Label labelTax;
        private Custom_Controls.CustomButton buttonCalcNetIncome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelNetIncome;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.TextBox textBoxEmpID;
        private System.Windows.Forms.Label labelEmpID;
        private System.Windows.Forms.Label labelListEmp;
        private System.Windows.Forms.TextBox textBoxNumOTHours;
        private System.Windows.Forms.Label labelNumOTHours;
    }
}