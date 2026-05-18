using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Av3DesenvApp
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
             
            frmFornecedores telaFornecedores = new frmFornecedores();

             
            telaFornecedores.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
             
            frmProdutos telaProdutos = new frmProdutos();

             
            telaProdutos.ShowDialog();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    }
}
