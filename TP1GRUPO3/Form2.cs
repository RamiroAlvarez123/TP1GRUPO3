using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1GRUPO3
{
    public partial class FormEjUno : Form
    {
        FormularioPrincipal formularioPrincipal;
        public FormEjUno(FormularioPrincipal formularioPrincipal)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;
        }

        private void FormEjUno_FormClosed(object sender, FormClosedEventArgs e)
        {
            formularioPrincipal.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Ingreso de string,validar ingreso de valeres en blanco, uso de trim para espacio en blanco.
            // Agregue listbox, button,label,texbox

            if (txtNombres.Text != "")
            {
                lbNombres.Items.Add(txtNombres.Text.Trim());
                txtNombres.Text = "";
            }
            else
            {
                MessageBox.Show("Ingrese un nombre");
            }

        }
    }
}
