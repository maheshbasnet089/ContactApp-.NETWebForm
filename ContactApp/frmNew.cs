using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactApp
{
    public partial class newcontact : Form
    {
        public newcontact()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void newcontact_Load(object sender, EventArgs e)
        {
            List<AddressList> list = DataLayer.GetAddressList();
            address.DataSource = list;
            address.DisplayMember = "addressName";
            address.ValueMember = "addressId";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void address_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
