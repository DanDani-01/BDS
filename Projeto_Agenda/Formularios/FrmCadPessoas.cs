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
    public partial class FrmCadPessoas : Form
    {
        public FrmCadPessoas()
        {
            InitializeComponent();
        }

        private void pessoa_MBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pessoa_MBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet_Agenda);

        }

        private void FrmCadPessoas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataSet_Agenda.Pessoa_M'. Você pode movê-la ou removê-la conforme necessário.
            this.pessoa_MTableAdapter.Fill(this.dataSet_Agenda.Pessoa_M);

        }
    }
}
