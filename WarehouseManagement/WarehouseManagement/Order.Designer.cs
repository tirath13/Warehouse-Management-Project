namespace WarehouseManagement
{
    partial class Order
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
            this.orderLbl = new System.Windows.Forms.Label();
            this.CustomerTxt = new System.Windows.Forms.TextBox();
            this.makes = new System.Windows.Forms.ComboBox();
            this.makeLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contactLbl = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirmShipping = new System.Windows.Forms.Button();
            this.colorLbl = new System.Windows.Forms.Label();
            this.colors = new System.Windows.Forms.ComboBox();
            this.btnDropOrd = new System.Windows.Forms.Button();
            this.models = new System.Windows.Forms.ComboBox();
            this.modelLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orderLbl
            // 
            this.orderLbl.AutoSize = true;
            this.orderLbl.Location = new System.Drawing.Point(24, 30);
            this.orderLbl.Name = "orderLbl";
            this.orderLbl.Size = new System.Drawing.Size(82, 13);
            this.orderLbl.TabIndex = 0;
            this.orderLbl.Text = "Customer Name";
            // 
            // CustomerTxt
            // 
            this.CustomerTxt.Location = new System.Drawing.Point(153, 27);
            this.CustomerTxt.Name = "CustomerTxt";
            this.CustomerTxt.Size = new System.Drawing.Size(121, 20);
            this.CustomerTxt.TabIndex = 1;
            // 
            // makes
            // 
            this.makes.FormattingEnabled = true;
            this.makes.Items.AddRange(new object[] {
            "Any",
            "Acura",
            "Audi",
            "BMW",
            "Ford",
            "Mercedes",
            "Land Rover",
            "Tesla"});
            this.makes.Location = new System.Drawing.Point(153, 147);
            this.makes.Name = "makes";
            this.makes.Size = new System.Drawing.Size(121, 21);
            this.makes.TabIndex = 2;
            // 
            // makeLbl
            // 
            this.makeLbl.AutoSize = true;
            this.makeLbl.Location = new System.Drawing.Point(24, 155);
            this.makeLbl.Name = "makeLbl";
            this.makeLbl.Size = new System.Drawing.Size(67, 13);
            this.makeLbl.TabIndex = 3;
            this.makeLbl.Text = "Select Make";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 5;
            // 
            // contactLbl
            // 
            this.contactLbl.AutoSize = true;
            this.contactLbl.Location = new System.Drawing.Point(24, 84);
            this.contactLbl.Name = "contactLbl";
            this.contactLbl.Size = new System.Drawing.Size(84, 13);
            this.contactLbl.TabIndex = 4;
            this.contactLbl.Text = "Contact Number";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(51, 306);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirmShipping
            // 
            this.btnConfirmShipping.Location = new System.Drawing.Point(277, 306);
            this.btnConfirmShipping.Name = "btnConfirmShipping";
            this.btnConfirmShipping.Size = new System.Drawing.Size(117, 23);
            this.btnConfirmShipping.TabIndex = 9;
            this.btnConfirmShipping.Text = "Confirm to Shipping";
            this.btnConfirmShipping.UseVisualStyleBackColor = true;
            // 
            // colorLbl
            // 
            this.colorLbl.AutoSize = true;
            this.colorLbl.Location = new System.Drawing.Point(24, 257);
            this.colorLbl.Name = "colorLbl";
            this.colorLbl.Size = new System.Drawing.Size(64, 13);
            this.colorLbl.TabIndex = 11;
            this.colorLbl.Text = "Select Color";
            // 
            // colors
            // 
            this.colors.FormattingEnabled = true;
            this.colors.Items.AddRange(new object[] {
            "Any",
            "Black",
            "Blue",
            "Brown",
            "Grey",
            "Pearl White",
            "White"});
            this.colors.Location = new System.Drawing.Point(153, 249);
            this.colors.Name = "colors";
            this.colors.Size = new System.Drawing.Size(121, 21);
            this.colors.TabIndex = 10;
            // 
            // btnDropOrd
            // 
            this.btnDropOrd.Location = new System.Drawing.Point(172, 306);
            this.btnDropOrd.Name = "btnDropOrd";
            this.btnDropOrd.Size = new System.Drawing.Size(75, 23);
            this.btnDropOrd.TabIndex = 12;
            this.btnDropOrd.Text = "Drop Order";
            this.btnDropOrd.UseVisualStyleBackColor = true;
            // 
            // models
            // 
            this.models.FormattingEnabled = true;
            this.models.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.models.Location = new System.Drawing.Point(153, 199);
            this.models.Name = "models";
            this.models.Size = new System.Drawing.Size(121, 21);
            this.models.TabIndex = 6;
            // 
            // modelLbl
            // 
            this.modelLbl.AutoSize = true;
            this.modelLbl.Location = new System.Drawing.Point(24, 202);
            this.modelLbl.Name = "modelLbl";
            this.modelLbl.Size = new System.Drawing.Size(94, 13);
            this.modelLbl.TabIndex = 7;
            this.modelLbl.Text = "Select Model Year";
            this.modelLbl.Click += new System.EventHandler(this.quantityLbl_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(422, 417);
            this.Controls.Add(this.btnDropOrd);
            this.Controls.Add(this.colorLbl);
            this.Controls.Add(this.colors);
            this.Controls.Add(this.btnConfirmShipping);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.modelLbl);
            this.Controls.Add(this.models);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.contactLbl);
            this.Controls.Add(this.makeLbl);
            this.Controls.Add(this.makes);
            this.Controls.Add(this.CustomerTxt);
            this.Controls.Add(this.orderLbl);
            this.Name = "Order";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderLbl;
        private System.Windows.Forms.TextBox CustomerTxt;
        private System.Windows.Forms.ComboBox makes;
        private System.Windows.Forms.Label makeLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label contactLbl;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirmShipping;
        private System.Windows.Forms.Label colorLbl;
        private System.Windows.Forms.ComboBox colors;
        private System.Windows.Forms.Button btnDropOrd;
        private System.Windows.Forms.ComboBox models;
        private System.Windows.Forms.Label modelLbl;
    }
}