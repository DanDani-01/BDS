namespace Projeto_Agenda.Formularios
{
    partial class FrmCadPessoas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label endereçoLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label data_NascimentoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadPessoas));
            this.dataSet_Agenda = new Projeto_Agenda.Dados.DataSet_Agenda();
            this.pessoa_MBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoa_MTableAdapter = new Projeto_Agenda.Dados.DataSet_AgendaTableAdapters.Pessoa_MTableAdapter();
            this.tableAdapterManager = new Projeto_Agenda.Dados.DataSet_AgendaTableAdapters.TableAdapterManager();
            this.pessoa_MBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pessoa_MBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.endereçoTextBox = new System.Windows.Forms.TextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.data_NascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pessoa_MDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            endereçoLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            data_NascimentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_MBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_MBindingNavigator)).BeginInit();
            this.pessoa_MBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_MDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(12, 51);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(30, 20);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(12, 83);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(55, 20);
            nomeLabel.TabIndex = 3;
            nomeLabel.Text = "Nome:";
            // 
            // endereçoLabel
            // 
            endereçoLabel.AutoSize = true;
            endereçoLabel.Location = new System.Drawing.Point(12, 115);
            endereçoLabel.Name = "endereçoLabel";
            endereçoLabel.Size = new System.Drawing.Size(82, 20);
            endereçoLabel.TabIndex = 5;
            endereçoLabel.Text = "Endereço:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(12, 147);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(63, 20);
            cidadeLabel.TabIndex = 7;
            cidadeLabel.Text = "Cidade:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 179);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 20);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // data_NascimentoLabel
            // 
            data_NascimentoLabel.AutoSize = true;
            data_NascimentoLabel.Location = new System.Drawing.Point(12, 212);
            data_NascimentoLabel.Name = "data_NascimentoLabel";
            data_NascimentoLabel.Size = new System.Drawing.Size(136, 20);
            data_NascimentoLabel.TabIndex = 11;
            data_NascimentoLabel.Text = "Data Nascimento:";
            // 
            // dataSet_Agenda
            // 
            this.dataSet_Agenda.DataSetName = "DataSet_Agenda";
            this.dataSet_Agenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pessoa_MBindingSource
            // 
            this.pessoa_MBindingSource.DataMember = "Pessoa_M";
            this.pessoa_MBindingSource.DataSource = this.dataSet_Agenda;
            // 
            // pessoa_MTableAdapter
            // 
            this.pessoa_MTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Pessoa_MTableAdapter = this.pessoa_MTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projeto_Agenda.Dados.DataSet_AgendaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pessoa_MBindingNavigator
            // 
            this.pessoa_MBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pessoa_MBindingNavigator.BindingSource = this.pessoa_MBindingSource;
            this.pessoa_MBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pessoa_MBindingNavigator.DeleteItem = null;
            this.pessoa_MBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.pessoa_MBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pessoa_MBindingNavigatorSaveItem});
            this.pessoa_MBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pessoa_MBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pessoa_MBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pessoa_MBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pessoa_MBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pessoa_MBindingNavigator.Name = "pessoa_MBindingNavigator";
            this.pessoa_MBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pessoa_MBindingNavigator.Size = new System.Drawing.Size(1018, 33);
            this.pessoa_MBindingNavigator.TabIndex = 0;
            this.pessoa_MBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // pessoa_MBindingNavigatorSaveItem
            // 
            this.pessoa_MBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pessoa_MBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pessoa_MBindingNavigatorSaveItem.Image")));
            this.pessoa_MBindingNavigatorSaveItem.Name = "pessoa_MBindingNavigatorSaveItem";
            this.pessoa_MBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.pessoa_MBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pessoa_MBindingNavigatorSaveItem.Click += new System.EventHandler(this.pessoa_MBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoa_MBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(154, 48);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 26);
            this.iDTextBox.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoa_MBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(154, 80);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 26);
            this.nomeTextBox.TabIndex = 4;
            // 
            // endereçoTextBox
            // 
            this.endereçoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoa_MBindingSource, "Endereço", true));
            this.endereçoTextBox.Location = new System.Drawing.Point(154, 112);
            this.endereçoTextBox.Name = "endereçoTextBox";
            this.endereçoTextBox.Size = new System.Drawing.Size(200, 26);
            this.endereçoTextBox.TabIndex = 6;
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoa_MBindingSource, "Cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(154, 144);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(200, 26);
            this.cidadeTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pessoa_MBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(154, 176);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 26);
            this.emailTextBox.TabIndex = 10;
            // 
            // data_NascimentoDateTimePicker
            // 
            this.data_NascimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pessoa_MBindingSource, "Data_Nascimento", true));
            this.data_NascimentoDateTimePicker.Location = new System.Drawing.Point(154, 208);
            this.data_NascimentoDateTimePicker.Name = "data_NascimentoDateTimePicker";
            this.data_NascimentoDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.data_NascimentoDateTimePicker.TabIndex = 12;
            // 
            // pessoa_MDataGridView
            // 
            this.pessoa_MDataGridView.AutoGenerateColumns = false;
            this.pessoa_MDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pessoa_MDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.pessoa_MDataGridView.DataSource = this.pessoa_MBindingSource;
            this.pessoa_MDataGridView.Location = new System.Drawing.Point(12, 250);
            this.pessoa_MDataGridView.Name = "pessoa_MDataGridView";
            this.pessoa_MDataGridView.RowHeadersWidth = 62;
            this.pessoa_MDataGridView.RowTemplate.Height = 28;
            this.pessoa_MDataGridView.Size = new System.Drawing.Size(994, 322);
            this.pessoa_MDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Endereço";
            this.dataGridViewTextBoxColumn3.HeaderText = "Endereço";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 225;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cidade";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Data_Nascimento";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data_Nascimento";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // FrmCadPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 584);
            this.Controls.Add(this.pessoa_MDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(endereçoLabel);
            this.Controls.Add(this.endereçoTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(data_NascimentoLabel);
            this.Controls.Add(this.data_NascimentoDateTimePicker);
            this.Controls.Add(this.pessoa_MBindingNavigator);
            this.Name = "FrmCadPessoas";
            this.Text = "Cadastro de Pessoas";
            this.Load += new System.EventHandler(this.FrmCadPessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Agenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_MBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_MBindingNavigator)).EndInit();
            this.pessoa_MBindingNavigator.ResumeLayout(false);
            this.pessoa_MBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pessoa_MDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dados.DataSet_Agenda dataSet_Agenda;
        private System.Windows.Forms.BindingSource pessoa_MBindingSource;
        private Dados.DataSet_AgendaTableAdapters.Pessoa_MTableAdapter pessoa_MTableAdapter;
        private Dados.DataSet_AgendaTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pessoa_MBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pessoa_MBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox endereçoTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker data_NascimentoDateTimePicker;
        private System.Windows.Forms.DataGridView pessoa_MDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}