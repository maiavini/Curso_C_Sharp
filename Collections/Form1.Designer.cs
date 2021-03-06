
namespace Colections
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listbox = new System.Windows.Forms.ListBox();
            this.btnlist = new System.Windows.Forms.Button();
            this.hash = new System.Windows.Forms.Button();
            this.btnDic = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(12, 25);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(120, 368);
            this.listbox.TabIndex = 0;
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(138, 21);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(101, 41);
            this.btnlist.TabIndex = 1;
            this.btnlist.Text = "List";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click_1);
            // 
            // hash
            // 
            this.hash.Location = new System.Drawing.Point(138, 68);
            this.hash.Name = "hash";
            this.hash.Size = new System.Drawing.Size(101, 41);
            this.hash.TabIndex = 2;
            this.hash.Text = "HashSet";
            this.hash.UseVisualStyleBackColor = true;
            this.hash.Click += new System.EventHandler(this.hash_Click);
            // 
            // btnDic
            // 
            this.btnDic.Location = new System.Drawing.Point(138, 115);
            this.btnDic.Name = "btnDic";
            this.btnDic.Size = new System.Drawing.Size(101, 41);
            this.btnDic.TabIndex = 3;
            this.btnDic.Text = "Dictionary";
            this.btnDic.UseVisualStyleBackColor = true;
            this.btnDic.Click += new System.EventHandler(this.btnDic_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "SortedList";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "SortedDictionary";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 41);
            this.button3.TabIndex = 6;
            this.button3.Text = "SortedSet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(138, 305);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 41);
            this.button4.TabIndex = 7;
            this.button4.Text = "Queue";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(138, 352);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 41);
            this.button5.TabIndex = 8;
            this.button5.Text = "Stack";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(319, 423);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDic);
            this.Controls.Add(this.hash);
            this.Controls.Add(this.btnlist);
            this.Controls.Add(this.listbox);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button List;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Button hash;
        private System.Windows.Forms.Button btnDic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

