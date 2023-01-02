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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class userfind : Form
    {
        public userfind()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductDAL prodDAL = new ProductDAL();
            MessageBox.Show("You successfully retrieved the product: " + prodDAL.Retrieve(int.Parse(textBox1.Text)));
        }
    }
}
