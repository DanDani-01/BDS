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

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filtro;
            if (cmbColuna.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma coluna para filtrar.");
                return;
            }
            filtro = cmbColuna.Text;

            string busca = cmbBuscar.Text;
            if (busca == "Igual")
            {
                filtro += " = '" + txtValor.Text + "'";
            }
            else if (busca == "Que começa com")
            {
                filtro += " like '" + txtValor.Text + "%'";
            }
            else if (busca == "Que termina com")
            {
                filtro += " like '%" + txtValor.Text + "'";
            }
            else if (busca == "Que contém")
            {
                filtro += " like '%" + txtValor.Text + "%'";
            }
            else if(busca == "Todos")
            {
                filtro = "";
            }
            else
            {
                MessageBox.Show("Selecione um tipo de busca.");
                return;
            }
            pessoaMBindingSource.Filter = filtro;
        }
    }
}
