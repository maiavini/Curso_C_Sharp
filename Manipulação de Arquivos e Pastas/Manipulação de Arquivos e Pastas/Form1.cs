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

namespace Manipulação_de_Arquivos_e_Pastas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //É UM CLASSE ESTATICA, PORTANTO NÃO VAMOS CRIAR OBJETOS

            string pasta = @"C:\Curso\ ";
            string arquivo = "teste.txt ";

            //bool res = File.Exists(pasta + arquivo);

            //label1.Text = res.ToString();

            //File.Delete(arquivo);

            //if (!File.Exists(arquivo))
            //{
            //    File.Create(pasta + arquivo).Close();
            //    label1.Text = ("Arquivo Criado");
            //}
            //else
            //{
            //    label1.Text = ("Arquivo existente!");
            //}

            //if (File.Exists(arquivo + pasta))
            //{
            //    File.Copy(pasta + arquivo, pasta + "Copia.txt");
            //    label1.Text =("Copiado");
            //}
            //else
            //{
            //    label1.Text = ("Arquivo Não Existe");
            //}

            //File.Move(pasta + arquivo, pasta + "destino\\" + arquivo);

            File.WriteAllText(pasta + arquivo, "Teste de escrita de arquivo", Encoding.UTF8);

            label1.Text = File.ReadAllText(pasta + arquivo, Encoding.UTF8);
        }
    
            
    
    }
}
