using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tratamento_de_Erros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] num = { 10, 20, 30, 40, 50};

            try
            {
                string res = "";

                for (int i = 0; i < 15; i++)
                {
                    res += num[i] + " ";
                }
                label1.Text = res;
            }
            catch (Exception ex) //EXIBE O ERRO NATIVO
            {
                label1.Text = "ERRO! " + ex.Message ; // EXIBE MENSSAGEM MAIS AMIGÁVEL
                //throw; FAZ COM QUE A APLICAÃO CONTINUE BLOQUEADA
            }
            finally //SEMPRE SERÁ EXECUTADO COM OU SEM ERRO
            {
                MessageBox.Show("Operação Finalizada");
            }
        }
    }
}
