using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GiftBasket
{
    public partial class TetGiftBasket : Form
    {
        List<string> listITetGiftBasket;
        int index;
        public TetGiftBasket()
        {
            InitializeComponent();
            listITetGiftBasket = new List<string>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        List<string> listItem;
        private void cbITetGiftBasket_SelectedIndexChanged(object sender, EventArgs e)
        {
            listItem = new List<string>() { "Tet Gift Basket", "Warm Gift Basket", "Health Gift Basket" };
            cbITetGiftBasket.DataSource = listItem;
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbSnacks_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvGiftBasket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPriceSnacks_TextChanged(object sender, EventArgs e)
        {
            double Price;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvGiftBasket_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            cbNameSnacks.Text = listITetGiftBasket.Name;

        }
    }

    class GiftBasket
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public GiftBasket() 
        {
            Name = "sfaf";
            Price = 0;
            Amount = 0;

        }
    }
}
