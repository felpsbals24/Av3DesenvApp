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
using MySql.Data.MySqlClient;  

namespace Av3DesenvApp
{
    public partial class Form1 : Form
    {
         
        private string strConexao = "Server=localhost;Database=gerenciadorqkz;Uid=root;Pwd=1234;";
        private MySqlConnection conexao;

        
        public Form1()
        {
            InitializeComponent();
        }

         
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

        
        public void Desconectar()
        {
            if (conexao != null && conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

         
        
            
        }
    }
