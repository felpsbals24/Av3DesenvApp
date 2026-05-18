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
    public partial class fmrLogin : Form
    {
        public fmrLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // 1. Coleta o que o usuário digitou
            string usuarioDigitado = txtUsuario.Text;
            string senhaDigitada = txtSenha.Text;

            // 2. Validação ultra rápida (Usuário: admin | Senha: 1234)
            if (usuarioDigitado == "admin" && senhaDigitada == "1234")
            {
                

                // 4. Prepara a tela principal para abrir
                Form1 telaPrincipal = new Form1();
                telaPrincipal.Show();

                // 5. Esconde a tela de login atual
                this.Hide();
            }
            else
            {
                // 6. Se estiver errado, avisa o usuário e limpa as caixas para ele tentar de novo
                MessageBox.Show("Usuário ou senha incorretos!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Clear(); // Limpa apenas a senha para facilitar
                txtUsuario.Focus(); // Coloca o cursor de volta no campo de usuário
            }
        }
    }
}
