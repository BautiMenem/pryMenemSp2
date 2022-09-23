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
    }
}
