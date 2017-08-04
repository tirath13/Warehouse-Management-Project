namespace WarehouseManagement
{
    partial class Inventory
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
            this.makeLbl = new System.Windows.Forms.Label();
            this.SearchMake = new System.Windows.Forms.ComboBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.Searchtype = new System.Windows.Forms.ComboBox();
            this.colorLbl = new System.Windows.Forms.Label();
            this.SearchColor = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // makeLbl
            // 
            this.makeLbl.AutoSize = true;
            this.makeLbl.Location = new System.Drawing.Point(52, 72);
            this.makeLbl.Name = "makeLbl";
            this.makeLbl.Size = new System.Drawing.Size(86, 13);
            this.makeLbl.TabIndex = 11;
            this.makeLbl.Text = "Search By Make";
            // 
            // SearchMake
            // 
            this.SearchMake.FormattingEnabled = true;
            this.SearchMake.Items.AddRange(new object[] {
            "Any",
            "Acura",
            "Audi",
            "BMW",
            "Ford",
            "Mercedes",
            "Land Rover",
            "Tesla"});
            this.SearchMake.Location = new System.Drawing.Point(181, 64);
            this.SearchMake.Name = "SearchMake";
            this.SearchMake.Size = new System.Drawing.Size(121, 21);
            this.SearchMake.TabIndex = 10;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(52, 31);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(83, 13);
            this.typeLbl.TabIndex = 9;
            this.typeLbl.Text = "Search By Type";
            // 
            // Searchtype
            // 
            this.Searchtype.FormattingEnabled = true;
            this.Searchtype.Items.AddRange(new object[] {
            "Any",
            "SUV",
            "Sedan",
            "Crossover",
            "Hatchback"});
            this.Searchtype.Location = new System.Drawing.Point(181, 23);
            this.Searchtype.Name = "Searchtype";
            this.Searchtype.Size = new System.Drawing.Size(121, 21);
            this.Searchtype.TabIndex = 8;
            // 
            // colorLbl
            // 
            this.colorLbl.AutoSize = true;
            this.colorLbl.Location = new System.Drawing.Point(52, 115);
            this.colorLbl.Name = "colorLbl";
            this.colorLbl.Size = new System.Drawing.Size(83, 13);
            this.colorLbl.TabIndex = 13;
            this.colorLbl.Text = "Search By Color";
            // 
            // SearchColor
            // 
            this.SearchColor.FormattingEnabled = true;
            this.SearchColor.Items.AddRange(new object[] {
            "Any",
            "Black",
            "Blue",
            "Brown",
            "Grey",
            "Pearl White",
            "White"});
            this.SearchColor.Location = new System.Drawing.Point(181, 107);
            this.SearchColor.Name = "SearchColor";
            this.SearchColor.Size = new System.Drawing.Size(121, 21);
            this.SearchColor.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(361, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(370, 418);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(118, 245);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 48);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(118, 337);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 48);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(743, 453);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.colorLbl);
            this.Controls.Add(this.SearchColor);
            this.Controls.Add(this.makeLbl);
            this.Controls.Add(this.SearchMake);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.Searchtype);
            this.Name = "Inventory";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label makeLbl;
        private System.Windows.Forms.ComboBox SearchMake;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.ComboBox Searchtype;
        private System.Windows.Forms.Label colorLbl;
        private System.Windows.Forms.ComboBox SearchColor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
    }
}