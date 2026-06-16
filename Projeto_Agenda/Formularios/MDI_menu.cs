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
            foreach (Form formAberto in this.MdiChildren)
            {
                if (formAberto is FrmCadPessoas)
                {
                    formAberto.Activate();
                    return;
                }
            }

            FrmCadPessoas novoForm = new FrmCadPessoas
            {
                MdiParent = this
            };
            novoForm.Show();
        }
       
        private void formulariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pessoasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            foreach (Form formAberto in this.MdiChildren)
            {
                if (formAberto is ConPessoas)
                {
                    formAberto.Activate();
                    return;
                }
            }

            ConPessoas novoForm = new ConPessoas
            {
                MdiParent = this
            };
            novoForm.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MDI_menu_Load(object sender, EventArgs e)
        {

        }

        private void pessoasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
