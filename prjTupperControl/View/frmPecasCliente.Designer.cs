namespace prjTupperControl.View
{
    partial class frmPecasCliente
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
            this.dgvPreferidas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDesejadaas = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvNaoGosta = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCompradas = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreferidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesejadaas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaoGosta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompradas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPreferidas
            // 
            this.dgvPreferidas.AllowUserToAddRows = false;
            this.dgvPreferidas.AllowUserToDeleteRows = false;
            this.dgvPreferidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPreferidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreferidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvPreferidas.Location = new System.Drawing.Point(7, 24);
            this.dgvPreferidas.Name = "dgvPreferidas";
            this.dgvPreferidas.ReadOnly = true;
            this.dgvPreferidas.Size = new System.Drawing.Size(351, 150);
            this.dgvPreferidas.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome da Peça";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Capacidade";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Peças preferidas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Peças desejadas";
            // 
            // dgvDesejadaas
            // 
            this.dgvDesejadaas.AllowUserToAddRows = false;
            this.dgvDesejadaas.AllowUserToDeleteRows = false;
            this.dgvDesejadaas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDesejadaas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDesejadaas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvDesejadaas.Location = new System.Drawing.Point(7, 196);
            this.dgvDesejadaas.Name = "dgvDesejadaas";
            this.dgvDesejadaas.ReadOnly = true;
            this.dgvDesejadaas.Size = new System.Drawing.Size(351, 150);
            this.dgvDesejadaas.TabIndex = 2;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nome da Peça";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Capacidade";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cor";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(368, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Peças que o cliente não gosta";
            // 
            // dgvNaoGosta
            // 
            this.dgvNaoGosta.AllowUserToAddRows = false;
            this.dgvNaoGosta.AllowUserToDeleteRows = false;
            this.dgvNaoGosta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNaoGosta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNaoGosta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6});
            this.dgvNaoGosta.Location = new System.Drawing.Point(371, 24);
            this.dgvNaoGosta.Name = "dgvNaoGosta";
            this.dgvNaoGosta.ReadOnly = true;
            this.dgvNaoGosta.Size = new System.Drawing.Size(351, 150);
            this.dgvNaoGosta.TabIndex = 4;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nome da Peça";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Peças já compradas";
            // 
            // dgvCompradas
            // 
            this.dgvCompradas.AllowUserToAddRows = false;
            this.dgvCompradas.AllowUserToDeleteRows = false;
            this.dgvCompradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvCompradas.Location = new System.Drawing.Point(371, 196);
            this.dgvCompradas.Name = "dgvCompradas";
            this.dgvCompradas.ReadOnly = true;
            this.dgvCompradas.Size = new System.Drawing.Size(351, 150);
            this.dgvCompradas.TabIndex = 6;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Nome da Peça";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Quantidade";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Cor";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Capacidade";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // frmPecasCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 354);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCompradas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvNaoGosta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDesejadaas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPreferidas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPecasCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peças para o cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreferidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesejadaas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaoGosta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreferidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDesejadaas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvNaoGosta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCompradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}