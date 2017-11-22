namespace prjTupperControl.View
{
    partial class frmDadosConsultora
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
            this.dgvConsultora = new System.Windows.Forms.DataGridView();
            this.consultoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlProcurar = new System.Windows.Forms.Panel();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEndereco = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBrinde = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCadDoc = new System.Windows.Forms.Button();
            this.dgvEndereco = new System.Windows.Forms.DataGridView();
            this.logradouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoraBindingSource)).BeginInit();
            this.pnlProcurar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultora
            // 
            this.dgvConsultora.AllowUserToAddRows = false;
            this.dgvConsultora.AllowUserToDeleteRows = false;
            this.dgvConsultora.AllowUserToResizeRows = false;
            this.dgvConsultora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column5,
            this.Column4,
            this.ATIVA,
            this.Column7,
            this.Column6});
            this.dgvConsultora.Location = new System.Drawing.Point(148, 63);
            this.dgvConsultora.MultiSelect = false;
            this.dgvConsultora.Name = "dgvConsultora";
            this.dgvConsultora.ReadOnly = true;
            this.dgvConsultora.RowHeadersVisible = false;
            this.dgvConsultora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultora.Size = new System.Drawing.Size(802, 283);
            this.dgvConsultora.TabIndex = 2;
            this.dgvConsultora.SelectionChanged += new System.EventHandler(this.dgvConsultora_SelectionChanged);
            // 
            // consultoraBindingSource
            // 
            this.consultoraBindingSource.DataSource = typeof(prjTupperControl.Model.Consultora);
            // 
            // pnlProcurar
            // 
            this.pnlProcurar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProcurar.Controls.Add(this.txtProcurar);
            this.pnlProcurar.Controls.Add(this.label1);
            this.pnlProcurar.Location = new System.Drawing.Point(148, 7);
            this.pnlProcurar.Name = "pnlProcurar";
            this.pnlProcurar.Size = new System.Drawing.Size(802, 50);
            this.pnlProcurar.TabIndex = 2;
            // 
            // txtProcurar
            // 
            this.txtProcurar.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcurar.Location = new System.Drawing.Point(314, 12);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(480, 23);
            this.txtProcurar.TabIndex = 1;
            this.txtProcurar.TextChanged += new System.EventHandler(this.txtProcurar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o Nome ou Código da Consultora";
            // 
            // btnEndereco
            // 
            this.btnEndereco.BackColor = System.Drawing.Color.Transparent;
            this.btnEndereco.BackgroundImage = global::prjTupperControl.Properties.Resources.planet_earth_64x64_By_Vectors_Market;
            this.btnEndereco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEndereco.FlatAppearance.BorderSize = 0;
            this.btnEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndereco.Location = new System.Drawing.Point(398, 498);
            this.btnEndereco.Name = "btnEndereco";
            this.btnEndereco.Size = new System.Drawing.Size(75, 74);
            this.btnEndereco.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnEndereco, "Visualizar Endereço");
            this.btnEndereco.UseVisualStyleBackColor = false;
            this.btnEndereco.Click += new System.EventHandler(this.btnEndereco_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.BackgroundImage = global::prjTupperControl.Properties.Resources.eraser_64x64_By_Pixel_Buddha;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(670, 498);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 74);
            this.btnExcluir.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnExcluir, "Apagar um Cadastro");
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImage = global::prjTupperControl.Properties.Resources.pencil_64x64_By_Pixel_Buddha;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(806, 498);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 74);
            this.btnEditar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar um Cadastro");
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnBrinde
            // 
            this.btnBrinde.BackColor = System.Drawing.Color.Transparent;
            this.btnBrinde.BackgroundImage = global::prjTupperControl.Properties.Resources.dishes_Bowl_64x64_By_Smashicons;
            this.btnBrinde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrinde.FlatAppearance.BorderSize = 0;
            this.btnBrinde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrinde.Location = new System.Drawing.Point(534, 498);
            this.btnBrinde.Name = "btnBrinde";
            this.btnBrinde.Size = new System.Drawing.Size(75, 74);
            this.btnBrinde.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnBrinde, "Ver Brinde de Indicação");
            this.btnBrinde.UseVisualStyleBackColor = false;
            // 
            // btnCadDoc
            // 
            this.btnCadDoc.BackgroundImage = global::prjTupperControl.Properties.Resources.ID;
            this.btnCadDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadDoc.FlatAppearance.BorderSize = 0;
            this.btnCadDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadDoc.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadDoc.Location = new System.Drawing.Point(210, 498);
            this.btnCadDoc.Name = "btnCadDoc";
            this.btnCadDoc.Size = new System.Drawing.Size(127, 74);
            this.btnCadDoc.TabIndex = 36;
            this.btnCadDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadDoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnCadDoc, "Visualizar e cadastrar documentos");
            this.btnCadDoc.UseVisualStyleBackColor = true;
            this.btnCadDoc.Click += new System.EventHandler(this.btnCadDoc_Click);
            // 
            // dgvEndereco
            // 
            this.dgvEndereco.AllowUserToAddRows = false;
            this.dgvEndereco.AllowUserToDeleteRows = false;
            this.dgvEndereco.AllowUserToResizeRows = false;
            this.dgvEndereco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEndereco.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndereco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logradouro,
            this.numero,
            this.bairro,
            this.cidade,
            this.cep,
            this.obs});
            this.dgvEndereco.Location = new System.Drawing.Point(148, 352);
            this.dgvEndereco.Name = "dgvEndereco";
            this.dgvEndereco.ReadOnly = true;
            this.dgvEndereco.RowHeadersVisible = false;
            this.dgvEndereco.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEndereco.ShowEditingIcon = false;
            this.dgvEndereco.Size = new System.Drawing.Size(802, 140);
            this.dgvEndereco.TabIndex = 37;
            // 
            // logradouro
            // 
            this.logradouro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.logradouro.HeaderText = "Logradouro";
            this.logradouro.Name = "logradouro";
            this.logradouro.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // bairro
            // 
            this.bairro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bairro.HeaderText = "Bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            // 
            // cidade
            // 
            this.cidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cidade.HeaderText = "Cidade";
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            // 
            // cep
            // 
            this.cep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cep.HeaderText = "CEP";
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            // 
            // obs
            // 
            this.obs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.obs.HeaderText = "Observações";
            this.obs.Name = "obs";
            this.obs.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "IDPESSOA";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Código";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nome";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // ATIVA
            // 
            this.ATIVA.HeaderText = "Está Ativa?";
            this.ATIVA.Name = "ATIVA";
            this.ATIVA.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Celular";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Observações";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // frmDadosConsultora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 584);
            this.Controls.Add(this.dgvEndereco);
            this.Controls.Add(this.btnCadDoc);
            this.Controls.Add(this.btnBrinde);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEndereco);
            this.Controls.Add(this.pnlProcurar);
            this.Controls.Add(this.dgvConsultora);
            this.Name = "frmDadosConsultora";
            this.Text = "frmDadosConsultora";
            this.Load += new System.EventHandler(this.frmDadosConsultora_Load);
            this.Controls.SetChildIndex(this.dgvConsultora, 0);
            this.Controls.SetChildIndex(this.pnlProcurar, 0);
            this.Controls.SetChildIndex(this.btnEndereco, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnBrinde, 0);
            this.Controls.SetChildIndex(this.btnCadDoc, 0);
            this.Controls.SetChildIndex(this.dgvEndereco, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoraBindingSource)).EndInit();
            this.pnlProcurar.ResumeLayout(false);
            this.pnlProcurar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndereco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultora;
        private System.Windows.Forms.BindingSource consultoraBindingSource;
        private System.Windows.Forms.Panel pnlProcurar;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEndereco;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBrinde;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCadDoc;
        private System.Windows.Forms.DataGridView dgvEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATIVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}