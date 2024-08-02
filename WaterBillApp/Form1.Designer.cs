namespace WaterBillApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private System.Windows.Forms.TableLayoutPanel tblCustomerInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblLastMonth;
        private System.Windows.Forms.TextBox txtLastMonth;
        private System.Windows.Forms.Label lblThisMonth;
        private System.Windows.Forms.TextBox txtThisMonth;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.ComboBox cmbCustomerType;
        private System.Windows.Forms.Label lblNumberPeople;
        private System.Windows.Forms.TextBox txtNumberPeople;
        private System.Windows.Forms.Button btnCalculateBill;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.ListBox lstCustomers;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.tblCustomerInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblLastMonth = new System.Windows.Forms.Label();
            this.txtLastMonth = new System.Windows.Forms.TextBox();
            this.lblThisMonth = new System.Windows.Forms.Label();
            this.txtThisMonth = new System.Windows.Forms.TextBox();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.cmbCustomerType = new System.Windows.Forms.ComboBox();
            this.lblNumberPeople = new System.Windows.Forms.Label();
            this.txtNumberPeople = new System.Windows.Forms.TextBox();
            this.btnCalculateBill = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.grpCustomerInfo.SuspendLayout();
            this.tblCustomerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(111, 456);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(83, 23);
            this.btnEditCustomer.TabIndex = 6;
            this.btnEditCustomer.Text = "Edit";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Controls.Add(this.tblCustomerInfo);
            this.grpCustomerInfo.Location = new System.Drawing.Point(12, 12);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new System.Drawing.Size(360, 200);
            this.grpCustomerInfo.TabIndex = 0;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Customer Information";
            // 
            // tblCustomerInfo
            // 
            this.tblCustomerInfo.ColumnCount = 2;
            this.tblCustomerInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblCustomerInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblCustomerInfo.Controls.Add(this.lblName, 0, 0);
            this.tblCustomerInfo.Controls.Add(this.txtName, 1, 0);
            this.tblCustomerInfo.Controls.Add(this.lblLastMonth, 0, 1);
            this.tblCustomerInfo.Controls.Add(this.txtLastMonth, 1, 1);
            this.tblCustomerInfo.Controls.Add(this.lblThisMonth, 0, 2);
            this.tblCustomerInfo.Controls.Add(this.txtThisMonth, 1, 2);
            this.tblCustomerInfo.Controls.Add(this.lblCustomerType, 0, 3);
            this.tblCustomerInfo.Controls.Add(this.cmbCustomerType, 1, 3);
            this.tblCustomerInfo.Controls.Add(this.lblNumberPeople, 0, 4);
            this.tblCustomerInfo.Controls.Add(this.txtNumberPeople, 1, 4);
            this.tblCustomerInfo.Controls.Add(this.btnCalculateBill, 1, 5);
            this.tblCustomerInfo.Location = new System.Drawing.Point(6, 19);
            this.tblCustomerInfo.Name = "tblCustomerInfo";
            this.tblCustomerInfo.RowCount = 6;
            this.tblCustomerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tblCustomerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tblCustomerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tblCustomerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tblCustomerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66F));
            this.tblCustomerInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.7F));
            this.tblCustomerInfo.Size = new System.Drawing.Size(348, 175);
            this.tblCustomerInfo.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(142, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 22);
            this.txtName.TabIndex = 1;
            // 
            // lblLastMonth
            // 
            this.lblLastMonth.AutoSize = true;
            this.lblLastMonth.Location = new System.Drawing.Point(3, 29);
            this.lblLastMonth.Name = "lblLastMonth";
            this.lblLastMonth.Size = new System.Drawing.Size(109, 16);
            this.lblLastMonth.TabIndex = 2;
            this.lblLastMonth.Text = "Last Month Index:";
            // 
            // txtLastMonth
            // 
            this.txtLastMonth.Location = new System.Drawing.Point(142, 32);
            this.txtLastMonth.Name = "txtLastMonth";
            this.txtLastMonth.Size = new System.Drawing.Size(203, 22);
            this.txtLastMonth.TabIndex = 3;
            // 
            // lblThisMonth
            // 
            this.lblThisMonth.AutoSize = true;
            this.lblThisMonth.Location = new System.Drawing.Point(3, 58);
            this.lblThisMonth.Name = "lblThisMonth";
            this.lblThisMonth.Size = new System.Drawing.Size(110, 16);
            this.lblThisMonth.TabIndex = 4;
            this.lblThisMonth.Text = "This Month Index:";
            // 
            // txtThisMonth
            // 
            this.txtThisMonth.Location = new System.Drawing.Point(142, 61);
            this.txtThisMonth.Name = "txtThisMonth";
            this.txtThisMonth.Size = new System.Drawing.Size(203, 22);
            this.txtThisMonth.TabIndex = 5;
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Location = new System.Drawing.Point(3, 87);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(102, 16);
            this.lblCustomerType.TabIndex = 6;
            this.lblCustomerType.Text = "Customer Type:";
            // 
            // cmbCustomerType
            // 
            this.cmbCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomerType.FormattingEnabled = true;
            this.cmbCustomerType.Items.AddRange(new object[] {
            "Household",
            "Administrative",
            "Production",
            "Business"});
            this.cmbCustomerType.Location = new System.Drawing.Point(142, 90);
            this.cmbCustomerType.Name = "cmbCustomerType";
            this.cmbCustomerType.Size = new System.Drawing.Size(203, 24);
            this.cmbCustomerType.TabIndex = 7;
            // 
            // lblNumberPeople
            // 
            this.lblNumberPeople.AutoSize = true;
            this.lblNumberPeople.Location = new System.Drawing.Point(3, 116);
            this.lblNumberPeople.Name = "lblNumberPeople";
            this.lblNumberPeople.Size = new System.Drawing.Size(119, 16);
            this.lblNumberPeople.TabIndex = 8;
            this.lblNumberPeople.Text = "Number of People:";
            // 
            // txtNumberPeople
            // 
            this.txtNumberPeople.Location = new System.Drawing.Point(142, 119);
            this.txtNumberPeople.Name = "txtNumberPeople";
            this.txtNumberPeople.Size = new System.Drawing.Size(203, 22);
            this.txtNumberPeople.TabIndex = 9;
            // 
            // btnCalculateBill
            // 
            this.btnCalculateBill.Location = new System.Drawing.Point(142, 148);
            this.btnCalculateBill.Name = "btnCalculateBill";
            this.btnCalculateBill.Size = new System.Drawing.Size(100, 23);
            this.btnCalculateBill.TabIndex = 10;
            this.btnCalculateBill.Text = "Calculate Bill";
            this.btnCalculateBill.UseVisualStyleBackColor = true;
            this.btnCalculateBill.Click += new System.EventHandler(this.btnCalculateBill_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 218);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(360, 206);
            this.txtResult.TabIndex = 11;
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(12, 433);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(93, 16);
            this.lblSearchName.TabIndex = 12;
            this.lblSearchName.Text = "Search Name:";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(100, 430);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(200, 22);
            this.txtSearchName.TabIndex = 13;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(18, 456);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(83, 23);
            this.btnSearchCustomer.TabIndex = 14;
            this.btnSearchCustomer.Text = "Search Customer";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // lstCustomers
            // 
            this.lstCustomers.ItemHeight = 16;
            this.lstCustomers.Location = new System.Drawing.Point(12, 485);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(360, 132);
            this.lstCustomers.TabIndex = 15;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(200, 456);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(83, 23);
            this.btClear.TabIndex = 16;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(289, 456);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(83, 23);
            this.btExit.TabIndex = 17;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(384, 644);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.grpCustomerInfo);
            this.Name = "Form1";
            this.Text = "Water Bill Calculator";
            this.grpCustomerInfo.ResumeLayout(false);
            this.tblCustomerInfo.ResumeLayout(false);
            this.tblCustomerInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btExit;
    }
}