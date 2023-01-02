using DAL;
using OOPPROJECT1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class userupdate : Form
    {
        public userupdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product prod = new Product(int.Parse(textBox1.Text), textBox2.Text, double.Parse(textBox3.Text));
            ProductDAL prodDAL = new ProductDAL();
            prodDAL.Update(prod);
            MessageBox.Show("You updated the Product! Update: " + prod.ToString());
        }
    }
}
