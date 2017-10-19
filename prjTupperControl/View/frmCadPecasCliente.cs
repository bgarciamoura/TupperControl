using System;
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
    public partial class frmCadPecasCliente : Form
    {
        public frmCadPecasCliente()
        {
            InitializeComponent();
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex.Equals(2))
            {
                this.Height = 290;
                criaControles();
            }
            else
            {
                this.Height = 229;
                removeControles();
            }

        }

        //REMOVE A LABEL E O NUMERICUPDOWN CRIADO PARA PEÇAS JÁ COMPRADAS
        public void removeControles()
        {
            foreach (Control item in this.Controls)
            {
                if (item is NumericUpDown)
                {
                    this.Controls.RemoveAt(this.Controls.Count - 1);
                    this.Controls.RemoveAt(this.Controls.Count - 1);
                }
            }
        }

        //CRIA UMA LABEL E UM NUMERICUPDOWN PARA PEÇAS JÁ COMPRADAS
        public void criaControles()
        {
            this.Controls.AddRange(new Control[] {
                    new Label
                    {
                        Text = "Quantidade comprada:",
                        Size = new Size(180,20),
                        Location = new Point(55, 105),
                        Name = "lblQuantidade"
                    },
                    new NumericUpDown
                    {
                        Minimum = 1,
                        TextAlign = HorizontalAlignment.Right,
                        Size = new Size(270, 24),
                        Location = new Point(4, 125),
                        Name = "nudQuantidade"
                    }
                });
        }
    }
}
