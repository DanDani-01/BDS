using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Agenda.Formularios
{
    public partial class MDI_menu : Form
    {
        public MDI_menu()
        {
            InitializeComponent();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadPessoas frmCadPessoas = new FrmCadPessoas();
            frmCadPessoas.MdiParent = this;
            frmCadPessoas.Show();

           
        }
       
        private void formulariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pessoasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConPessoas ConPessoas = new ConPessoas();
            ConPessoas.MdiParent = this;
            ConPessoas.Show();
        }
    }
}
