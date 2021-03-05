using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnlist_Click_1(object sender, EventArgs e)
        {

            

            string[] nomes2 = new string[3];
            {
                nomes2[0] = "Luciana";
                nomes2[1] = "Gicelio";
                nomes2[2] = "Leticia";
            }

            //listbox.Items.AddRange(nomes2);

            //MessageBox.Show(nomes2[2])

            List<string> nomes = new List<string>();

            nomes.Add("Vinicius");
            nomes.Add("Bry");
            nomes.Add("Luiza");
            nomes.Add("Pedro");

            nomes.Sort();

            foreach (string names in nomes)
            {
                listbox.Items.Add(names);           
            }

           





            

          




           

            
        }

        private void hash_Click(object sender, EventArgs e)
        {
            HashSet<string> veiculos = new HashSet<string>
            {
                "Carro", "Bike", "Moto", "Avião"
            };


            if (veiculos.Add("moto"))
            {
                MessageBox.Show("Item Adicionado");
            }
            else
            {
                MessageBox.Show("Item NÃO Adicionado");
            }

            foreach (string veic in veiculos)
            {
                listbox.Items.Add(veic);
            }





        }

        private void btnDic_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> moradores = new Dictionary<int, string> //é necessario uma chave e um valor
            {
                {100, "Vincius" }, 
                {200, "Rosana" },
                {300, "Antonio" }
            };

            //formas de se adicionar itens 

            moradores.Add(400, "Paulo");

            foreach (KeyValuePair<int,string> item in moradores) //é possivel mostrar somente a Key ou a Value
            {
                listbox.Items.Add(item.Key + " = " + item.Value);
            }

            MessageBox.Show("Primeiro morador - Apartamento " + moradores.First().Key + "Nome " + moradores.First().Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();
            
            SortedList<int, string> alunos = new SortedList<int, string>
            {
                {10, "Bruno" },
                {07, "Antonio" },
                {12, "Isaias" },
                {05, "Gael" }
            };

            alunos.Add(22, "Breno");

            alunos.Remove(07);
            alunos.RemoveAt(0);

            foreach (KeyValuePair<int, string> item in alunos)
            {
                listbox.Items.Add(item.Key + " " + item.Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SortedDictionary<string, string> alunos = new SortedDictionary<string, string>
            {
                {"hgf", "Roberto" },
                {"jdr", "Tobio" },
                {"uia", "Petros" }
            };

            alunos.Add("afs", "Flavio");

            foreach (KeyValuePair<string,string> item in alunos)
            {
                listbox.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SortedSet<string> nomes = new SortedSet<string>()
            {
                "Gabreil", "Rocha","Fresno","Kio","Tonio"
            };

            if (!nomes.Add("Lucas"))
            {
                MessageBox.Show("Nome já adicionado");
            }

            MessageBox.Show("Quantidade de itens: " + nomes.Count.ToString());

            foreach (string nome in nomes)
            {
                listbox.Items.Add(nome);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();

            Queue<string> fila = new Queue<string>();
            {
                fila.Enqueue("Gabriel");
                fila.Enqueue("Morais");
                fila.Enqueue("Kaio");

            };

            MessageBox.Show("Qauntidade " + fila.Count.ToString());

            foreach (string item in fila)
            {
                listbox.Items.Add(item);
            }

            //MessageBox.Show("O primeiro da fila é: " + fila.Peek());
            //MessageBox.Show("Qauntidade " + fila.Count.ToString());

            //MessageBox.Show("O primeiro da fila é: " + fila.Dequeue());
            //MessageBox.Show("Qauntidade " + fila.Count.ToString());

            

            while(fila.Count > 0)
            {
                MessageBox.Show("O primeiro da fila é: " + fila.Dequeue());
                MessageBox.Show("Qauntidade " + fila.Count.ToString());
                listbox.Items.Clear();

                foreach (string item in fila)
                {
                    listbox.Items.Add(item);
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listbox.Items.Clear();
            
            Stack<string> pilha = new Stack<string>();

            pilha.Push("Bruno");
            pilha.Push("Humberto");
            pilha.Push("Yuri");

            MessageBox.Show(pilha.Count.ToString());

            foreach (string item in pilha)
            {
                listbox.Items.Add(item);           
            }

            //MessageBox.Show("Elemento no topo " + pilha.Peek());
            //MessageBox.Show(pilha.Count.ToString());

            

            while(pilha.Count > 0)
            {

                MessageBox.Show("Elemento no topo " + pilha.Pop());
                MessageBox.Show(pilha.Count.ToString());
                listbox.Items.Clear();

                foreach (string item in pilha)
                {
                    listbox.Items.Add(item);
                }

            
            
            
            }


        }
    }
}
