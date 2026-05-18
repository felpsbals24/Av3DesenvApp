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
            
            string usuarioDigitado = txtUsuario.Text;
            string senhaDigitada = txtSenha.Text;

            )
            if (usuarioDigitado == "admin" && senhaDigitada == "1234")
            {
                

            
                Form1 telaPrincipal = new Form1();
                telaPrincipal.Show();

            
                this.Hide();
            }
            else
            {
               
                MessageBox.Show("Usuário ou senha incorretos!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Clear(); 
                txtUsuario.Focus(); 
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
