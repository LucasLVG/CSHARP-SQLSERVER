using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient; //PARA CRIAR CONEXÃO COM BANCO DE DADOS PRECISA DESSA USING


namespace CALCULADORA_POO
{
    public partial class Pagina_de_cadastro_do_cliente : Form
    {
    
        public Pagina_de_cadastro_do_cliente()
        {
            InitializeComponent();
            
        }

        private void Pagina_de_cadastro_do_cliente_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox_CPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CPF = textBox_CPF.Text;
            string Email = textBox_Email.Text;
            string Nome = textBox_Nome.Text;
            string Telefone = TextBox_Telefone.Text;
            

            //----------CONEXÃO SQL SERVER---------//
            string conexao = "Data Source=NOTEBOOK_LUCAS\\SQLEXPRESS;Initial Catalog=TABELA1;Integrated Security=True";
            string sql = "INSERT INTO pessoa (nome, data_nascimento, email, telefone, CPF) " +
                         "VALUES (@nome, @data_nascimento, @email, @telefone, @CPF)";

            using (SqlConnection conn = new SqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Conexão aberta com sucesso!");
                    
            using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@nome", Nome);
                        cmd.Parameters.AddWithValue("@email", Email);
                        cmd.Parameters.AddWithValue("@telefone", Telefone);
                        cmd.Parameters.AddWithValue("@CPF", CPF);
                        cmd.Parameters.AddWithValue("@data_nascimento", dateTimePicker1.Value);

                        cmd.ExecuteNonQuery();

                    }
                    Console.WriteLine("Registro inserido com sucesso!");
                    MessageBox.Show("DADOS INSERIDOS COM SUCESSO");


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao conectar: " + ex.Message);
                }
            }
            //--------FIM DA CONEXÃO SQL SERVER-----//
            Console.WriteLine(CPF);


        }
        
        private void Telefone_Click(object sender, EventArgs e)
        {

        }
    }
}
