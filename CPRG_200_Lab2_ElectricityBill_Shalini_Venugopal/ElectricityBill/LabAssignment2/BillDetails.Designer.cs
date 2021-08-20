namespace BillGenerator
{
    partial class BillDetails
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillDetails));
            this.lstCustomerDetails = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCustomerCountDisplay = new System.Windows.Forms.Label();
            this.grpStatistics = new System.Windows.Forms.GroupBox();
            this.lblAverageBillAmount = new System.Windows.Forms.Label();
            this.lblTotalKwh = new System.Windows.Forms.Label();
            this.lblCustomerCount = new System.Windows.Forms.Label();
            this.lblAverageBillDisplay = new System.Windows.Forms.Label();
            this.lblTotalKwhDisplay = new System.Windows.Forms.Label();
            this.grpAddCust = new System.Windows.Forms.GroupBox();
            this.lblKwhUsed = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtUnitsUsed = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblAmountBilled = new System.Windows.Forms.Label();
            this.lblAccountId = new System.Windows.Forms.Label();
            this.grplastAdded = new System.Windows.Forms.GroupBox();
            this.lblAmountBilledDisp = new System.Windows.Forms.Label();
            this.lblAccountIdDisp = new System.Windows.Forms.Label();
            this.picElectricity = new System.Windows.Forms.PictureBox();
            this.grpStatistics.SuspendLayout();
            this.grpAddCust.SuspendLayout();
            this.grplastAdded.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picElectricity)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCustomerDetails
            // 
            this.lstCustomerDetails.BackColor = System.Drawing.Color.Lavender;
            this.lstCustomerDetails.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstCustomerDetails.FormattingEnabled = true;
            this.lstCustomerDetails.ItemHeight = 25;
            this.lstCustomerDetails.Location = new System.Drawing.Point(3, 170);
            this.lstCustomerDetails.Name = "lstCustomerDetails";
            this.lstCustomerDetails.Size = new System.Drawing.Size(920, 504);
            this.lstCustomerDetails.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnAdd.Location = new System.Drawing.Point(948, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnCancel.Location = new System.Drawing.Point(1279, 622);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Exit";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Black;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnClear.Location = new System.Drawing.Point(1279, 340);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCustomerCountDisplay
            // 
            this.lblCustomerCountDisplay.BackColor = System.Drawing.Color.Lavender;
            this.lblCustomerCountDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerCountDisplay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomerCountDisplay.Location = new System.Drawing.Point(187, 32);
            this.lblCustomerCountDisplay.Name = "lblCustomerCountDisplay";
            this.lblCustomerCountDisplay.Size = new System.Drawing.Size(244, 29);
            this.lblCustomerCountDisplay.TabIndex = 5;
            // 
            // grpStatistics
            // 
            this.grpStatistics.Controls.Add(this.lblAverageBillAmount);
            this.grpStatistics.Controls.Add(this.lblTotalKwh);
            this.grpStatistics.Controls.Add(this.lblCustomerCount);
            this.grpStatistics.Controls.Add(this.lblAverageBillDisplay);
            this.grpStatistics.Controls.Add(this.lblTotalKwhDisplay);
            this.grpStatistics.Controls.Add(this.lblCustomerCountDisplay);
            this.grpStatistics.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpStatistics.Location = new System.Drawing.Point(948, 409);
            this.grpStatistics.Name = "grpStatistics";
            this.grpStatistics.Size = new System.Drawing.Size(460, 172);
            this.grpStatistics.TabIndex = 6;
            this.grpStatistics.TabStop = false;
            this.grpStatistics.Text = "Statistics";
            // 
            // lblAverageBillAmount
            // 
            this.lblAverageBillAmount.AutoSize = true;
            this.lblAverageBillAmount.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAverageBillAmount.Location = new System.Drawing.Point(6, 120);
            this.lblAverageBillAmount.Name = "lblAverageBillAmount";
            this.lblAverageBillAmount.Size = new System.Drawing.Size(174, 25);
            this.lblAverageBillAmount.TabIndex = 6;
            this.lblAverageBillAmount.Text = "Average Bill Amount";
            // 
            // lblTotalKwh
            // 
            this.lblTotalKwh.AutoSize = true;
            this.lblTotalKwh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalKwh.Location = new System.Drawing.Point(3, 77);
            this.lblTotalKwh.Name = "lblTotalKwh";
            this.lblTotalKwh.Size = new System.Drawing.Size(135, 25);
            this.lblTotalKwh.TabIndex = 6;
            this.lblTotalKwh.Text = "Total kWh Used";
            // 
            // lblCustomerCount
            // 
            this.lblCustomerCount.AutoSize = true;
            this.lblCustomerCount.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomerCount.Location = new System.Drawing.Point(6, 33);
            this.lblCustomerCount.Name = "lblCustomerCount";
            this.lblCustomerCount.Size = new System.Drawing.Size(135, 25);
            this.lblCustomerCount.TabIndex = 6;
            this.lblCustomerCount.Text = "# of Customers";
            // 
            // lblAverageBillDisplay
            // 
            this.lblAverageBillDisplay.BackColor = System.Drawing.Color.Lavender;
            this.lblAverageBillDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverageBillDisplay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAverageBillDisplay.Location = new System.Drawing.Point(186, 120);
            this.lblAverageBillDisplay.Name = "lblAverageBillDisplay";
            this.lblAverageBillDisplay.Size = new System.Drawing.Size(245, 29);
            this.lblAverageBillDisplay.TabIndex = 5;
            // 
            // lblTotalKwhDisplay
            // 
            this.lblTotalKwhDisplay.BackColor = System.Drawing.Color.Lavender;
            this.lblTotalKwhDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalKwhDisplay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalKwhDisplay.Location = new System.Drawing.Point(187, 77);
            this.lblTotalKwhDisplay.Name = "lblTotalKwhDisplay";
            this.lblTotalKwhDisplay.Size = new System.Drawing.Size(244, 29);
            this.lblTotalKwhDisplay.TabIndex = 5;
            // 
            // grpAddCust
            // 
            this.grpAddCust.Controls.Add(this.lblKwhUsed);
            this.grpAddCust.Controls.Add(this.txtFirstName);
            this.grpAddCust.Controls.Add(this.lblLastName);
            this.grpAddCust.Controls.Add(this.txtUnitsUsed);
            this.grpAddCust.Controls.Add(this.lblFirstName);
            this.grpAddCust.Controls.Add(this.txtLastName);
            this.grpAddCust.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpAddCust.Location = new System.Drawing.Point(948, 18);
            this.grpAddCust.Name = "grpAddCust";
            this.grpAddCust.Size = new System.Drawing.Size(460, 146);
            this.grpAddCust.TabIndex = 7;
            this.grpAddCust.TabStop = false;
            this.grpAddCust.Text = "Add Customer";
            // 
            // lblKwhUsed
            // 
            this.lblKwhUsed.AutoSize = true;
            this.lblKwhUsed.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKwhUsed.Location = new System.Drawing.Point(14, 115);
            this.lblKwhUsed.Name = "lblKwhUsed";
            this.lblKwhUsed.Size = new System.Drawing.Size(93, 25);
            this.lblKwhUsed.TabIndex = 4;
            this.lblKwhUsed.Text = "kWh Used";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.Lavender;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(186, 35);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(245, 31);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLastName.Location = new System.Drawing.Point(12, 78);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(95, 25);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name";
            // 
            // txtUnitsUsed
            // 
            this.txtUnitsUsed.BackColor = System.Drawing.Color.Lavender;
            this.txtUnitsUsed.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUnitsUsed.Location = new System.Drawing.Point(186, 109);
            this.txtUnitsUsed.Name = "txtUnitsUsed";
            this.txtUnitsUsed.Size = new System.Drawing.Size(245, 31);
            this.txtUnitsUsed.TabIndex = 3;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirstName.Location = new System.Drawing.Point(13, 41);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(97, 25);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.Lavender;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(186, 72);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(245, 31);
            this.txtLastName.TabIndex = 2;
            // 
            // lblAmountBilled
            // 
            this.lblAmountBilled.AutoSize = true;
            this.lblAmountBilled.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmountBilled.Location = new System.Drawing.Point(6, 78);
            this.lblAmountBilled.Name = "lblAmountBilled";
            this.lblAmountBilled.Size = new System.Drawing.Size(124, 25);
            this.lblAmountBilled.TabIndex = 4;
            this.lblAmountBilled.Text = "Amount Billed";
            // 
            // lblAccountId
            // 
            this.lblAccountId.AutoSize = true;
            this.lblAccountId.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAccountId.Location = new System.Drawing.Point(6, 41);
            this.lblAccountId.Name = "lblAccountId";
            this.lblAccountId.Size = new System.Drawing.Size(98, 25);
            this.lblAccountId.TabIndex = 4;
            this.lblAccountId.Text = "Account Id";
            // 
            // grplastAdded
            // 
            this.grplastAdded.Controls.Add(this.lblAmountBilledDisp);
            this.grplastAdded.Controls.Add(this.lblAccountIdDisp);
            this.grplastAdded.Controls.Add(this.lblAccountId);
            this.grplastAdded.Controls.Add(this.lblAmountBilled);
            this.grplastAdded.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grplastAdded.Location = new System.Drawing.Point(948, 184);
            this.grplastAdded.Name = "grplastAdded";
            this.grplastAdded.Size = new System.Drawing.Size(460, 115);
            this.grplastAdded.TabIndex = 8;
            this.grplastAdded.TabStop = false;
            this.grplastAdded.Text = "Last Added Account";
            // 
            // lblAmountBilledDisp
            // 
            this.lblAmountBilledDisp.BackColor = System.Drawing.Color.Lavender;
            this.lblAmountBilledDisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmountBilledDisp.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAmountBilledDisp.Location = new System.Drawing.Point(186, 74);
            this.lblAmountBilledDisp.Name = "lblAmountBilledDisp";
            this.lblAmountBilledDisp.Size = new System.Drawing.Size(245, 29);
            this.lblAmountBilledDisp.TabIndex = 7;
            // 
            // lblAccountIdDisp
            // 
            this.lblAccountIdDisp.BackColor = System.Drawing.Color.Lavender;
            this.lblAccountIdDisp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAccountIdDisp.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAccountIdDisp.Location = new System.Drawing.Point(186, 37);
            this.lblAccountIdDisp.Name = "lblAccountIdDisp";
            this.lblAccountIdDisp.Size = new System.Drawing.Size(245, 29);
            this.lblAccountIdDisp.TabIndex = 8;
            // 
            // picElectricity
            // 
            this.picElectricity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picElectricity.BackgroundImage")));
            this.picElectricity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picElectricity.Location = new System.Drawing.Point(198, -3);
            this.picElectricity.Name = "picElectricity";
            this.picElectricity.Size = new System.Drawing.Size(330, 167);
            this.picElectricity.TabIndex = 9;
            this.picElectricity.TabStop = false;
            // 
            // BillDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1433, 686);
            this.Controls.Add(this.picElectricity);
            this.Controls.Add(this.grplastAdded);
            this.Controls.Add(this.grpStatistics);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstCustomerDetails);
            this.Controls.Add(this.grpAddCust);
            this.Name = "BillDetails";
            this.Text = "Electricity Bill Generator";
            this.Load += new System.EventHandler(this.BillDetails_Load);
            this.grpStatistics.ResumeLayout(false);
            this.grpStatistics.PerformLayout();
            this.grpAddCust.ResumeLayout(false);
            this.grpAddCust.PerformLayout();
            this.grplastAdded.ResumeLayout(false);
            this.grplastAdded.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picElectricity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomerDetails;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCustomerCountDisplay;
        private System.Windows.Forms.GroupBox grpStatistics;
        private System.Windows.Forms.Label lblAverageBillAmount;
        private System.Windows.Forms.Label lblTotalKwh;
        private System.Windows.Forms.Label lblCustomerCount;
        private System.Windows.Forms.Label lblAverageBillDisplay;
        private System.Windows.Forms.Label lblTotalKwhDisplay;
        private System.Windows.Forms.GroupBox grpAddCust;
        private System.Windows.Forms.Label lblAccountId;
        private System.Windows.Forms.Label lblKwhUsed;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtUnitsUsed;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblAmountBilled;
        private System.Windows.Forms.GroupBox grplastAdded;
        private System.Windows.Forms.PictureBox picElectricity;
        private System.Windows.Forms.Label lblAmountBilledDisp;
        private System.Windows.Forms.Label lblAccountIdDisp;
    }
}

