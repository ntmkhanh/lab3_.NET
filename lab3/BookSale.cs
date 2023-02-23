using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class BookSale : Form
    {
        private clsBookSale mBookSale;
        public BookSale()
        {
            InitializeComponent();
        }
    


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTitle.Text = txtQuantity.Text = txtPrice.Text = txtExPrice.Text = " ";

        }

        private void mnuCal_Click(object sender, EventArgs e)
        {
            try
            {
                mBookSale = new clsBookSale();
                mBookSale.Title = txtTitle.Text;
                mBookSale.Quatity = Convert.ToInt32(txtQuantity.Text);
                mBookSale.Price = Convert.ToDecimal(txtPrice.Text);

                txtExPrice.Text = mBookSale.ExtendedPrice().ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Quantity or Price. " + ex.Message, "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mnuexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
