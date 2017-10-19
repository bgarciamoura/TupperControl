namespace prjTupperControl.View
{
    partial class frmCadDocs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadDocs));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnUpFotos = new System.Windows.Forms.Button();
            this.tipEscolherDoc = new System.Windows.Forms.ToolTip(this.components);
            this.pnlDocs = new System.Windows.Forms.Panel();
            this.ofdBuscaFoto = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = global::prjTupperControl.Properties.Resources.cross_64x64_By_Freepik;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(196, 209);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 72);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tipEscolherDoc.SetToolTip(this.btnCancelar, "Cancelar o cadastro do documento");
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Items.AddRange(new object[] {
            "Certidão de Casamento",
            "Certidão de Nascimento",
            "CNH",
            "Comprovante de Endereço",
            "CPF",
            "RG"});
            this.cmbTipoDocumento.Location = new System.Drawing.Point(41, 71);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(195, 24);
            this.cmbTipoDocumento.Sorted = true;
            this.cmbTipoDocumento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Qual Documento?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número do Documento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(41, 144);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(195, 20);
            this.txtNumero.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::prjTupperControl.Properties.Resources.floppy_128x128_By_Freepik;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(12, 207);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 74);
            this.btnSalvar.TabIndex = 37;
            this.tipEscolherDoc.SetToolTip(this.btnSalvar, "Salvar o Documento Informado");
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnUpFotos
            // 
            this.btnUpFotos.BackColor = System.Drawing.Color.Transparent;
            this.btnUpFotos.BackgroundImage = global::prjTupperControl.Properties.Resources.picture_64x64_By_Smashicons;
            this.btnUpFotos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpFotos.FlatAppearance.BorderSize = 0;
            this.btnUpFotos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpFotos.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpFotos.Location = new System.Drawing.Point(103, 209);
            this.btnUpFotos.Name = "btnUpFotos";
            this.btnUpFotos.Size = new System.Drawing.Size(76, 72);
            this.btnUpFotos.TabIndex = 38;
            this.btnUpFotos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tipEscolherDoc.SetToolTip(this.btnUpFotos, "Procurar a foto do documento");
            this.btnUpFotos.UseVisualStyleBackColor = false;
            this.btnUpFotos.Click += new System.EventHandler(this.btnUpFotos_Click);
            // 
            // tipEscolherDoc
            // 
            this.tipEscolherDoc.AutoPopDelay = 5000;
            this.tipEscolherDoc.InitialDelay = 800;
            this.tipEscolherDoc.IsBalloon = true;
            this.tipEscolherDoc.ReshowDelay = 100;
            // 
            // pnlDocs
            // 
            this.pnlDocs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDocs.Location = new System.Drawing.Point(3, 3);
            this.pnlDocs.Name = "pnlDocs";
            this.pnlDocs.Size = new System.Drawing.Size(279, 287);
            this.pnlDocs.TabIndex = 39;
            // 
            // ofdBuscaFoto
            // 
            this.ofdBuscaFoto.FileName = "Doc00001";
            this.ofdBuscaFoto.Filter = "\"Arquivos de Imagem (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe;" +
    " *.jfif; *.png\"";
            // 
            // frmCadDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(284, 293);
            this.ControlBox = false;
            this.Controls.Add(this.btnUpFotos);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTipoDocumento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlDocs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadDocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnUpFotos;
        private System.Windows.Forms.ToolTip tipEscolherDoc;
        private System.Windows.Forms.Panel pnlDocs;
        private System.Windows.Forms.OpenFileDialog ofdBuscaFoto;
    }
}