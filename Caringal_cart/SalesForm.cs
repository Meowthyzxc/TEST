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
    public partial class SalesForm : Form
    {
        bool loaded = false;
        public SalesForm()
        {
            InitializeComponent();
        }

        // G E T   P R I C E
        private double getPrice()
        {
            using (var db = new CartEntities())
            {
                int id = int.Parse(cmbProd.SelectedValue.ToString());
                var price = (from c in db.Products where c.prod_id == id select c).SingleOrDefault();

                return double.Parse(price.price.ToString());
            }
        }

        // C O M P U T E   I N D I V I D U A L   P R I C E
        private double computeIndividualPrice(double price, int qty)
        {
            return price * qty;
        }

        // C O M P U T E   O V E R A L L   T O T A L
        private double computeOverallTotal()
        {
            double total = 0;
            for (int i = 0; i < lbTotal.Items.Count; i++)
            {
                total += double.Parse(lbTotal.Items[i].ToString());
            }
            return total;
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            using (var db = new CartEntities())
            {
                cmbProd.DataSource = db.Products.ToList();
                cmbProd.DisplayMember = "description";
                cmbProd.ValueMember = "prod_id";
                cmbProd.SelectedIndex = -1;
                loaded = true;
            }
        }

        private void cmbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProd.SelectedIndex != -1){
                if(loaded)
                    lblPrice.Text = getPrice().ToString();

                // compute total
                lblTotal.Text = computeIndividualPrice(double.Parse(lblPrice.Text), int.Parse(txtQty.Value.ToString())).ToString();
            }
        }

        private void txtQty_ValueChanged(object sender, EventArgs e)
        {
            // compute total
            lblTotal.Text = computeIndividualPrice(double.Parse(lblPrice.Text), int.Parse(txtQty.Value.ToString())).ToString();
        }

        private void cmdCart_Click(object sender, EventArgs e)
        {
            lbCartDesc.Items.Add(cmbProd.Text); // prod name
            lbId.Items.Add(cmbProd.SelectedValue); // prod id
            lbQty.Items.Add(txtQty.Text); // quantity
            lbCartPrice.Items.Add(lblPrice.Text); // price
            lbTotal.Items.Add(lblTotal.Text); // total
            lbOverallTotal.Text = computeOverallTotal().ToString(); // purchase total
        }

        private void cmdPurcahse_Click(object sender, EventArgs e)
        {
            int trans_id_inserted;
            using (var db = new CartEntities())
            {
                using (var dbtrx = db.Database.BeginTransaction())
                {
                    try
                    {
                        var trans = new Transaction
                        {
                            total = double.Parse(lbOverallTotal.Text)
                        };
                        db.Entry(trans).State = System.Data.Entity.EntityState.Added;
                        db.SaveChanges();

                        trans_id_inserted = trans.trans_id; // last id inserted

                        for (int i = 0; i < lbId.Items.Count; i++)
                        {
                            var trans_details = new TransDetail
                            {
                                prod_id = int.Parse(lbId.Items[i].ToString()),
                                trans_id = trans_id_inserted,
                                price = double.Parse(lbCartPrice.Items[i].ToString()),
                                qty = int.Parse(lbQty.Items[i].ToString())
                            };
                            db.Entry(trans_details).State = System.Data.Entity.EntityState.Added;
                            db.SaveChanges();
                        }

                        dbtrx.Commit();
                        MessageBox.Show("Successfully recorded transaction");
                    }
                    catch
                    {
                        MessageBox.Show("Error on recording transaction");
                        dbtrx.Rollback(); 
                    }
                }

            }
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
