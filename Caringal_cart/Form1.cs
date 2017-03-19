using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Caringal_cart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addEditProductToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductsForm form = new ProductsForm();
            form.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesForm form = new SalesForm();
            form.Show();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionsForm form = new TransactionsForm();
            form.Show();
        }

    }
}
