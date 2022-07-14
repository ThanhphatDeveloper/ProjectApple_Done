using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace Project_Apple
{
    public partial class User_DX : UserControl
    {
        public User_DX()
        {
            InitializeComponent();
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    }
}
