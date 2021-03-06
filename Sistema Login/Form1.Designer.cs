
namespace Sistema_Login
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
            this.boasvindas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boasvindas
            // 
            this.boasvindas.Enabled = false;
            this.boasvindas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boasvindas.Location = new System.Drawing.Point(45, 68);
            this.boasvindas.Name = "boasvindas";
            this.boasvindas.Size = new System.Drawing.Size(275, 125);
            this.boasvindas.TabIndex = 0;
            this.boasvindas.Text = "Tela Inicial";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 295);
            this.Controls.Add(this.boasvindas);
            this.Name = "Form1";
            this.Text = "Incio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label boasvindas;
    }
}

