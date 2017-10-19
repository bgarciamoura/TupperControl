﻿namespace prjTupperControl.View
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
            this.dgvDocumentos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnEndereco = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBrinde = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoraBindingSource)).BeginInit();
            this.pnlProcurar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultora
            // 
            this.dgvConsultora.AllowUserToAddRows = false;
            this.dgvConsultora.AllowUserToDeleteRows = false;
            this.dgvConsultora.AllowUserToResizeRows = false;
            this.dgvConsultora.AutoGenerateColumns = false;
            this.dgvConsultora.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.nascimentoDataGridViewTextBoxColumn,
            this.idadeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.celularDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.observacoesDataGridViewTextBoxColumn});
            this.dgvConsultora.DataSource = this.consultoraBindingSource;
            this.dgvConsultora.Location = new System.Drawing.Point(148, 63);
            this.dgvConsultora.Name = "dgvConsultora";
            this.dgvConsultora.ReadOnly = true;
            this.dgvConsultora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultora.Size = new System.Drawing.Size(802, 283);
            this.dgvConsultora.TabIndex = 2;
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
            // dgvDocumentos
            // 
            this.dgvDocumentos.AllowUserToAddRows = false;
            this.dgvDocumentos.AllowUserToDeleteRows = false;
            this.dgvDocumentos.AllowUserToResizeRows = false;
            this.dgvDocumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDocumentos.Location = new System.Drawing.Point(148, 352);
            this.dgvDocumentos.Name = "dgvDocumentos";
            this.dgvDocumentos.ReadOnly = true;
            this.dgvDocumentos.Size = new System.Drawing.Size(802, 129);
            this.dgvDocumentos.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tipo Documento";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Número do Documento";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Foto do Documento";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnEndereco
            // 
            this.btnEndereco.BackColor = System.Drawing.Color.Transparent;
            this.btnEndereco.BackgroundImage = global::prjTupperControl.Properties.Resources.planet_earth_64x64_By_Vectors_Market;
            this.btnEndereco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEndereco.FlatAppearance.BorderSize = 0;
            this.btnEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndereco.Location = new System.Drawing.Point(269, 498);
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
            this.btnExcluir.Location = new System.Drawing.Point(549, 498);
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
            this.btnEditar.Location = new System.Drawing.Point(689, 498);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 74);
            this.btnEditar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar um Cadastro");
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nascimentoDataGridViewTextBoxColumn
            // 
            this.nascimentoDataGridViewTextBoxColumn.DataPropertyName = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.HeaderText = "Nascimento";
            this.nascimentoDataGridViewTextBoxColumn.Name = "nascimentoDataGridViewTextBoxColumn";
            this.nascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idadeDataGridViewTextBoxColumn
            // 
            this.idadeDataGridViewTextBoxColumn.DataPropertyName = "Idade";
            this.idadeDataGridViewTextBoxColumn.HeaderText = "Idade";
            this.idadeDataGridViewTextBoxColumn.Name = "idadeDataGridViewTextBoxColumn";
            this.idadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Observacoes";
            this.dataGridViewTextBoxColumn1.HeaderText = "Sexo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            this.observacoesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnBrinde
            // 
            this.btnBrinde.BackColor = System.Drawing.Color.Transparent;
            this.btnBrinde.BackgroundImage = global::prjTupperControl.Properties.Resources.dishes_Bowl_64x64_By_Smashicons;
            this.btnBrinde.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrinde.FlatAppearance.BorderSize = 0;
            this.btnBrinde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrinde.Location = new System.Drawing.Point(409, 498);
            this.btnBrinde.Name = "btnBrinde";
            this.btnBrinde.Size = new System.Drawing.Size(75, 74);
            this.btnBrinde.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnBrinde, "Ver Brinde de Indicação");
            this.btnBrinde.UseVisualStyleBackColor = false;
            // 
            // frmDadosConsultora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 584);
            this.Controls.Add(this.btnBrinde);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEndereco);
            this.Controls.Add(this.dgvDocumentos);
            this.Controls.Add(this.pnlProcurar);
            this.Controls.Add(this.dgvConsultora);
            this.Name = "frmDadosConsultora";
            this.Text = "frmDadosConsultora";
            this.Controls.SetChildIndex(this.dgvConsultora, 0);
            this.Controls.SetChildIndex(this.pnlProcurar, 0);
            this.Controls.SetChildIndex(this.dgvDocumentos, 0);
            this.Controls.SetChildIndex(this.btnEndereco, 0);
            this.Controls.SetChildIndex(this.btnExcluir, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnBrinde, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultoraBindingSource)).EndInit();
            this.pnlProcurar.ResumeLayout(false);
            this.pnlProcurar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultora;
        private System.Windows.Forms.BindingSource consultoraBindingSource;
        private System.Windows.Forms.Panel pnlProcurar;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDocumentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.Button btnEndereco;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBrinde;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}