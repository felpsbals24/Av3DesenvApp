using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Ferramenta essencial para o MySQL

namespace Av3DesenvApp
{
    public partial class Form1 : Form
    {
        // 1. Variáveis da conexão (Ajustadas e com o MySqlConnection correto)
        private string strConexao = "Server=localhost;Database=gerenciamento;Uid=root;Pwd=1234;";
        private MySqlConnection conexao;

        // 2. Método que é rodado assim que a tela é criada
        public Form1()
        {
            InitializeComponent();
        }

        // 3. Método responsável por abrir a porta com o Banco de Dados
        public MySqlConnection Conectar()
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();
                return conexao;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar: " + ex.Message);
                return null;
            }
        }

        // 4. Método responsável por fechar a porta com o Banco de Dados
        public void Desconectar()
        {
            if (conexao != null && conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        // 5. Espaço reservado para o botão da tela
        
            
        }
    }
