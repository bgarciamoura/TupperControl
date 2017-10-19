namespace prjTupperControl.View
{
    partial class frmCadPecas
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
            System.Windows.Forms.Label capacidadeLabel;
            System.Windows.Forms.Label corLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label vaiFreezerLabel;
            System.Windows.Forms.Label vaiMicroLabel;
            System.Windows.Forms.Label nomeLabel1;
            System.Windows.Forms.Label siglaLabel;
            this.txtCorPeca = new System.Windows.Forms.TextBox();
            this.txtNomePeca = new System.Windows.Forms.TextBox();
            this.chkFreezer = new System.Windows.Forms.CheckBox();
            this.chkMicro = new System.Windows.Forms.CheckBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.cmbUnidade = new System.Windows.Forms.ComboBox();
            this.cmbSigla = new System.Windows.Forms.ComboBox();
            this.nudCapacidade = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            capacidadeLabel = new System.Windows.Forms.Label();
            corLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            vaiFreezerLabel = new System.Windows.Forms.Label();
            vaiMicroLabel = new System.Windows.Forms.Label();
            nomeLabel1 = new System.Windows.Forms.Label();
            siglaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidade)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // capacidadeLabel
            // 
            capacidadeLabel.AutoSize = true;
            capacidadeLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            capacidadeLabel.Location = new System.Drawing.Point(6, 128);
            capacidadeLabel.Name = "capacidadeLabel";
            capacidadeLabel.Size = new System.Drawing.Size(96, 17);
            capacidadeLabel.TabIndex = 2;
            capacidadeLabel.Text = "Capacidade:";
            // 
            // corLabel
            // 
            corLabel.AutoSize = true;
            corLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            corLabel.Location = new System.Drawing.Point(9, 58);
            corLabel.Name = "corLabel";
            corLabel.Size = new System.Drawing.Size(40, 17);
            corLabel.TabIndex = 4;
            corLabel.Text = "Cor:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(9, 29);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(48, 17);
            nomeLabel.TabIndex = 6;
            nomeLabel.Text = "Nome:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantidadeLabel.Location = new System.Drawing.Point(9, 146);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(96, 34);
            quantidadeLabel.TabIndex = 8;
            quantidadeLabel.Text = "Quantidade\r\nDisponível:";
            // 
            // vaiFreezerLabel
            // 
            vaiFreezerLabel.AutoSize = true;
            vaiFreezerLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vaiFreezerLabel.Location = new System.Drawing.Point(9, 88);
            vaiFreezerLabel.Name = "vaiFreezerLabel";
            vaiFreezerLabel.Size = new System.Drawing.Size(104, 17);
            vaiFreezerLabel.TabIndex = 10;
            vaiFreezerLabel.Text = "Vai Freezer?";
            // 
            // vaiMicroLabel
            // 
            vaiMicroLabel.AutoSize = true;
            vaiMicroLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vaiMicroLabel.Location = new System.Drawing.Point(9, 118);
            vaiMicroLabel.Name = "vaiMicroLabel";
            vaiMicroLabel.Size = new System.Drawing.Size(88, 17);
            vaiMicroLabel.TabIndex = 12;
            vaiMicroLabel.Text = "Vai Micro?";
            // 
            // nomeLabel1
            // 
            nomeLabel1.AutoSize = true;
            nomeLabel1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel1.Location = new System.Drawing.Point(6, 57);
            nomeLabel1.Name = "nomeLabel1";
            nomeLabel1.Size = new System.Drawing.Size(152, 17);
            nomeLabel1.TabIndex = 14;
            nomeLabel1.Text = "Unidade de Medida:";
            // 
            // siglaLabel
            // 
            siglaLabel.AutoSize = true;
            siglaLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            siglaLabel.Location = new System.Drawing.Point(6, 93);
            siglaLabel.Name = "siglaLabel";
            siglaLabel.Size = new System.Drawing.Size(56, 17);
            siglaLabel.TabIndex = 16;
            siglaLabel.Text = "Sigla:";
            // 
            // txtCorPeca
            // 
            this.txtCorPeca.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorPeca.Location = new System.Drawing.Point(182, 55);
            this.txtCorPeca.Name = "txtCorPeca";
            this.txtCorPeca.Size = new System.Drawing.Size(196, 23);
            this.txtCorPeca.TabIndex = 2;
            // 
            // txtNomePeca
            // 
            this.txtNomePeca.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePeca.Location = new System.Drawing.Point(182, 26);
            this.txtNomePeca.Name = "txtNomePeca";
            this.txtNomePeca.Size = new System.Drawing.Size(196, 23);
            this.txtNomePeca.TabIndex = 1;
            // 
            // chkFreezer
            // 
            this.chkFreezer.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFreezer.Location = new System.Drawing.Point(182, 83);
            this.chkFreezer.Name = "chkFreezer";
            this.chkFreezer.Size = new System.Drawing.Size(104, 24);
            this.chkFreezer.TabIndex = 3;
            this.chkFreezer.UseVisualStyleBackColor = true;
            // 
            // chkMicro
            // 
            this.chkMicro.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMicro.Location = new System.Drawing.Point(182, 113);
            this.chkMicro.Name = "chkMicro";
            this.chkMicro.Size = new System.Drawing.Size(104, 24);
            this.chkMicro.TabIndex = 4;
            this.chkMicro.UseVisualStyleBackColor = true;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantidade.Location = new System.Drawing.Point(182, 152);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(196, 22);
            this.nudQuantidade.TabIndex = 5;
            this.nudQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbUnidade
            // 
            this.cmbUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidade.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnidade.FormattingEnabled = true;
            this.cmbUnidade.Items.AddRange(new object[] {
            "Litros",
            "Mililitros"});
            this.cmbUnidade.Location = new System.Drawing.Point(179, 57);
            this.cmbUnidade.Name = "cmbUnidade";
            this.cmbUnidade.Size = new System.Drawing.Size(196, 24);
            this.cmbUnidade.TabIndex = 6;
            // 
            // cmbSigla
            // 
            this.cmbSigla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSigla.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSigla.FormattingEnabled = true;
            this.cmbSigla.Items.AddRange(new object[] {
            "L",
            "ml"});
            this.cmbSigla.Location = new System.Drawing.Point(179, 90);
            this.cmbSigla.Name = "cmbSigla";
            this.cmbSigla.Size = new System.Drawing.Size(196, 24);
            this.cmbSigla.TabIndex = 7;
            // 
            // nudCapacidade
            // 
            this.nudCapacidade.DecimalPlaces = 1;
            this.nudCapacidade.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCapacidade.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCapacidade.Location = new System.Drawing.Point(179, 127);
            this.nudCapacidade.Name = "nudCapacidade";
            this.nudCapacidade.Size = new System.Drawing.Size(196, 22);
            this.nudCapacidade.TabIndex = 21;
            this.nudCapacidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCapacidade.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudQuantidade);
            this.groupBox1.Controls.Add(this.chkMicro);
            this.groupBox1.Controls.Add(vaiMicroLabel);
            this.groupBox1.Controls.Add(this.chkFreezer);
            this.groupBox1.Controls.Add(vaiFreezerLabel);
            this.groupBox1.Controls.Add(quantidadeLabel);
            this.groupBox1.Controls.Add(this.txtNomePeca);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(corLabel);
            this.groupBox1.Controls.Add(this.txtCorPeca);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(149, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 188);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da peça";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(capacidadeLabel);
            this.groupBox2.Controls.Add(siglaLabel);
            this.groupBox2.Controls.Add(this.nudCapacidade);
            this.groupBox2.Controls.Add(nomeLabel1);
            this.groupBox2.Controls.Add(this.cmbSigla);
            this.groupBox2.Controls.Add(this.cmbUnidade);
            this.groupBox2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(542, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 188);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unidade de medida";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::prjTupperControl.Properties.Resources.floppy_128x128_By_Freepik;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(506, 504);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 74);
            this.btnSalvar.TabIndex = 41;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::prjTupperControl.Properties.Resources.tupperware_Logo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(149, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 292);
            this.panel2.TabIndex = 42;
            // 
            // frmCadPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(956, 610);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "frmCadPecas";
            this.Text = "frmCadPecas";
            this.Load += new System.EventHandler(this.frmCadPecas_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidade)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCorPeca;
        private System.Windows.Forms.TextBox txtNomePeca;
        private System.Windows.Forms.CheckBox chkFreezer;
        private System.Windows.Forms.CheckBox chkMicro;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.ComboBox cmbUnidade;
        private System.Windows.Forms.ComboBox cmbSigla;
        private System.Windows.Forms.NumericUpDown nudCapacidade;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel2;
    }
}