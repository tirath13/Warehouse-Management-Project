using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order frm = new Order();
            frm.Show();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            Inventory frm = new Inventory();
            frm.Show();
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            Shipping frm = new Shipping();
            frm.Show();
        }
    }
}
