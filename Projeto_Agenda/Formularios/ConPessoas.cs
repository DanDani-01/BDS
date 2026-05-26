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
    public partial class ConPessoas : Form
    {
        public ConPessoas()
        {
            InitializeComponent();
        }

        private void ConPessoas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.Pessoa_M'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoa_MTableAdapter.Fill(this.dataSet_Agenda.Pessoa_M);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
