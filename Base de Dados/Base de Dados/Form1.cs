using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlServerCe;

namespace Base_de_Dados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf"; // caminho do BD
            string strConnection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeEngine db = new SqlCeEngine(strConnection);
            

            if (!File.Exists(baseDados))
            {
                db.CreateDatabase();
            }

            db.Dispose();

            SqlCeConnection conexao = new SqlCeConnection(strConnection);

            try
            {
                conexao.Open();
                resultado.Text = "Banco de Dados Conectado";
            }
            catch (Exception ex)
            {

                resultado.Text = "ERRO, não conectado! \n" + ex;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf"; // caminho do BD
            string strConnection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeConnection conexao = new SqlCeConnection(strConnection);

            try
            {
                conexao.Open();
                
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;
                comando.CommandText = "CREATE TABLE pessoas (id INT NOT NULL PRIMARY KEY, nome NVARCHAR (50), email NVARCHAR(50))";
                comando.ExecuteNonQuery();
                
                resultado.Text = "Tabela Criada com Sucesso!";
                comando.Dispose();
                
            }
            catch (Exception ex)
            {

                resultado.Text = "ERRO! " + ex.Message;
            }
            finally
            {
                conexao.Close();
            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf"; // caminho do BD
            string strConnection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeConnection conexao = new SqlCeConnection(strConnection);

            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = new Random(DateTime.Now.Millisecond).Next(0, 100);
                string nome = txtNome.Text;
                string email = txtEmail.Text;

                comando.CommandText = "INSERT INTO pessoas VALUES ("+ id +", '"+ nome + "', '"+ email + "')";
                comando.ExecuteNonQuery();

                resultado.Text = "Registro Inserido!";
                comando.Dispose();

            }
            catch (Exception ex)
            {

                resultado.Text = "ERRO! " + ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            resultado.Text = "";
            lista.Rows.Clear();
            
            
            string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf"; // caminho do BD
            string strConnection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeConnection conexao = new SqlCeConnection(strConnection);

            try
            {
                string query = "SELECT * FROM pessoas";

                if (txtNome.Text != "")
                {
                    query = "SELECT * FROM pessoas WHERE nome LIKE '" + txtNome.Text + "'";
                }

                DataTable dados = new DataTable();

                SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query, strConnection); // Serve para o preenchimento da tabela

                conexao.Open();

                adaptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    lista.Rows.Add(linha.ItemArray);
                }


            }
            catch (Exception ex)
            {

                lista.Rows.Clear();
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf"; // caminho do BD
            string strConnection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeConnection conexao = new SqlCeConnection(strConnection);

            int id = (int)lista.SelectedRows[0].Cells[0].Value;

            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                comando.CommandText = "DELETE from pessoas WHERE id = '"+ id + "'";
                comando.ExecuteNonQuery();

                resultado.Text = "Registro Deletado!";
                comando.Dispose();

            }
            catch (Exception ex)
            {

                resultado.Text = "ERRO! " + ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf"; // caminho do BD
            string strConnection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeConnection conexao = new SqlCeConnection(strConnection);

            

            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;
                
                int id = (int)lista.SelectedRows[0].Cells[0].Value;
                string nome = txtNome.Text;
                string email = txtEmail.Text;

                string query = "UPDATE pessoas SET nome = '" +nome+ "', email = '" +email+ "' WHERE id LIKE '" +id+ "'";

                comando.CommandText = query;
                comando.ExecuteNonQuery();

                resultado.Text = "Registro Alterado!";
                comando.Dispose();

            }
            catch (Exception ex)
            {

                resultado.Text = "ERRO! " + ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}


