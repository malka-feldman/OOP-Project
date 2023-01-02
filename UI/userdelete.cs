using DAL;
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
    public partial class userdelete : Form
    {
        public userdelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductDAL prodDAL = new ProductDAL();
            prodDAL.Delete(int.Parse(textBox1.Text));
            MessageBox.Show("You successfully deleted the product");
        }
    }
}
