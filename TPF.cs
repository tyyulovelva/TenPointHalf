using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Poker;

namespace TenPointHalf
{
    public partial class TPF : Form
    {
        private Poker cards = new Poker();
        public TPF()
        {
            InitializeComponent();
        }

        private void frmTPF_Load(object sender, EventArgs e)
        {

        }
    }
}
