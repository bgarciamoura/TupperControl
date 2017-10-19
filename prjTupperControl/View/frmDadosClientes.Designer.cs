namespace prjTupperControl.View
{
    partial class frmDadosClientes
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corPreferidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagaEmDiaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlProcurar = new System.Windows.Forms.Panel();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEndereco = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPecas = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCadPecas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.pnlProcurar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToOrderColumns = true;
            this.dgvCliente.AllowUserToResizeRows = false;
            this.dgvCliente.AutoGenerateColumns = false;
            this.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.nascimentoDataGridViewTextBoxColumn,
            this.idadeDataGridViewTextBoxColumn,
            this.Column1,
            this.celularDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.corPreferidaDataGridViewTextBoxColumn,
            this.pagaEmDiaDataGridViewCheckBoxColumn,
            this.observacoesDataGridViewTextBoxColumn});
            this.dgvCliente.DataSource = this.clientesBindingSource;
            this.dgvCliente.Location = new System.Drawing.Point(148, 68);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(802, 251);
            this.dgvCliente.TabIndex = 1;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // nascimentoDataGridViewTextBoxColumn
            // 
            this.nascimentoDataGridViewTextBoxColumn.DataPropertyName = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.HeaderText = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.Name = "nascimentoDataGridViewTextBoxColumn";
            // 
            // idadeDataGridViewTextBoxColumn
            // 
            this.idadeDataGridViewTextBoxColumn.DataPropertyName = "Idade";
            this.idadeDataGridViewTextBoxColumn.HeaderText = "Idade";
            this.idadeDataGridViewTextBoxColumn.Name = "idadeDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Observacoes";
            this.Column1.HeaderText = "Sexo";
            this.Column1.Name = "Column1";
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // corPreferidaDataGridViewTextBoxColumn
            // 
            this.corPreferidaDataGridViewTextBoxColumn.DataPropertyName = "CorPreferida";
            this.corPreferidaDataGridViewTextBoxColumn.HeaderText = "Cor Preferida";
            this.corPreferidaDataGridViewTextBoxColumn.Name = "corPreferidaDataGridViewTextBoxColumn";
            // 
            // pagaEmDiaDataGridViewCheckBoxColumn
            // 
            this.pagaEmDiaDataGridViewCheckBoxColumn.DataPropertyName = "PagaEmDia";
            this.pagaEmDiaDataGridViewCheckBoxColumn.HeaderText = "Paga em Dia?";
            this.pagaEmDiaDataGridViewCheckBoxColumn.Name = "pagaEmDiaDataGridViewCheckBoxColumn";
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(prjTupperControl.Model.Clientes);
            // 
            // pnlProcurar
            // 
            this.pnlProcurar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProcurar.Controls.Add(this.txtProcurar);
            this.pnlProcurar.Controls.Add(this.label1);
            this.pnlProcurar.Location = new System.Drawing.Point(148, 12);
            this.pnlProcurar.Name = "pnlProcurar";
            this.pnlProcurar.Size = new System.Drawing.Size(802, 50);
            this.pnlProcurar.TabIndex = 3;
            // 
            // txtProcurar
            // 
            this.txtProcurar.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurar.Location = new System.Drawing.Point(272, 12);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(480, 23);
            this.txtProcurar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Nome da Cliente";
            // 
            // dgvEndereco
            // 
            this.dgvEndereco.AllowUserToAddRows = false;
            this.dgvEndereco.AllowUserToDeleteRows = false;
            this.dgvEndereco.AllowUserToResizeRows = false;
            this.dgvEndereco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndereco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvEndereco.Location = new System.Drawing.Point(148, 334);
            this.dgvEndereco.Name = "dgvEndereco";
            this.dgvEndereco.ReadOnly = true;
            this.dgvEndereco.Size = new System.Drawing.Size(802, 150);
            this.dgvEndereco.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Logradouro";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Número";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Bairro";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cidade";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "CEP";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Observações";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnPecas
            // 
            this.btnPecas.BackColor = System.Drawing.Color.Transparent;
            this.btnPecas.BackgroundImage = global::prjTupperControl.Properties.Resources.dishes_Bowl_64x64_By_Smashicons;
            this.btnPecas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPecas.FlatAppearance.BorderSize = 0;
            this.btnPecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPecas.Location = new System.Drawing.Point(409, 498);
            this.btnPecas.Name = "btnPecas";
            this.btnPecas.Size = new System.Drawing.Size(75, 74);
            this.btnPecas.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnPecas, "Ver as Peças que o Cliente Deseja/Gosta/Não Gosta");
            this.btnPecas.UseVisualStyleBackColor = false;
            this.btnPecas.Click += new System.EventHandler(this.btnPecas_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImage = global::prjTupperControl.Properties.Resources.pencil_64x64_By_Pixel_Buddha;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(691, 498);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 74);
            this.btnEditar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar um Cadastro");
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImage = global::prjTupperControl.Properties.Resources.eraser_64x64_By_Pixel_Buddha;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(550, 498);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 74);
            this.btnExcluir.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnExcluir, "Apagar um Cadastro");
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnCadPecas
            // 
            this.btnCadPecas.BackColor = System.Drawing.Color.Transparent;
            this.btnCadPecas.BackgroundImage = global::prjTupperControl.Properties.Resources.bowl_64x64_By_Smashicons;
            this.btnCadPecas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCadPecas.FlatAppearance.BorderSize = 0;
            this.btnCadPecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadPecas.Location = new System.Drawing.Point(268, 498);
            this.btnCadPecas.Name = "btnCadPecas";
            this.btnCadPecas.Size = new System.Drawing.Size(75, 74);
            this.btnCadPecas.TabIndex = 42;
            this.toolTip1.SetToolTip(this.btnCadPecas, "Cadastrar as peças para esse cliente");
            this.btnCadPecas.UseVisualStyleBackColor = false;
            this.btnCadPecas.Click += new System.EventHandler(this.btnCadPecas_Click);
            // 
            // frmDadosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 584);
            this.Controls.Add(this.btnCadPecas);
            this.Controls.Add(this.btnPecas);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvEndereco);
            this.Controls.Add(this.pnlProcurar);
            this.Controls.Add(this.dgvCliente);
            this.Name = "frmDadosClientes";
            this.Text = "frmDadosClientes";
            this.Controls.SetChildIndex(this.dgvCliente, 0);
            this.Controls.SetChildIndex(this.pnlProcurar, 0);
            this.Controls.SetChildIndex(this.dgvEndereco, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnPecas, 0);
            this.Controls.SetChildIndex(this.btnCadPecas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.pnlProcurar.ResumeLayout(false);
            this.pnlProcurar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.Panel pnlProcurar;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corPreferidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pagaEmDiaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnPecas;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCadPecas;
    }
}