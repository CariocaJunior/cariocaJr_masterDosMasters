
namespace ProcessosEmAndamentoPorDiretoria
{
    partial class Frm_ProcessosPorDiretoria
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtb_metricas = new System.Windows.Forms.RichTextBox();
            this.Btn_marketing = new System.Windows.Forms.Button();
            this.Btn_administracao = new System.Windows.Forms.Button();
            this.Btn_tecnologia = new System.Windows.Forms.Button();
            this.Btn_finalizados = new System.Windows.Forms.Button();
            this.Btn_processosparados = new System.Windows.Forms.Button();
            this.Btn_processosemaberto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_metricas
            // 
            this.rtb_metricas.Location = new System.Drawing.Point(82, 89);
            this.rtb_metricas.Name = "rtb_metricas";
            this.rtb_metricas.Size = new System.Drawing.Size(354, 127);
            this.rtb_metricas.TabIndex = 7;
            this.rtb_metricas.Text = "";
            // 
            // Btn_marketing
            // 
            this.Btn_marketing.Location = new System.Drawing.Point(325, 226);
            this.Btn_marketing.Name = "Btn_marketing";
            this.Btn_marketing.Size = new System.Drawing.Size(75, 23);
            this.Btn_marketing.TabIndex = 6;
            this.Btn_marketing.Text = "Marketing";
            this.Btn_marketing.UseVisualStyleBackColor = true;
            // 
            // Btn_administracao
            // 
            this.Btn_administracao.Location = new System.Drawing.Point(210, 225);
            this.Btn_administracao.Name = "Btn_administracao";
            this.Btn_administracao.Size = new System.Drawing.Size(81, 23);
            this.Btn_administracao.TabIndex = 5;
            this.Btn_administracao.Text = "Administração";
            this.Btn_administracao.UseVisualStyleBackColor = true;
            // 
            // Btn_tecnologia
            // 
            this.Btn_tecnologia.Location = new System.Drawing.Point(92, 225);
            this.Btn_tecnologia.Name = "Btn_tecnologia";
            this.Btn_tecnologia.Size = new System.Drawing.Size(75, 23);
            this.Btn_tecnologia.TabIndex = 4;
            this.Btn_tecnologia.Text = "Tecnologia";
            this.Btn_tecnologia.UseVisualStyleBackColor = true;
            // 
            // Btn_finalizados
            // 
            this.Btn_finalizados.Location = new System.Drawing.Point(311, 41);
            this.Btn_finalizados.Name = "Btn_finalizados";
            this.Btn_finalizados.Size = new System.Drawing.Size(124, 23);
            this.Btn_finalizados.TabIndex = 16;
            this.Btn_finalizados.Text = "Processos finalizados";
            this.Btn_finalizados.UseVisualStyleBackColor = true;
            // 
            // Btn_processosparados
            // 
            this.Btn_processosparados.Location = new System.Drawing.Point(196, 40);
            this.Btn_processosparados.Name = "Btn_processosparados";
            this.Btn_processosparados.Size = new System.Drawing.Size(109, 23);
            this.Btn_processosparados.TabIndex = 15;
            this.Btn_processosparados.Text = "Processos parados";
            this.Btn_processosparados.UseVisualStyleBackColor = true;
            // 
            // Btn_processosemaberto
            // 
            this.Btn_processosemaberto.Location = new System.Drawing.Point(50, 40);
            this.Btn_processosemaberto.Name = "Btn_processosemaberto";
            this.Btn_processosemaberto.Size = new System.Drawing.Size(140, 23);
            this.Btn_processosemaberto.TabIndex = 14;
            this.Btn_processosemaberto.Text = "Processos em aberto";
            this.Btn_processosemaberto.UseVisualStyleBackColor = true;
            // 
            // Frm_ProcessosPorDiretoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 261);
            this.Controls.Add(this.Btn_finalizados);
            this.Controls.Add(this.Btn_processosparados);
            this.Controls.Add(this.Btn_processosemaberto);
            this.Controls.Add(this.rtb_metricas);
            this.Controls.Add(this.Btn_marketing);
            this.Controls.Add(this.Btn_administracao);
            this.Controls.Add(this.Btn_tecnologia);
            this.Name = "Frm_ProcessosPorDiretoria";
            this.Text = "Tela Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_metricas;
        private System.Windows.Forms.Button Btn_marketing;
        private System.Windows.Forms.Button Btn_administracao;
        private System.Windows.Forms.Button Btn_tecnologia;
        private System.Windows.Forms.Button Btn_finalizados;
        private System.Windows.Forms.Button Btn_processosparados;
        private System.Windows.Forms.Button Btn_processosemaberto;
    }
}
