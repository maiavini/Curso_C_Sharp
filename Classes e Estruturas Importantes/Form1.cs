using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_Estruturas_Importantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MessBox_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Menssagem de Texto", "Titulo da Menssagem");
            //MessageBox.Show("Menssagem de Texto", "Titulo da Menssagem", MessageBoxButtons.YesNo);

            //DialogResult res = MessageBox.Show("Menssagem de Texto", "Titulo da Menssagem", MessageBoxButtons.YesNoCancel);

            //if (res == DialogResult.Yes)
            //{
            //    lblresultado.Text = "Clicou em Yes";
            //} else if( res == DialogResult.No)
            //{
            //    lblresultado.Text = "Clicou em No";
            //}
            //else
            //{
            //    lblresultado.Text = "Clicou em Cancelar";
            //}

            MessageBox.Show("Menssagem de Texto", "Titulo da Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

        
        }

        private void btnaleatorio_Click(object sender, EventArgs e)
        {   
            //GERAM NUMEROS ALEATORIOS
            Random r = new Random(DateTime.Now.Millisecond);//Esse parametro serve para que possamos passar um padrão para a busca que é feita através de calculos

            int valor =  r.Next(100);
            double valor2 = r.NextDouble();

            lblresultado.Text = "Numero : " + valor2 + " Numero : " + valor;
        }

        private void btnTimeSpan_Click(object sender, EventArgs e)
        {
            //MOSTRA INTERVALOS DE TEMPO
            //lblresultado.Text = TimeSpan.FromMinutes(120).ToString();

            //lblresultado.Text = TimeSpan.FromDays(7.50).ToString();

            //lblresultado.Text = TimeSpan.FromTicks(100000).ToString();// Menor intervalo de tempo no Time Span

            TimeSpan inicio = new TimeSpan(3, 40, 0);

            TimeSpan fim = new TimeSpan(6, 50, 0);

            TimeSpan resposta = fim - inicio;

            lblresultado.Text = resposta.TotalHours.ToString();



        }

        private void btnDTime_Click(object sender, EventArgs e)
        {
            //Representa um determinado tempo no espaço

            //lblresultado.Text = DateTime.Now.;
            //lblresultado.Text = DateTime.Today.ToString();
            //lblresultado.Text = DateTime.DaysInMonth(2021,6).ToString();
            //lblresultado.Text = DateTime.IsLeapYear(2027).ToString();
            //lblresultado.Text = DateTime.Now.ToLongDateString();
            //lblresultado.Text = DateTime.Now.ToShortDateString();
            //lblresultado.Text = DateTime.Now.ToLongTimeString();
            //lblresultado.Text = DateTime.Now.ToShortTimeString();
            //lblresultado.Text = DateTime.Now.ToUniversalTime().ToString();
            //lblresultado.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss" );

            DateTime date = new DateTime(1985, 01, 10, 14, 35, 30);

            //lblresultado.Text = date.AddYears(2).ToString();

            //TimeSpan tempo = new TimeSpan(5, 10, 5, 20);
            //lblresultado.Text = date.Add(tempo).ToString();

            //lblresultado.Text = date.DayOfWeek.ToString();

            lblresultado.Text = date.DayOfYear.ToString();



        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Color azul = Color.Blue;
            Color branco = Color.White;

            //Color cor1 = Color.FromArgb(150, Color.Aquamarine);
            //Color cor2 = Color.FromArgb(215, 17, 56, 78);

            Color cor1 = Color.FromArgb(100, 50, 135);
            Color cor2 = Color.FromKnownColor(KnownColor.LimeGreen); //Cores conhecidas do sistema
            Color cor3 = Color.FromName("Orange");

            lblresultado.BackColor = cor3;
            lblresultado.ForeColor = cor2;

            Color cor4 = lblresultado.BackColor;

            btnColor.BackColor = cor4;
            btnColor.ForeColor = cor1;

        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            Font letra = new Font("Comic Sans MS", 15, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Pixel);

            Font letra2 = new Font(FontFamily.GenericMonospace, 28, FontStyle.Regular, GraphicsUnit.Pixel);
            lblresultado.Text = "Bem-Vindo a Portugal";

            lblresultado.Font = letra2;
        }

        private void btnEnv_Click(object sender, EventArgs e)
        {
            //AJUADA-NOS A TRABALHAR COM O SISTEMA (ENVIROMENT = AMBIENTE)

            string meusDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string dirAtual = Environment.CurrentDirectory;


            //lblresultado.Text = dirAtual + Environment.NewLine + meusDocs; //QUEBRA DE LINHA

            //string varAmb = Environment.GetEnvironmentVariable("Path");

            //lblresultado.Text = varAmb;

            //    string[] discos = Environment.GetLogicalDrives();

            //    foreach (string item in discos)
            //    {
            //        lblresultado.Text += Environment.NewLine + item  ;
            //    }
            //

            string user = Environment.UserName;
            string dominio = Environment.UserDomainName;

            lblresultado.Text = user + "    " + dominio;
        
        
        }

        private void btnApl_Click(object sender, EventArgs e)
        {
            //Application.Exit();

            //Application.Restart();

            string exec = Application.ExecutablePath;

            string pasta = Application.StartupPath;

            lblresultado.Text = exec + "   " + pasta;
        }
    }
}
