using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjTupperControl.View
{
    public partial class frmCadDocs : Form
    {
        private Hashtable pessoa;

        public Hashtable Pessoa
        {
            get { return pessoa; }
            set { pessoa = value; }
        }


        public frmCadDocs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpFotos_Click(object sender, EventArgs e)
        {
            ofdBuscaFoto.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (ofdBuscaFoto.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Imagem salva");
            }
        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumero.Enabled = true;
            //MessageBox.Show(Pessoa["ID_Consultora"].ToString() + " " + Pessoa["Nome_Pessoa"].ToString());
        }
    }
}
