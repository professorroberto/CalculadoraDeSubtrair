using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraDeSubtrair
{
    public partial class frmSubtracao : Form
    {
        public frmSubtracao()
        {
            InitializeComponent();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {

            lblRes.Text = Convert.ToString(int.Parse(txtNum1.Text) - int.Parse(txtNum2.Text));
        }

        private void frmSubtracao_Load(object sender, EventArgs e)
        {
            lblRes.Text = "";
        }
    }
}
