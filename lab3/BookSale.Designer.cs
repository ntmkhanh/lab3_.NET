namespace lab3
{
    partial class BookSale
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnunew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuexit = new System.Windows.Forms.ToolStripMenuItem();
            this.grBoxTitle = new System.Windows.Forms.GroupBox();
            this.txtExPrice = new System.Windows.Forms.TextBox();
            this.labExPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.labPrice = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.labQuantity = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.labTitle = new System.Windows.Forms.Label();
            this.mnuSum = new System.Windows.Forms.ToolStripMenuItem();
            this.labDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtNetDue = new System.Windows.Forms.TextBox();
            this.labNetDue = new System.Windows.Forms.Label();
            this.chkNorDis = new System.Windows.Forms.CheckBox();
            this.chkDisStu = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.grBoxTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(615, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnunew,
            this.mnuCal,
            this.mnuexit,
            this.mnuSum});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(50, 24);
            this.mnuFile.Text = " File";
            this.mnuFile.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // mnunew
            // 
            this.mnunew.Name = "mnunew";
            this.mnunew.Size = new System.Drawing.Size(224, 26);
            this.mnunew.Text = "New";
            this.mnunew.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // mnuCal
            // 
            this.mnuCal.Name = "mnuCal";
            this.mnuCal.Size = new System.Drawing.Size(224, 26);
            this.mnuCal.Text = "Caculate";
            this.mnuCal.Click += new System.EventHandler(this.mnuCal_Click);
            // 
            // mnuexit
            // 
            this.mnuexit.Name = "mnuexit";
            this.mnuexit.Size = new System.Drawing.Size(224, 26);
            this.mnuexit.Text = "Exit";
            this.mnuexit.Click += new System.EventHandler(this.mnuexit_Click);
            // 
            // grBoxTitle
            // 
            this.grBoxTitle.Controls.Add(this.chkDisStu);
            this.grBoxTitle.Controls.Add(this.chkNorDis);
            this.grBoxTitle.Controls.Add(this.labNetDue);
            this.grBoxTitle.Controls.Add(this.txtNetDue);
            this.grBoxTitle.Controls.Add(this.txtDiscount);
            this.grBoxTitle.Controls.Add(this.labDiscount);
            this.grBoxTitle.Controls.Add(this.txtExPrice);
            this.grBoxTitle.Controls.Add(this.labExPrice);
            this.grBoxTitle.Controls.Add(this.txtPrice);
            this.grBoxTitle.Controls.Add(this.labPrice);
            this.grBoxTitle.Controls.Add(this.txtQuantity);
            this.grBoxTitle.Controls.Add(this.labQuantity);
            this.grBoxTitle.Controls.Add(this.txtTitle);
            this.grBoxTitle.Controls.Add(this.labTitle);
            this.grBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grBoxTitle.Location = new System.Drawing.Point(34, 43);
            this.grBoxTitle.Name = "grBoxTitle";
            this.grBoxTitle.Size = new System.Drawing.Size(543, 432);
            this.grBoxTitle.TabIndex = 1;
            this.grBoxTitle.TabStop = false;
            this.grBoxTitle.Text = "BookSale";
            this.grBoxTitle.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtExPrice
            // 
            this.txtExPrice.Location = new System.Drawing.Point(181, 227);
            this.txtExPrice.Name = "txtExPrice";
            this.txtExPrice.ReadOnly = true;
            this.txtExPrice.Size = new System.Drawing.Size(143, 26);
            this.txtExPrice.TabIndex = 7;
            // 
            // labExPrice
            // 
            this.labExPrice.AutoSize = true;
            this.labExPrice.Location = new System.Drawing.Point(30, 233);
            this.labExPrice.Name = "labExPrice";
            this.labExPrice.Size = new System.Drawing.Size(122, 20);
            this.labExPrice.TabIndex = 6;
            this.labExPrice.Text = "Extended Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(181, 162);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(324, 26);
            this.txtPrice.TabIndex = 5;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(30, 168);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(48, 20);
            this.labPrice.TabIndex = 4;
            this.labPrice.Text = "Price";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(181, 96);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(324, 26);
            this.txtQuantity.TabIndex = 3;
            // 
            // labQuantity
            // 
            this.labQuantity.AutoSize = true;
            this.labQuantity.Location = new System.Drawing.Point(30, 102);
            this.labQuantity.Name = "labQuantity";
            this.labQuantity.Size = new System.Drawing.Size(71, 20);
            this.labQuantity.TabIndex = 2;
            this.labQuantity.Text = "Quantity";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(181, 38);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(324, 26);
            this.txtTitle.TabIndex = 1;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Location = new System.Drawing.Point(30, 44);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(41, 20);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "Title";
            // 
            // mnuSum
            // 
            this.mnuSum.Name = "mnuSum";
            this.mnuSum.Size = new System.Drawing.Size(224, 26);
            this.mnuSum.Text = "Summary";
            this.mnuSum.Click += new System.EventHandler(this.mnuSum_Click);
            // 
            // labDiscount
            // 
            this.labDiscount.AutoSize = true;
            this.labDiscount.Location = new System.Drawing.Point(30, 295);
            this.labDiscount.Name = "labDiscount";
            this.labDiscount.Size = new System.Drawing.Size(76, 20);
            this.labDiscount.TabIndex = 8;
            this.labDiscount.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(181, 289);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(143, 26);
            this.txtDiscount.TabIndex = 9;
            // 
            // txtNetDue
            // 
            this.txtNetDue.Location = new System.Drawing.Point(181, 346);
            this.txtNetDue.Name = "txtNetDue";
            this.txtNetDue.ReadOnly = true;
            this.txtNetDue.Size = new System.Drawing.Size(143, 26);
            this.txtNetDue.TabIndex = 10;
            // 
            // labNetDue
            // 
            this.labNetDue.AutoSize = true;
            this.labNetDue.Location = new System.Drawing.Point(30, 352);
            this.labNetDue.Name = "labNetDue";
            this.labNetDue.Size = new System.Drawing.Size(71, 20);
            this.labNetDue.TabIndex = 11;
            this.labNetDue.Text = "Net Due";
            // 
            // chkNorDis
            // 
            this.chkNorDis.AutoSize = true;
            this.chkNorDis.Location = new System.Drawing.Point(348, 260);
            this.chkNorDis.Name = "chkNorDis";
            this.chkNorDis.Size = new System.Drawing.Size(157, 24);
            this.chkNorDis.TabIndex = 12;
            this.chkNorDis.Text = "Normal Discount";
            this.chkNorDis.UseVisualStyleBackColor = true;
            // 
            // chkDisStu
            // 
            this.chkDisStu.AutoSize = true;
            this.chkDisStu.Location = new System.Drawing.Point(348, 309);
            this.chkDisStu.Name = "chkDisStu";
            this.chkDisStu.Size = new System.Drawing.Size(151, 24);
            this.chkDisStu.TabIndex = 13;
            this.chkDisStu.Text = "Distinct Student";
            this.chkDisStu.UseVisualStyleBackColor = true;
            // 
            // BookSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 502);
            this.Controls.Add(this.grBoxTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookSale";
            this.Text = "BookSale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grBoxTitle.ResumeLayout(false);
            this.grBoxTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnunew;
        private System.Windows.Forms.ToolStripMenuItem mnuCal;
        private System.Windows.Forms.ToolStripMenuItem mnuexit;
        private System.Windows.Forms.GroupBox grBoxTitle;
        private System.Windows.Forms.TextBox txtExPrice;
        private System.Windows.Forms.Label labExPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label labQuantity;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.ToolStripMenuItem mnuSum;
        private System.Windows.Forms.CheckBox chkNorDis;
        private System.Windows.Forms.Label labNetDue;
        private System.Windows.Forms.TextBox txtNetDue;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label labDiscount;
        private System.Windows.Forms.CheckBox chkDisStu;
    }
}

