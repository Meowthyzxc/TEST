namespace Caringal_cart
{
    partial class SalesForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cmdCart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.NumericUpDown();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbId = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbOverallTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbQty = new System.Windows.Forms.ListBox();
            this.lbCartPrice = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCartDesc = new System.Windows.Forms.ListBox();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdPurcahse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.cmdCart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.cmbProd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 222);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(208, 138);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(19, 21);
            this.lblTotal.TabIndex = 46;
            this.lblTotal.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 21);
            this.label7.TabIndex = 45;
            this.label7.Text = "Php";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 21);
            this.label6.TabIndex = 44;
            this.label6.Text = "Total :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 43;
            this.label5.Text = "Php";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(208, 72);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(19, 21);
            this.lblPrice.TabIndex = 42;
            this.lblPrice.Text = "0";
            // 
            // cmdCart
            // 
            this.cmdCart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCart.Location = new System.Drawing.Point(286, 174);
            this.cmdCart.Name = "cmdCart";
            this.cmdCart.Size = new System.Drawing.Size(92, 27);
            this.cmdCart.TabIndex = 34;
            this.cmdCart.Text = "Add to cart";
            this.cmdCart.UseVisualStyleBackColor = true;
            this.cmdCart.Click += new System.EventHandler(this.cmdCart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Quantity :";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(176, 103);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(109, 27);
            this.txtQty.TabIndex = 40;
            this.txtQty.ValueChanged += new System.EventHandler(this.txtQty_ValueChanged);
            // 
            // cmbProd
            // 
            this.cmbProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(176, 35);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(202, 29);
            this.cmbProd.TabIndex = 39;
            this.cmbProd.SelectedIndexChanged += new System.EventHandler(this.cmbProd_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "Price :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Product :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbId);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lbOverallTotal);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lbTotal);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lbQty);
            this.groupBox2.Controls.Add(this.lbCartPrice);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbCartDesc);
            this.groupBox2.Controls.Add(this.cmdClose);
            this.groupBox2.Controls.Add(this.cmdPurcahse);
            this.groupBox2.Location = new System.Drawing.Point(12, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 280);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cart";
            // 
            // lbId
            // 
            this.lbId.BackColor = System.Drawing.SystemColors.Control;
            this.lbId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbId.FormattingEnabled = true;
            this.lbId.ItemHeight = 21;
            this.lbId.Location = new System.Drawing.Point(118, 51);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(34, 105);
            this.lbId.TabIndex = 66;
            this.lbId.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(309, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 21);
            this.label13.TabIndex = 60;
            this.label13.Text = "Php";
            // 
            // lbOverallTotal
            // 
            this.lbOverallTotal.AutoSize = true;
            this.lbOverallTotal.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOverallTotal.Location = new System.Drawing.Point(346, 195);
            this.lbOverallTotal.Name = "lbOverallTotal";
            this.lbOverallTotal.Size = new System.Drawing.Size(17, 21);
            this.lbOverallTotal.TabIndex = 65;
            this.lbOverallTotal.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(172, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 21);
            this.label11.TabIndex = 64;
            this.label11.Text = "Purchase Total :";
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lbTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTotal.FormattingEnabled = true;
            this.lbTotal.ItemHeight = 21;
            this.lbTotal.Location = new System.Drawing.Point(336, 51);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(75, 105);
            this.lbTotal.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(332, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 19);
            this.label10.TabIndex = 62;
            this.label10.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(243, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 19);
            this.label9.TabIndex = 61;
            this.label9.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(146, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 19);
            this.label8.TabIndex = 59;
            this.label8.Text = "Quantity";
            // 
            // lbQty
            // 
            this.lbQty.BackColor = System.Drawing.SystemColors.Control;
            this.lbQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbQty.FormattingEnabled = true;
            this.lbQty.ItemHeight = 21;
            this.lbQty.Location = new System.Drawing.Point(176, 51);
            this.lbQty.Name = "lbQty";
            this.lbQty.Size = new System.Drawing.Size(34, 105);
            this.lbQty.TabIndex = 58;
            // 
            // lbCartPrice
            // 
            this.lbCartPrice.BackColor = System.Drawing.SystemColors.Control;
            this.lbCartPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCartPrice.FormattingEnabled = true;
            this.lbCartPrice.ItemHeight = 21;
            this.lbCartPrice.Location = new System.Drawing.Point(247, 51);
            this.lbCartPrice.Name = "lbCartPrice";
            this.lbCartPrice.Size = new System.Drawing.Size(75, 105);
            this.lbCartPrice.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 56;
            this.label4.Text = "Product";
            // 
            // lbCartDesc
            // 
            this.lbCartDesc.BackColor = System.Drawing.SystemColors.Control;
            this.lbCartDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCartDesc.FormattingEnabled = true;
            this.lbCartDesc.ItemHeight = 21;
            this.lbCartDesc.Location = new System.Drawing.Point(17, 51);
            this.lbCartDesc.Name = "lbCartDesc";
            this.lbCartDesc.Size = new System.Drawing.Size(102, 105);
            this.lbCartDesc.TabIndex = 55;
            // 
            // cmdClose
            // 
            this.cmdClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.Location = new System.Drawing.Point(353, 247);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 27);
            this.cmdClose.TabIndex = 54;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdPurcahse
            // 
            this.cmdPurcahse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPurcahse.Location = new System.Drawing.Point(212, 247);
            this.cmdPurcahse.Name = "cmdPurcahse";
            this.cmdPurcahse.Size = new System.Drawing.Size(135, 27);
            this.cmdPurcahse.TabIndex = 52;
            this.cmdPurcahse.Text = "Purchase Items";
            this.cmdPurcahse.UseVisualStyleBackColor = true;
            this.cmdPurcahse.Click += new System.EventHandler(this.cmdPurcahse_Click);
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 548);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SalesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales section";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtQty;
        private System.Windows.Forms.ComboBox cmbProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbOverallTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbQty;
        private System.Windows.Forms.ListBox lbCartPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbCartDesc;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdPurcahse;
        private System.Windows.Forms.ListBox lbId;

    }
}