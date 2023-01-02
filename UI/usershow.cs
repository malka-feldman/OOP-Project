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
using DAL;
using BLL;
using Entities;


namespace UI
{
    public partial class usershow : Form
    {
        public usershow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductDAL prodDAL = new ProductDAL();
            button1.Text = prodDAL.printList();

        }
    }
}
