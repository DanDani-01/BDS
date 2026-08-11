using Projeto_Agenda.Dados.DataSet_AgendaTableAdapters;
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
    public partial class frmLogon : Form
    {
        public frmLogon()
        {
            InitializeComponent();
        }
        private void lbl_senha_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_KeyDown(object sender, KeyEventArgs e)
        {

        }
        int erros = 0;
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
               errorProvider1.SetError(txt_usuario, "Preencha corretamente, companheiro!");
                return;
            }
            else
            {
                errorProvider1.SetError(txt_usuario, "");
            }
                DataTable dt = new DataTable();
            USUARIOTableAdapter taUsuario = new USUARIOTableAdapter();
            dt = taUsuario.Procurar_Usuario(txt_usuario.Text, txt_senha.Text);
            if (dt.Rows.Count > 0)//se achou algum registro, então o usuário e senha estão corretos
            {
                Projeto_Agenda.Properties.Settings.Default.NomeUsuarioLogado = txt_usuario.Text;
                Projeto_Agenda.Properties.Settings.Default.NivelUsuarioLogado = int.Parse(dt.Rows[0]["Nivel"].ToString());
                this.Hide();
                MDI_menu menu = new MDI_menu();
                menu.Show();
                this.Close();
            }
            else //não achou
            {
                MessageBox.Show("Usuário ou senha inválidos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                erros++;
                if (erros >= 3)
                {
                    MessageBox.Show("Número máximo de tentativas atingido. O programa será encerrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }
    }
}
