using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
namespace WindowsFormsApp1.Tecnologia
{
    public partial class FRM_Tecnologia : Form
    {
        public FRM_Tecnologia()
        {
            InitializeComponent();
        }

        private void Btn_AbrirExcel_Click(object sender, EventArgs e)
        {
            Frm_AbrirExcel frm = new Frm_AbrirExcel();
            frm.Show(); 
        }
    }
}
