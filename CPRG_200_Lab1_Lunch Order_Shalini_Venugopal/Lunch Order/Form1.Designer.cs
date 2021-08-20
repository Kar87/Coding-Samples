
namespace Lunch_Order
{
    partial class frmLunch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLunch));
            this.picLunch = new System.Windows.Forms.PictureBox();
            this.grpMainCourse = new System.Windows.Forms.GroupBox();
            this.radSalad = new System.Windows.Forms.RadioButton();
            this.radPizza = new System.Windows.Forms.RadioButton();
            this.radHamBurger = new System.Windows.Forms.RadioButton();
            this.grpAddOn = new System.Windows.Forms.GroupBox();
            this.chkExtras3 = new System.Windows.Forms.CheckBox();
            this.chkExtras2 = new System.Windows.Forms.CheckBox();
            this.chkExtras1 = new System.Windows.Forms.CheckBox();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.lblDisplayTotal = new System.Windows.Forms.Label();
            this.lblDisplayTax = new System.Windows.Forms.Label();
            this.lblDisplaySubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLunch)).BeginInit();
            this.grpMainCourse.SuspendLayout();
            this.grpAddOn.SuspendLayout();
            this.grpOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLunch
            // 
            this.picLunch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLunch.BackgroundImage")));
            this.picLunch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLunch.Location = new System.Drawing.Point(193, 54);
            this.picLunch.Margin = new System.Windows.Forms.Padding(4);
            this.picLunch.Name = "picLunch";
            this.picLunch.Size = new System.Drawing.Size(293, 186);
            this.picLunch.TabIndex = 0;
            this.picLunch.TabStop = false;
            // 
            // grpMainCourse
            // 
            this.grpMainCourse.Controls.Add(this.radSalad);
            this.grpMainCourse.Controls.Add(this.radPizza);
            this.grpMainCourse.Controls.Add(this.radHamBurger);
            this.grpMainCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMainCourse.Location = new System.Drawing.Point(46, 265);
            this.grpMainCourse.Margin = new System.Windows.Forms.Padding(4);
            this.grpMainCourse.Name = "grpMainCourse";
            this.grpMainCourse.Padding = new System.Windows.Forms.Padding(4);
            this.grpMainCourse.Size = new System.Drawing.Size(267, 137);
            this.grpMainCourse.TabIndex = 1;
            this.grpMainCourse.TabStop = false;
            this.grpMainCourse.Text = "Main Course";
            // 
            // radSalad
            // 
            this.radSalad.AutoSize = true;
            this.radSalad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSalad.Location = new System.Drawing.Point(8, 103);
            this.radSalad.Margin = new System.Windows.Forms.Padding(4);
            this.radSalad.Name = "radSalad";
            this.radSalad.Size = new System.Drawing.Size(141, 24);
            this.radSalad.TabIndex = 2;
            this.radSalad.TabStop = true;
            this.radSalad.Text = "Salad - $4.95";
            this.radSalad.UseVisualStyleBackColor = true;
            this.radSalad.CheckedChanged += new System.EventHandler(this.radSalad_CheckedChanged);
            // 
            // radPizza
            // 
            this.radPizza.AutoSize = true;
            this.radPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPizza.Location = new System.Drawing.Point(8, 70);
            this.radPizza.Margin = new System.Windows.Forms.Padding(4);
            this.radPizza.Name = "radPizza";
            this.radPizza.Size = new System.Drawing.Size(141, 24);
            this.radPizza.TabIndex = 1;
            this.radPizza.TabStop = true;
            this.radPizza.Text = "Pizza - $5.95";
            this.radPizza.UseVisualStyleBackColor = true;
            this.radPizza.CheckedChanged += new System.EventHandler(this.radPizza_CheckedChanged);
            // 
            // radHamBurger
            // 
            this.radHamBurger.AutoSize = true;
            this.radHamBurger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHamBurger.Location = new System.Drawing.Point(8, 38);
            this.radHamBurger.Margin = new System.Windows.Forms.Padding(4);
            this.radHamBurger.Name = "radHamBurger";
            this.radHamBurger.Size = new System.Drawing.Size(187, 24);
            this.radHamBurger.TabIndex = 0;
            this.radHamBurger.TabStop = true;
            this.radHamBurger.Text = "Hamburger - $6.95";
            this.radHamBurger.UseVisualStyleBackColor = true;
            this.radHamBurger.CheckedChanged += new System.EventHandler(this.radHamBurger_CheckedChanged);
            // 
            // grpAddOn
            // 
            this.grpAddOn.Controls.Add(this.chkExtras3);
            this.grpAddOn.Controls.Add(this.chkExtras2);
            this.grpAddOn.Controls.Add(this.chkExtras1);
            this.grpAddOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddOn.Location = new System.Drawing.Point(383, 265);
            this.grpAddOn.Margin = new System.Windows.Forms.Padding(4);
            this.grpAddOn.Name = "grpAddOn";
            this.grpAddOn.Padding = new System.Windows.Forms.Padding(4);
            this.grpAddOn.Size = new System.Drawing.Size(340, 148);
            this.grpAddOn.TabIndex = 2;
            this.grpAddOn.TabStop = false;
            // 
            // chkExtras3
            // 
            this.chkExtras3.AutoSize = true;
            this.chkExtras3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtras3.Location = new System.Drawing.Point(9, 103);
            this.chkExtras3.Margin = new System.Windows.Forms.Padding(4);
            this.chkExtras3.Name = "chkExtras3";
            this.chkExtras3.Size = new System.Drawing.Size(18, 17);
            this.chkExtras3.TabIndex = 2;
            this.chkExtras3.UseVisualStyleBackColor = true;
            // 
            // chkExtras2
            // 
            this.chkExtras2.AutoSize = true;
            this.chkExtras2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtras2.Location = new System.Drawing.Point(9, 70);
            this.chkExtras2.Margin = new System.Windows.Forms.Padding(4);
            this.chkExtras2.Name = "chkExtras2";
            this.chkExtras2.Size = new System.Drawing.Size(18, 17);
            this.chkExtras2.TabIndex = 1;
            this.chkExtras2.UseVisualStyleBackColor = true;
            // 
            // chkExtras1
            // 
            this.chkExtras1.AutoSize = true;
            this.chkExtras1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtras1.Location = new System.Drawing.Point(9, 37);
            this.chkExtras1.Margin = new System.Windows.Forms.Padding(4);
            this.chkExtras1.Name = "chkExtras1";
            this.chkExtras1.Size = new System.Drawing.Size(18, 17);
            this.chkExtras1.TabIndex = 0;
            this.chkExtras1.UseVisualStyleBackColor = true;
            // 
            // grpOrder
            // 
            this.grpOrder.AutoSize = true;
            this.grpOrder.Controls.Add(this.lblDisplayTotal);
            this.grpOrder.Controls.Add(this.lblDisplayTax);
            this.grpOrder.Controls.Add(this.lblDisplaySubtotal);
            this.grpOrder.Controls.Add(this.lblTotal);
            this.grpOrder.Controls.Add(this.lblTax);
            this.grpOrder.Controls.Add(this.lblSubtotal);
            this.grpOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrder.Location = new System.Drawing.Point(46, 441);
            this.grpOrder.Margin = new System.Windows.Forms.Padding(4);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Padding = new System.Windows.Forms.Padding(4);
            this.grpOrder.Size = new System.Drawing.Size(440, 182);
            this.grpOrder.TabIndex = 3;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order Total";
            // 
            // lblDisplayTotal
            // 
            this.lblDisplayTotal.BackColor = System.Drawing.Color.Linen;
            this.lblDisplayTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayTotal.Location = new System.Drawing.Point(207, 128);
            this.lblDisplayTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayTotal.Name = "lblDisplayTotal";
            this.lblDisplayTotal.Size = new System.Drawing.Size(79, 25);
            this.lblDisplayTotal.TabIndex = 5;
            // 
            // lblDisplayTax
            // 
            this.lblDisplayTax.BackColor = System.Drawing.Color.Linen;
            this.lblDisplayTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayTax.Location = new System.Drawing.Point(207, 91);
            this.lblDisplayTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayTax.Name = "lblDisplayTax";
            this.lblDisplayTax.Size = new System.Drawing.Size(79, 25);
            this.lblDisplayTax.TabIndex = 4;
            // 
            // lblDisplaySubtotal
            // 
            this.lblDisplaySubtotal.BackColor = System.Drawing.Color.Linen;
            this.lblDisplaySubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplaySubtotal.Location = new System.Drawing.Point(207, 57);
            this.lblDisplaySubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplaySubtotal.Name = "lblDisplaySubtotal";
            this.lblDisplaySubtotal.Size = new System.Drawing.Size(79, 25);
            this.lblDisplaySubtotal.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(23, 129);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(117, 20);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Order Total :";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblTax.Location = new System.Drawing.Point(48, 91);
            this.lblTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(97, 20);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax (5%) :";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(57, 57);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(96, 20);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal : ";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.AutoSize = true;
            this.btnPlaceOrder.BackColor = System.Drawing.Color.FloralWhite;
            this.btnPlaceOrder.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Window;
            this.btnPlaceOrder.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Window;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(583, 441);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(140, 33);
            this.btnPlaceOrder.TabIndex = 4;
            this.btnPlaceOrder.Text = "&Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.BackColor = System.Drawing.Color.FloralWhite;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(583, 498);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 33);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.FloralWhite;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(583, 558);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 36);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(744, 710);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.grpAddOn);
            this.Controls.Add(this.grpMainCourse);
            this.Controls.Add(this.picLunch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLunch";
            this.RightToLeftLayout = true;
            this.Text = "Lunch cravings? Order now!";
            ((System.ComponentModel.ISupportInitialize)(this.picLunch)).EndInit();
            this.grpMainCourse.ResumeLayout(false);
            this.grpMainCourse.PerformLayout();
            this.grpAddOn.ResumeLayout(false);
            this.grpAddOn.PerformLayout();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLunch;
        private System.Windows.Forms.GroupBox grpMainCourse;
        private System.Windows.Forms.RadioButton radSalad;
        private System.Windows.Forms.RadioButton radPizza;
        private System.Windows.Forms.RadioButton radHamBurger;
        private System.Windows.Forms.GroupBox grpAddOn;
        private System.Windows.Forms.CheckBox chkExtras3;
        private System.Windows.Forms.CheckBox chkExtras2;
        private System.Windows.Forms.CheckBox chkExtras1;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDisplaySubtotal;
        private System.Windows.Forms.Label lblDisplayTotal;
        private System.Windows.Forms.Label lblDisplayTax;
    }
}

