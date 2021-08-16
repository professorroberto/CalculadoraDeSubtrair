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
            if (txtSub1.Text == "" || txtSub2.Text == "")
                MessageBox.Show("Favor, preencher todos os campos!");
            else
            {
                int N1 = int.Parse(txtSub1.Text);
                int N2 = int.Parse(txtSub2.Text);

                int resultsub = N1 - N2;
                lblResultado.Text = resultsub.ToString();
            }
        }
    }
}
