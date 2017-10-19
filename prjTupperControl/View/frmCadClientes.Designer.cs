namespace prjTupperControl.View
{
    partial class frmCadClientes
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
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label logradouroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label observacoesLabel;
            System.Windows.Forms.Label idadeLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label nascimentoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label pagaEmDiaLabel;
            System.Windows.Forms.Label corPreferidaLabel;
            System.Windows.Forms.Label sexoLabel;
            this.grbOutrasInformacoes = new System.Windows.Forms.GroupBox();
            this.txtCorPreferida = new System.Windows.Forms.TextBox();
            this.chkPagaEmDia = new System.Windows.Forms.CheckBox();
            this.rtxtObs = new System.Windows.Forms.RichTextBox();
            this.grbEndereco = new System.Windows.Forms.GroupBox();
            this.txtNumeroCasa = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.rtxtObsEndereco = new System.Windows.Forms.RichTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.btnCadDoc = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            numeroLabel = new System.Windows.Forms.Label();
            logradouroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            observacoesLabel = new System.Windows.Forms.Label();
            idadeLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            nascimentoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            pagaEmDiaLabel = new System.Windows.Forms.Label();
            corPreferidaLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            this.grbOutrasInformacoes.SuspendLayout();
            this.grbEndereco.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numeroLabel.Location = new System.Drawing.Point(19, 75);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(64, 17);
            numeroLabel.TabIndex = 42;
            numeroLabel.Text = "Numero:";
            // 
            // logradouroLabel
            // 
            logradouroLabel.AutoSize = true;
            logradouroLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            logradouroLabel.Location = new System.Drawing.Point(19, 49);
            logradouroLabel.Name = "logradouroLabel";
            logradouroLabel.Size = new System.Drawing.Size(96, 17);
            logradouroLabel.TabIndex = 41;
            logradouroLabel.Text = "Logradouro:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cidadeLabel.Location = new System.Drawing.Point(19, 23);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(64, 17);
            cidadeLabel.TabIndex = 40;
            cidadeLabel.Text = "Cidade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(119, 150);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 17);
            label1.TabIndex = 36;
            label1.Text = "Observações:";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bairroLabel.Location = new System.Drawing.Point(19, 101);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(64, 17);
            bairroLabel.TabIndex = 20;
            bairroLabel.Text = "Bairro:";
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cepLabel.Location = new System.Drawing.Point(19, 127);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(40, 17);
            cepLabel.TabIndex = 22;
            cepLabel.Text = "Cep:";
            // 
            // observacoesLabel
            // 
            observacoesLabel.AutoSize = true;
            observacoesLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            observacoesLabel.Location = new System.Drawing.Point(113, 161);
            observacoesLabel.Name = "observacoesLabel";
            observacoesLabel.Size = new System.Drawing.Size(104, 17);
            observacoesLabel.TabIndex = 16;
            observacoesLabel.Text = "Observações:";
            // 
            // idadeLabel
            // 
            idadeLabel.AutoSize = true;
            idadeLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idadeLabel.Location = new System.Drawing.Point(19, 50);
            idadeLabel.Name = "idadeLabel";
            idadeLabel.Size = new System.Drawing.Size(56, 17);
            idadeLabel.TabIndex = 10;
            idadeLabel.Text = "Idade:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefoneLabel.Location = new System.Drawing.Point(19, 102);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(80, 17);
            telefoneLabel.TabIndex = 18;
            telefoneLabel.Text = "Telefone:";
            // 
            // nascimentoLabel
            // 
            nascimentoLabel.AutoSize = true;
            nascimentoLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nascimentoLabel.Location = new System.Drawing.Point(19, 77);
            nascimentoLabel.Name = "nascimentoLabel";
            nascimentoLabel.Size = new System.Drawing.Size(96, 17);
            nascimentoLabel.TabIndex = 12;
            nascimentoLabel.Text = "Nascimento:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(20, 25);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(48, 17);
            nomeLabel.TabIndex = 14;
            nomeLabel.Text = "Nome:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            celularLabel.Location = new System.Drawing.Point(19, 128);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(72, 17);
            celularLabel.TabIndex = 2;
            celularLabel.Text = "Celular:";
            // 
            // pagaEmDiaLabel
            // 
            pagaEmDiaLabel.AutoSize = true;
            pagaEmDiaLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pagaEmDiaLabel.Location = new System.Drawing.Point(24, 117);
            pagaEmDiaLabel.Name = "pagaEmDiaLabel";
            pagaEmDiaLabel.Size = new System.Drawing.Size(224, 17);
            pagaEmDiaLabel.TabIndex = 35;
            pagaEmDiaLabel.Text = "Realiza o Pagamento em Dia:";
            // 
            // corPreferidaLabel
            // 
            corPreferidaLabel.AutoSize = true;
            corPreferidaLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            corPreferidaLabel.Location = new System.Drawing.Point(24, 69);
            corPreferidaLabel.Name = "corPreferidaLabel";
            corPreferidaLabel.Size = new System.Drawing.Size(120, 17);
            corPreferidaLabel.TabIndex = 36;
            corPreferidaLabel.Text = "Cor Preferida:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexoLabel.Location = new System.Drawing.Point(20, 153);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(48, 17);
            sexoLabel.TabIndex = 18;
            sexoLabel.Text = "Sexo:";
            // 
            // grbOutrasInformacoes
            // 
            this.grbOutrasInformacoes.Controls.Add(corPreferidaLabel);
            this.grbOutrasInformacoes.Controls.Add(this.txtCorPreferida);
            this.grbOutrasInformacoes.Controls.Add(pagaEmDiaLabel);
            this.grbOutrasInformacoes.Controls.Add(this.chkPagaEmDia);
            this.grbOutrasInformacoes.Controls.Add(this.rtxtObs);
            this.grbOutrasInformacoes.Controls.Add(observacoesLabel);
            this.grbOutrasInformacoes.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOutrasInformacoes.Location = new System.Drawing.Point(543, 7);
            this.grbOutrasInformacoes.Name = "grbOutrasInformacoes";
            this.grbOutrasInformacoes.Size = new System.Drawing.Size(317, 478);
            this.grbOutrasInformacoes.TabIndex = 39;
            this.grbOutrasInformacoes.TabStop = false;
            this.grbOutrasInformacoes.Text = "Outras Informações";
            // 
            // txtCorPreferida
            // 
            this.txtCorPreferida.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorPreferida.Location = new System.Drawing.Point(178, 66);
            this.txtCorPreferida.Name = "txtCorPreferida";
            this.txtCorPreferida.Size = new System.Drawing.Size(121, 23);
            this.txtCorPreferida.TabIndex = 37;
            // 
            // chkPagaEmDia
            // 
            this.chkPagaEmDia.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPagaEmDia.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPagaEmDia.Location = new System.Drawing.Point(271, 113);
            this.chkPagaEmDia.Name = "chkPagaEmDia";
            this.chkPagaEmDia.Size = new System.Drawing.Size(28, 24);
            this.chkPagaEmDia.TabIndex = 36;
            this.chkPagaEmDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkPagaEmDia.UseVisualStyleBackColor = true;
            // 
            // rtxtObs
            // 
            this.rtxtObs.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtObs.Location = new System.Drawing.Point(18, 182);
            this.rtxtObs.Name = "rtxtObs";
            this.rtxtObs.Size = new System.Drawing.Size(281, 271);
            this.rtxtObs.TabIndex = 35;
            this.rtxtObs.Text = "";
            // 
            // grbEndereco
            // 
            this.grbEndereco.Controls.Add(this.txtNumeroCasa);
            this.grbEndereco.Controls.Add(numeroLabel);
            this.grbEndereco.Controls.Add(this.txtLogradouro);
            this.grbEndereco.Controls.Add(logradouroLabel);
            this.grbEndereco.Controls.Add(this.txtCidade);
            this.grbEndereco.Controls.Add(cidadeLabel);
            this.grbEndereco.Controls.Add(this.rtxtObsEndereco);
            this.grbEndereco.Controls.Add(label1);
            this.grbEndereco.Controls.Add(bairroLabel);
            this.grbEndereco.Controls.Add(this.txtBairro);
            this.grbEndereco.Controls.Add(cepLabel);
            this.grbEndereco.Controls.Add(this.txtCep);
            this.grbEndereco.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEndereco.Location = new System.Drawing.Point(164, 198);
            this.grbEndereco.Name = "grbEndereco";
            this.grbEndereco.Size = new System.Drawing.Size(344, 287);
            this.grbEndereco.TabIndex = 38;
            this.grbEndereco.TabStop = false;
            this.grbEndereco.Text = "Endereço";
            // 
            // txtNumeroCasa
            // 
            this.txtNumeroCasa.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCasa.Location = new System.Drawing.Point(122, 72);
            this.txtNumeroCasa.Name = "txtNumeroCasa";
            this.txtNumeroCasa.Size = new System.Drawing.Size(205, 20);
            this.txtNumeroCasa.TabIndex = 39;
            this.txtNumeroCasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouro.Location = new System.Drawing.Point(122, 46);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(205, 20);
            this.txtLogradouro.TabIndex = 38;
            this.txtLogradouro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(122, 20);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(205, 20);
            this.txtCidade.TabIndex = 37;
            this.txtCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rtxtObsEndereco
            // 
            this.rtxtObsEndereco.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtObsEndereco.Location = new System.Drawing.Point(24, 172);
            this.rtxtObsEndereco.Name = "rtxtObsEndereco";
            this.rtxtObsEndereco.Size = new System.Drawing.Size(303, 108);
            this.rtxtObsEndereco.TabIndex = 11;
            this.rtxtObsEndereco.Text = "";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(122, 98);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(205, 20);
            this.txtBairro.TabIndex = 6;
            this.txtBairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(122, 124);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(205, 20);
            this.txtCep.TabIndex = 7;
            this.txtCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSexo);
            this.groupBox1.Controls.Add(sexoLabel);
            this.groupBox1.Controls.Add(celularLabel);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.dtpNascimento);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(nascimentoLabel);
            this.groupBox1.Controls.Add(telefoneLabel);
            this.groupBox1.Controls.Add(idadeLabel);
            this.groupBox1.Controls.Add(this.txtIdade);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(164, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 185);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Feminino  (F)",
            "Masculino (M)"});
            this.cmbSexo.Location = new System.Drawing.Point(122, 153);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(200, 24);
            this.cmbSexo.TabIndex = 19;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(122, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(122, 125);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(200, 20);
            this.txtCelular.TabIndex = 5;
            this.txtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpNascimento.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(122, 73);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(200, 20);
            this.dtpNascimento.TabIndex = 3;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(122, 99);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(200, 20);
            this.txtTelefone.TabIndex = 4;
            this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIdade
            // 
            this.txtIdade.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(122, 47);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(200, 20);
            this.txtIdade.TabIndex = 2;
            this.txtIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCadDoc
            // 
            this.btnCadDoc.BackgroundImage = global::prjTupperControl.Properties.Resources.ID;
            this.btnCadDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadDoc.FlatAppearance.BorderSize = 0;
            this.btnCadDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadDoc.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadDoc.Location = new System.Drawing.Point(286, 498);
            this.btnCadDoc.Name = "btnCadDoc";
            this.btnCadDoc.Size = new System.Drawing.Size(127, 74);
            this.btnCadDoc.TabIndex = 36;
            this.btnCadDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadDoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadDoc.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::prjTupperControl.Properties.Resources.floppy_128x128_By_Freepik;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(659, 498);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 74);
            this.btnSalvar.TabIndex = 40;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(prjTupperControl.Model.Clientes);
            // 
            // frmCadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 590);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCadDoc);
            this.Controls.Add(this.grbOutrasInformacoes);
            this.Controls.Add(this.grbEndereco);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCadClientes";
            this.Text = "frmCadClientes";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.grbEndereco, 0);
            this.Controls.SetChildIndex(this.grbOutrasInformacoes, 0);
            this.Controls.SetChildIndex(this.btnCadDoc, 0);
            this.Controls.SetChildIndex(this.btnSalvar, 0);
            this.grbOutrasInformacoes.ResumeLayout(false);
            this.grbOutrasInformacoes.PerformLayout();
            this.grbEndereco.ResumeLayout(false);
            this.grbEndereco.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbOutrasInformacoes;
        private System.Windows.Forms.GroupBox grbEndereco;
        private System.Windows.Forms.TextBox txtNumeroCasa;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.RichTextBox rtxtObsEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxtObs;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button btnCadDoc;
        private System.Windows.Forms.TextBox txtCorPreferida;
        private System.Windows.Forms.CheckBox chkPagaEmDia;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.BindingSource clientesBindingSource;
    }
}