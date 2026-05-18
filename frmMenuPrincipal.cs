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
            // Criamos a janela de fornecedores
            frmFornecedores telaFornecedores = new frmFornecedores();

            // Abre a tela de forma que o usuário tenha que fechar ela antes de voltar para o menu
            telaFornecedores.ShowDialog();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            // Criamos a janela de produtos
            frmProdutos telaProdutos = new frmProdutos();

            // Abre a janela de produtos
            telaProdutos.ShowDialog();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            // Fecha completamente a aplicação de forma segura
            Application.Exit();
        }
    }
}
