namespace prjTupperControl.View
{
    partial class frmEndereco
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
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label logradouroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cepLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEndereco));
            this.grbEndereco = new System.Windows.Forms.GroupBox();
            this.txtNumeroCasa = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.rtxtObsEndereco = new System.Windows.Forms.RichTextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            numeroLabel = new System.Windows.Forms.Label();
            logradouroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            this.grbEndereco.SuspendLayout();
            this.SuspendLayout();
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
            this.grbEndereco.Location = new System.Drawing.Point(5, 6);
            this.grbEndereco.Name = "grbEndereco";
            this.grbEndereco.Size = new System.Drawing.Size(344, 287);
            this.grbEndereco.TabIndex = 34;
            this.grbEndereco.TabStop = false;
            this.grbEndereco.Text = "Endereço";
            // 
            // txtNumeroCasa
            // 
            this.txtNumeroCasa.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCasa.Location = new System.Drawing.Point(122, 72);
            this.txtNumeroCasa.Name = "txtNumeroCasa";
            this.txtNumeroCasa.Size = new System.Drawing.Size(205, 20);
            this.txtNumeroCasa.TabIndex = 3;
            this.txtNumeroCasa.Tag = "Número";
            this.txtNumeroCasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // txtLogradouro
            // 
            this.txtLogradouro.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogradouro.Location = new System.Drawing.Point(122, 46);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(205, 20);
            this.txtLogradouro.TabIndex = 2;
            this.txtLogradouro.Tag = "Logradouro";
            this.txtLogradouro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(122, 20);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(205, 20);
            this.txtCidade.TabIndex = 1;
            this.txtCidade.Tag = "Cidade";
            this.txtCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // rtxtObsEndereco
            // 
            this.rtxtObsEndereco.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtObsEndereco.Location = new System.Drawing.Point(24, 172);
            this.rtxtObsEndereco.Name = "rtxtObsEndereco";
            this.rtxtObsEndereco.Size = new System.Drawing.Size(303, 108);
            this.rtxtObsEndereco.TabIndex = 6;
            this.rtxtObsEndereco.Text = "";
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
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(122, 98);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(205, 20);
            this.txtBairro.TabIndex = 4;
            this.txtBairro.Tag = "Bairro";
            this.txtBairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(122, 124);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(205, 20);
            this.txtCep.TabIndex = 5;
            this.txtCep.Tag = "CEP";
            this.txtCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::prjTupperControl.Properties.Resources.floppy_128x128_By_Freepik;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(139, 299);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 74);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // frmEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(354, 379);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grbEndereco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEndereco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Endereço";
            this.grbEndereco.ResumeLayout(false);
            this.grbEndereco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEndereco;
        private System.Windows.Forms.TextBox txtNumeroCasa;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.RichTextBox rtxtObsEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Button btnSalvar;
    }
}