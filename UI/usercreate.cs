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
using OOPPROJECT1;
using BLL;

namespace UI
{
    public partial class usercreate : Form
    {
        public usercreate()
        {
            InitializeComponent();
        }

        //this is the method to create
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next();
            Product prod = new Product(num, textBox1.Text, double.Parse(textBox2.Text));
            ProductBLL prodBLL = new ProductBLL();
            try
            {
                prodBLL.Create(prod);
                MessageBox.Show("You created a new Product! " + prod.ToString());
            }
            catch (ProdAlreadyExistsException exc)
            {
                MessageBox.Show("Error! " + exc.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
