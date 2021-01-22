namespace WindowsFormsApp1.Vector
{
    partial class Frm_Marketing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_finalizados = new System.Windows.Forms.Button();
            this.Btn_processosparados = new System.Windows.Forms.Button();
            this.Btn_processosemaberto = new System.Windows.Forms.Button();
            this.rtb_metricas = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Btn_finalizados
            // 
            this.Btn_finalizados.Location = new System.Drawing.Point(327, 31);
            this.Btn_finalizados.Name = "Btn_finalizados";
            this.Btn_finalizados.Size = new System.Drawing.Size(124, 23);
            this.Btn_finalizados.TabIndex = 20;
            this.Btn_finalizados.Text = "Processos finalizados";
            this.Btn_finalizados.UseVisualStyleBackColor = true;
            // 
            // Btn_processosparados
            // 
            this.Btn_processosparados.Location = new System.Drawing.Point(212, 30);
            this.Btn_processosparados.Name = "Btn_processosparados";
            this.Btn_processosparados.Size = new System.Drawing.Size(109, 23);
            this.Btn_processosparados.TabIndex = 19;
            this.Btn_processosparados.Text = "Processos parados";
            this.Btn_processosparados.UseVisualStyleBackColor = true;
            // 
            // Btn_processosemaberto
            // 
            this.Btn_processosemaberto.Location = new System.Drawing.Point(66, 30);
            this.Btn_processosemaberto.Name = "Btn_processosemaberto";
            this.Btn_processosemaberto.Size = new System.Drawing.Size(140, 23);
            this.Btn_processosemaberto.TabIndex = 18;
            this.Btn_processosemaberto.Text = "Processos em aberto";
            this.Btn_processosemaberto.UseVisualStyleBackColor = true;
            // 
            // rtb_metricas
            // 
            this.rtb_metricas.Location = new System.Drawing.Point(98, 79);
            this.rtb_metricas.Name = "rtb_metricas";
            this.rtb_metricas.Size = new System.Drawing.Size(354, 127);
            this.rtb_metricas.TabIndex = 17;
            this.rtb_metricas.Text = "";
            // 
            // Frm_Marketing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 237);
            this.Controls.Add(this.Btn_finalizados);
            this.Controls.Add(this.Btn_processosparados);
            this.Controls.Add(this.Btn_processosemaberto);
            this.Controls.Add(this.rtb_metricas);
            this.Name = "Frm_Marketing";
            this.Text = "Frm_Marketing";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_finalizados;
        private System.Windows.Forms.Button Btn_processosparados;
        private System.Windows.Forms.Button Btn_processosemaberto;
        private System.Windows.Forms.RichTextBox rtb_metricas;
    }
}