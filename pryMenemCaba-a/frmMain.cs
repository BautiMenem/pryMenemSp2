using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMenemCabaña
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstTipo.SelectedIndex = 0;
            
            txtDias.SelectedText = "1";

            lstPersonas.SelectedIndex = 0;

            
        }

        private void lstTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTipo.SelectedIndex != -1)
            {
                lstPersonas.Enabled = true;
            }
            else
            {
                lstPersonas.Enabled = false;
            }

            if (lstTipo.Text == "Tipo A")
            {
                lstPersonas.Items.Clear();  
                lstPersonas.Items.Add(1);
                lstPersonas.Items.Add(2);
                lstPersonas.Items.Add(3);
                lstPersonas.Items.Add(4);
            }
        
            if(lstTipo.Text == "Tipo B")
            {
                lstPersonas.Items.Clear();
                lstPersonas.Items.Add(1);
                lstPersonas.Items.Add(2);
                lstPersonas.Items.Add(3);
                lstPersonas.Items.Add(4);
                lstPersonas.Items.Add(5);
                lstPersonas.Items.Add(6);
                lstPersonas.Items.Add(7);
                lstPersonas.Items.Add(8);
                
            }    
            
        }

        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPersonas.SelectedIndex != -1)
            {
                txtDias.Enabled = true;

            }
            else
            {
                txtDias.Enabled = false;
            }
        }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (optEfectivo.Checked == true)
            {
                lstTarjetas.Enabled = false;
            }
            else
            {
                lstTarjetas.Enabled= true;
            }
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            string ValorSeleccionado = txtDias.Text.ToString();
            int ValorComparacion = 0;

            if (!int.TryParse(ValorSeleccionado, out ValorComparacion))
            {
                MessageBox.Show("Ingrese un Valor Numérico");
                this.txtDias.Clear();
            }
            else if (ValorComparacion <= 0)
            {
                MessageBox.Show("Ingrese un valor mayor a cero");
            }
          
            if (txtDias.Text != "")
            {
                mrcAdi.Enabled = true;
               mrcForma.Enabled = true;
            }
            else
            {
                mrcAdi.Enabled = false;
                mrcForma.Enabled = false;
            }        
        }

        private void mrcForma_Enter(object sender, EventArgs e)
        {

        }

        private void opTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (optTarjeta.Checked == true)
            {
                lstTarjetas.SelectedIndex = 0;
            }
            else
            {
                lstTarjetas.SelectedIndex = -1;
            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtDias.Text) > 0 && txtNom.Text != "" && txtTel.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            float precio = 0;

            int personas = Int32.Parse(lstPersonas.Text.ToString());
            int dias = Int32.Parse(txtDias.Text.ToString());

            if (lstTipo.Text == "Tipo A" )
            {
                precio = 20;
                if (chkTele.Checked)
                {
                    precio = precio + (dias * 1);
                }
                else if (chkCocina.Checked)
                {
                    precio = precio + (float)(dias * 1.5);
                }
                else if (chkHeladera.Checked)
                {
                    precio = precio + (dias * 2);
                }

                precio = precio + ((personas * 1) * dias);
                

            }
            else if (lstTipo.Text == "Tipo B")
            {
                precio = 34;
                if (chkTele.Checked)
                {
                    precio = precio + (dias * 1);
                }
                else if (chkCocina.Checked)
                {
                    precio = precio + (float)(dias * 1.5);
                }
                else if (chkHeladera.Checked)
                {
                    precio = precio + (dias * 2);
                }

                precio = precio + ((personas * 1) * dias);
            }

            if (optTarjeta.Checked && lstTarjetas.Text == "Card Red (Recargo 10%)")
            {
                precio = precio + (float)(precio * 0.1);
            }
            else if (optTarjeta.Checked && lstTarjetas.Text == "Card Green (Recargo 20%)" || lstTarjetas.Text == "Card Blue (Recargo 20%)")
            {
                precio = precio + (float)(precio * 0.2);
            }

            MessageBox.Show("El costo total es de:  " + precio);
        
            lstTarjetas.Items.Clear();
            lstTipo.SelectedIndex = 0;
            lstPersonas.SelectedIndex = 0;
            txtDias.Text = "1";
            chkCocina.Checked = false;
            chkHeladera.Checked = false;
            chkTele.Checked = false;
            optEfectivo.Checked = true;
            txtNom.Text = "";
            txtTel.Text = "";

        }
    }
}
