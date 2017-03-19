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
    public partial class TransactionsForm : Form
    {
        public TransactionsForm()
        {
            InitializeComponent();
        }

        private void TransactionsForm_Load(object sender, EventArgs e)
        {
            using (var db = new CartEntities())
            {
                dgvTrans.DataSource = db.TransDetails.ToList();
                dgvTrans.Columns[0].Width = 55;
                dgvTrans.Columns[1].Width = 55;

                dgvTransDetails.DataSource = db.Transactions.ToList();
                dgvTransDetails.Columns[0].Width = 100;
                dgvTransDetails.Columns[1].Width = 100;
            }
        }
    }
}
