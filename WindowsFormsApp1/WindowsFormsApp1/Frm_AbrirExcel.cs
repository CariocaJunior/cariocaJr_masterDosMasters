using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class Frm_AbrirExcel : Form
    {
        string arquivoExcel = @"C:\P\ProjetoCariocaJr\Sistema-de-Gestao\WindowsFormsApp1\Documentação\Tabelas[Distribuição e precificação]Daniela.xlsx";
        public Frm_AbrirExcel()
        {
            InitializeComponent();
        }

        private void Frm_AbrirExcel_Load(object sender, EventArgs e)
        {

        }
        private void CarregaDadosExcel()
        {
            try
            {
                //limpa o combobox
                cboBusca.Items.Clear();
                //converte os dados do Excel para um DataTable
                DataTable dt = GetTabelaExcel(arquivoExcel);
                //ajusta a largura das colunas aos dados
                dgvDados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvDados.DataSource = dt;
                //No total de registros
                lblRegistros.Text = (dgvDados.Rows.Count - 1).ToString();
                string[] listaNomeColunas = dt.Columns.OfType<DataColumn>().Select(x => x.ColumnName).ToArray();

                //Adiciona os nomes das colunas no Combobox
                cboBusca.Items.AddRange(listaNomeColunas);
                if (cboBusca.Items.Count > 0)
                    cboBusca.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
        }
        private DataTable GetTabelaExcel(string arquivoExcel)
        {
            DataTable dt = new DataTable();
            try
            {
                //pega a extensão do arquivo
                string Ext = Path.GetExtension(arquivoExcel);
                string connectionString = "";
                //verifica a versão do Excel pela extensão
                if (Ext == ".xls")
                { //para o  Excel 97-03    
                    connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source =" + arquivoExcel + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                else if (Ext == ".xlsx")
                { //para o  Excel 07 e superior
                    connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + arquivoExcel + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                OleDbConnection conn = new OleDbConnection(connectionString);
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
                cmd.Connection = conn;
                conn.Open();
                DataTable dtSchema;
                dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string nomePlanilha = dtSchema.Rows[0]["TABLE_NAME"].ToString();
                conn.Close();
                //le todos os dados da planilha para o Data Table    
                conn.Open();
                cmd.CommandText = "SELECT * From [" + nomePlanilha + "]";
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        private void btnLocalizaArquivoExcel_Click(object sender, EventArgs e)
        {
            DialogResult drResult = ofd1.ShowDialog();

            if (drResult == System.Windows.Forms.DialogResult.OK)
                txtArquivoExcel.Text = ofd1.FileName;
        }

        private void btnImportaExcel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtArquivoExcel.Text) && File.Exists(txtArquivoExcel.Text))
            {
                arquivoExcel = txtArquivoExcel.Text;
                CarregaDadosExcel();
            }
            else
            {
                CarregaDadosExcel();
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dgvDados.DataSource).DefaultView.RowFilter = string.Format("" + cboBusca.Text + " like '%{0}%'", txtCriterio.Text.Trim().Replace("'", "''"));
                lblRegistros.Text = (dgvDados.Rows.Count - 1).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :" + ex.Message);
            }
        }

        private void btnExibirTodos_Click(object sender, EventArgs e)
        {
            CarregaDadosExcel();
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
