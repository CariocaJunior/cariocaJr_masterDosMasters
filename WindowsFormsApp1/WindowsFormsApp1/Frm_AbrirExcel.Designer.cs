
namespace WindowsFormsApp1
{
    partial class Frm_AbrirExcel
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
            this.cboBusca = new System.Windows.Forms.ComboBox();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnExibirTodos = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txtArquivoExcel = new System.Windows.Forms.TextBox();
            this.btnLocalizarArquivoExcel = new System.Windows.Forms.Button();
            this.btnImportaExcel = new System.Windows.Forms.Button();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.lblRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // cboBusca
            // 
            this.cboBusca.FormattingEnabled = true;
            this.cboBusca.Location = new System.Drawing.Point(90, 66);
            this.cboBusca.Name = "cboBusca";
            this.cboBusca.Size = new System.Drawing.Size(121, 24);
            this.cboBusca.TabIndex = 0;
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(318, 68);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(100, 22);
            this.txtCriterio.TabIndex = 1;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(9, 66);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 2;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // btnExibirTodos
            // 
            this.btnExibirTodos.Location = new System.Drawing.Point(559, 68);
            this.btnExibirTodos.Name = "btnExibirTodos";
            this.btnExibirTodos.Size = new System.Drawing.Size(107, 23);
            this.btnExibirTodos.TabIndex = 3;
            this.btnExibirTodos.Text = "ExibirTodos";
            this.btnExibirTodos.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(4, 122);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowHeadersWidth = 51;
            this.dgvDados.RowTemplate.Height = 24;
            this.dgvDados.Size = new System.Drawing.Size(662, 254);
            this.dgvDados.TabIndex = 4;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            // 
            // txtArquivoExcel
            // 
            this.txtArquivoExcel.Location = new System.Drawing.Point(41, 382);
            this.txtArquivoExcel.Name = "txtArquivoExcel";
            this.txtArquivoExcel.Size = new System.Drawing.Size(100, 22);
            this.txtArquivoExcel.TabIndex = 5;
            // 
            // btnLocalizarArquivoExcel
            // 
            this.btnLocalizarArquivoExcel.Location = new System.Drawing.Point(454, 68);
            this.btnLocalizarArquivoExcel.Name = "btnLocalizarArquivoExcel";
            this.btnLocalizarArquivoExcel.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizarArquivoExcel.TabIndex = 6;
            this.btnLocalizarArquivoExcel.Text = "Localizar";
            this.btnLocalizarArquivoExcel.UseVisualStyleBackColor = true;
            // 
            // btnImportaExcel
            // 
            this.btnImportaExcel.Location = new System.Drawing.Point(174, 382);
            this.btnImportaExcel.Name = "btnImportaExcel";
            this.btnImportaExcel.Size = new System.Drawing.Size(113, 23);
            this.btnImportaExcel.TabIndex = 7;
            this.btnImportaExcel.Text = "Importa Excel";
            this.btnImportaExcel.UseVisualStyleBackColor = true;
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Location = new System.Drawing.Point(510, 398);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(65, 17);
            this.lblRegistros.TabIndex = 8;
            this.lblRegistros.Text = "Registro ";
            // 
            // Frm_AbrirExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.btnImportaExcel);
            this.Controls.Add(this.btnLocalizarArquivoExcel);
            this.Controls.Add(this.txtArquivoExcel);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnExibirTodos);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtCriterio);
            this.Controls.Add(this.cboBusca);
            this.Name = "Frm_AbrirExcel";
            this.Text = "Abrir Excel";
            this.Load += new System.EventHandler(this.Frm_AbrirExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBusca;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnExibirTodos;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TextBox txtArquivoExcel;
        private System.Windows.Forms.Button btnLocalizarArquivoExcel;
        private System.Windows.Forms.Button btnImportaExcel;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.Label lblRegistros;
    }
}