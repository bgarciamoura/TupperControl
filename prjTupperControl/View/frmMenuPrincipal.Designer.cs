namespace prjTupperControl
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.pnlDireita = new System.Windows.Forms.Panel();
            this.btnPecas = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConsorcio = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnConsultoras = new System.Windows.Forms.Button();
            this.pnlDireita.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDireita
            // 
            this.pnlDireita.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDireita.Controls.Add(this.btnPecas);
            this.pnlDireita.Controls.Add(this.btnSair);
            this.pnlDireita.Controls.Add(this.btnConsorcio);
            this.pnlDireita.Controls.Add(this.btnClientes);
            this.pnlDireita.Controls.Add(this.btnConsultoras);
            this.pnlDireita.Location = new System.Drawing.Point(-1, 0);
            this.pnlDireita.Name = "pnlDireita";
            this.pnlDireita.Size = new System.Drawing.Size(146, 584);
            this.pnlDireita.TabIndex = 0;
            // 
            // btnPecas
            // 
            this.btnPecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPecas.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPecas.Image = global::prjTupperControl.Properties.Resources.bowl_64x64_By_Smashicons;
            this.btnPecas.Location = new System.Drawing.Point(11, 355);
            this.btnPecas.Name = "btnPecas";
            this.btnPecas.Size = new System.Drawing.Size(117, 109);
            this.btnPecas.TabIndex = 4;
            this.btnPecas.Tag = "Pecas";
            this.btnPecas.Text = "Peças\r\n(F4)";
            this.btnPecas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPecas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPecas.UseVisualStyleBackColor = true;
            this.btnPecas.Click += new System.EventHandler(this.btnPecas_Click);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::prjTupperControl.Properties.Resources.exit_64x64_By_Smashicons;
            this.btnSair.Location = new System.Drawing.Point(11, 470);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(117, 109);
            this.btnSair.TabIndex = 3;
            this.btnSair.Tag = "Sair";
            this.btnSair.Text = "Sair\r\n(F9)";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConsorcio
            // 
            this.btnConsorcio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsorcio.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsorcio.Image = global::prjTupperControl.Properties.Resources.girl_Consorcio_64x64_By_Freepik;
            this.btnConsorcio.Location = new System.Drawing.Point(11, 240);
            this.btnConsorcio.Name = "btnConsorcio";
            this.btnConsorcio.Size = new System.Drawing.Size(117, 109);
            this.btnConsorcio.TabIndex = 2;
            this.btnConsorcio.Tag = "Excluir";
            this.btnConsorcio.Text = "Consórcio \r\n(F3)";
            this.btnConsorcio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsorcio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsorcio.UseVisualStyleBackColor = true;
            this.btnConsorcio.Click += new System.EventHandler(this.btnConsorcio_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Image = global::prjTupperControl.Properties.Resources.girl_Cliente_64x64_By_Freepik;
            this.btnClientes.Location = new System.Drawing.Point(11, 125);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(117, 109);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Tag = "Ver Dados";
            this.btnClientes.Text = "Clientes \r\n(F2)";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnConsultoras
            // 
            this.btnConsultoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultoras.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultoras.Image = global::prjTupperControl.Properties.Resources.girl_Consultora_64x64_By_Freepik;
            this.btnConsultoras.Location = new System.Drawing.Point(11, 10);
            this.btnConsultoras.Name = "btnConsultoras";
            this.btnConsultoras.Size = new System.Drawing.Size(117, 109);
            this.btnConsultoras.TabIndex = 0;
            this.btnConsultoras.Tag = "Cadastro";
            this.btnConsultoras.Text = "Consultoras (F1)";
            this.btnConsultoras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConsultoras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConsultoras.UseVisualStyleBackColor = true;
            this.btnConsultoras.Click += new System.EventHandler(this.btnConsultoras_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(957, 584);
            this.Controls.Add(this.pnlDireita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tupper Control";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMenuPrincipal_KeyDown);
            this.pnlDireita.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlDireita;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConsorcio;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnConsultoras;
        private System.Windows.Forms.Button btnPecas;
    }
}

