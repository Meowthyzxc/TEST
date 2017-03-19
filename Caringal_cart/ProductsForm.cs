using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity.Infrastructure;

namespace Caringal_cart
{
    public partial class ProductsForm : Form
    {
        private bool isNew;
        public ProductsForm()
        {
            InitializeComponent();
        }

        // A D D   N E W   P R O D U C T
        private void AddNewProduct()
        {
            using (var db = new CartEntities())
            {
                var product = new Product { 
                    description = txtDesc.Text,
                    price = double.Parse(txtPrice.Value.ToString())
                };
                db.Entry(product).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();

                //MessageBox.Show(product.prod_id + "");
            }
            isNew = false; cmdSave.Enabled = false;
            txtId.Clear(); txtDesc.Clear(); txtPrice.Value = 0;
        }

        // U P D A T E   P R O D U C T
        private void UpdateProduct()
        {
            int id = int.Parse(txtId.Text);
            Product p = null;
            using (var db = new CartEntities())
            {
                try
                {
                    db.Configuration.ProxyCreationEnabled = false;
                    p = db.Products.Where(f => f.prod_id == id).Single();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            using (var db = new CartEntities())
            {
                bool saveflag = true;
                do
                {
                    saveflag = false;
                    try
                    {
                        p.description = txtDesc.Text;
                        p.price = int.Parse(txtPrice.Value.ToString());
                        db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Updated.");
                        isNew = false; cmdSave.Enabled = false;
                        txtId.Clear(); txtDesc.Clear(); txtPrice.Value = 0;
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        saveflag = true;
                        ex.Entries.Single().Reload();
                        MessageBox.Show("Optimistic concurrency exception occured.");
                    }
                } while (saveflag);
            }
        }

        // N E W   C L I C K
        private void cmdNew_Click(object sender, EventArgs e)
        {
            cmdSave.Enabled = true;
            isNew = true;
        }

        // S A V E   C L I C K
        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (isNew)
                AddNewProduct();
            else
                UpdateProduct();
        }

        // S E A R C H   C L I C K
        private void cmdSearch_Click(object sender, EventArgs e)
        {
            using (var db = new CartEntities())
            {
                var product = db.Products.Find(int.Parse(txtId.Text));
                if (product != null)
                {
                    txtDesc.Text = product.description;
                    txtPrice.Text = product.price.ToString();
                    isNew = false; cmdSave.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Not found.");
                    isNew = true; cmdSave.Enabled = false;
                    txtId.Clear(); txtDesc.Clear(); txtPrice.Value = 0;
                }
            }
        }

        // C L O S E   C L I C K
        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

        }



    }
}
