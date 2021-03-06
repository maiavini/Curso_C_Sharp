
namespace Classe_Estruturas_Importantes
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
            this.lblresultado = new System.Windows.Forms.Label();
            this.MessBox = new System.Windows.Forms.Button();
            this.btnaleatorio = new System.Windows.Forms.Button();
            this.btnTimeSpan = new System.Windows.Forms.Button();
            this.btnDTime = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnEnv = new System.Windows.Forms.Button();
            this.btnApl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblresultado
            // 
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(30, 27);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(367, 114);
            this.lblresultado.TabIndex = 1;
            this.lblresultado.Text = "label1";
            // 
            // MessBox
            // 
            this.MessBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessBox.Location = new System.Drawing.Point(30, 265);
            this.MessBox.Name = "MessBox";
            this.MessBox.Size = new System.Drawing.Size(102, 50);
            this.MessBox.TabIndex = 0;
            this.MessBox.Text = "Message Box";
            this.MessBox.UseVisualStyleBackColor = true;
            this.MessBox.Click += new System.EventHandler(this.MessBox_Click);
            // 
            // btnaleatorio
            // 
            this.btnaleatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaleatorio.Location = new System.Drawing.Point(148, 265);
            this.btnaleatorio.Name = "btnaleatorio";
            this.btnaleatorio.Size = new System.Drawing.Size(102, 50);
            this.btnaleatorio.TabIndex = 2;
            this.btnaleatorio.Text = "Aleatorio";
            this.btnaleatorio.UseVisualStyleBackColor = true;
            this.btnaleatorio.Click += new System.EventHandler(this.btnaleatorio_Click);
            // 
            // btnTimeSpan
            // 
            this.btnTimeSpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeSpan.Location = new System.Drawing.Point(271, 265);
            this.btnTimeSpan.Name = "btnTimeSpan";
            this.btnTimeSpan.Size = new System.Drawing.Size(102, 50);
            this.btnTimeSpan.TabIndex = 3;
            this.btnTimeSpan.Text = "Time Span";
            this.btnTimeSpan.UseVisualStyleBackColor = true;
            this.btnTimeSpan.Click += new System.EventHandler(this.btnTimeSpan_Click);
            // 
            // btnDTime
            // 
            this.btnDTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDTime.Location = new System.Drawing.Point(388, 265);
            this.btnDTime.Name = "btnDTime";
            this.btnDTime.Size = new System.Drawing.Size(102, 50);
            this.btnDTime.TabIndex = 4;
            this.btnDTime.Text = "Date Time";
            this.btnDTime.UseVisualStyleBackColor = true;
            this.btnDTime.Click += new System.EventHandler(this.btnDTime_Click);
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(30, 340);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(102, 50);
            this.btnColor.TabIndex = 5;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFont
            // 
            this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFont.Location = new System.Drawing.Point(148, 340);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(102, 50);
            this.btnFont.TabIndex = 6;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnEnv
            // 
            this.btnEnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnv.Location = new System.Drawing.Point(271, 340);
            this.btnEnv.Name = "btnEnv";
            this.btnEnv.Size = new System.Drawing.Size(102, 50);
            this.btnEnv.TabIndex = 7;
            this.btnEnv.Text = "Enviroment";
            this.btnEnv.UseVisualStyleBackColor = true;
            this.btnEnv.Click += new System.EventHandler(this.btnEnv_Click);
            // 
            // btnApl
            // 
            this.btnApl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApl.Location = new System.Drawing.Point(388, 340);
            this.btnApl.Name = "btnApl";
            this.btnApl.Size = new System.Drawing.Size(102, 50);
            this.btnApl.TabIndex = 8;
            this.btnApl.Text = "Aplication";
            this.btnApl.UseVisualStyleBackColor = true;
            this.btnApl.Click += new System.EventHandler(this.btnApl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 402);
            this.Controls.Add(this.btnApl);
            this.Controls.Add(this.btnEnv);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnDTime);
            this.Controls.Add(this.btnTimeSpan);
            this.Controls.Add(this.btnaleatorio);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.MessBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button MessBox;
        private System.Windows.Forms.Button btnaleatorio;
        private System.Windows.Forms.Button btnTimeSpan;
        private System.Windows.Forms.Button btnDTime;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnEnv;
        private System.Windows.Forms.Button btnApl;
    }
}

