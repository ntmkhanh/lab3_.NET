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
            this.menuStrip1.Size = new System.Drawing.Size(633, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnunew,
            this.mnuCal,
            this.mnuexit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(50, 26);
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
            this.grBoxTitle.Size = new System.Drawing.Size(564, 342);
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
            // BookSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.grBoxTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookSale";
            this.Text = "Form1";
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
    }
}

