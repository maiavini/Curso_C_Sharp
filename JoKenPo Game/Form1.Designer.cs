
namespace Jokenpo_Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btntesoura = new System.Windows.Forms.Button();
            this.btnpapel = new System.Windows.Forms.Button();
            this.btnpedra = new System.Windows.Forms.Button();
            this.Pic_Resultado = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Resultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha Pedra, Papel ou Tesoura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(76, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "você";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.ForeColor = System.Drawing.Color.Blue;
            this.labelResultado.Location = new System.Drawing.Point(604, 167);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(25, 29);
            this.labelResultado.TabIndex = 5;
            this.labelResultado.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(474, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(218, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "VS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(345, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "PC";
            // 
            // btntesoura
            // 
            this.btntesoura.Image = global::Jokenpo_Game.Properties.Resources.Tesoura;
            this.btntesoura.Location = new System.Drawing.Point(512, 336);
            this.btntesoura.Name = "btntesoura";
            this.btntesoura.Size = new System.Drawing.Size(200, 200);
            this.btntesoura.TabIndex = 11;
            this.btntesoura.UseVisualStyleBackColor = true;
            this.btntesoura.Click += new System.EventHandler(this.btntesoura_Click);
            // 
            // btnpapel
            // 
            this.btnpapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpapel.Image = global::Jokenpo_Game.Properties.Resources.Papel;
            this.btnpapel.Location = new System.Drawing.Point(268, 336);
            this.btnpapel.Name = "btnpapel";
            this.btnpapel.Size = new System.Drawing.Size(200, 200);
            this.btnpapel.TabIndex = 10;
            this.btnpapel.UseVisualStyleBackColor = true;
            this.btnpapel.Click += new System.EventHandler(this.btnpapel_Click);
            // 
            // btnpedra
            // 
            this.btnpedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpedra.Image = global::Jokenpo_Game.Properties.Resources.Pedra;
            this.btnpedra.Location = new System.Drawing.Point(12, 336);
            this.btnpedra.Name = "btnpedra";
            this.btnpedra.Size = new System.Drawing.Size(200, 200);
            this.btnpedra.TabIndex = 9;
            this.btnpedra.UseVisualStyleBackColor = true;
            this.btnpedra.Click += new System.EventHandler(this.btnpedra_Click);
            // 
            // Pic_Resultado
            // 
            this.Pic_Resultado.Location = new System.Drawing.Point(512, 116);
            this.Pic_Resultado.Name = "Pic_Resultado";
            this.Pic_Resultado.Size = new System.Drawing.Size(200, 200);
            this.Pic_Resultado.TabIndex = 3;
            this.Pic_Resultado.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(268, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 658);
            this.Controls.Add(this.btntesoura);
            this.Controls.Add(this.btnpapel);
            this.Controls.Add(this.btnpedra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Pic_Resultado);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Resultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox Pic_Resultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnpedra;
        private System.Windows.Forms.Button btnpapel;
        private System.Windows.Forms.Button btntesoura;
    }
}

