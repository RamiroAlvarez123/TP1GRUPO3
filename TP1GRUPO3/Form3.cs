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
    public partial class FormEjDos : Form
    {
        FormularioPrincipal formularioPrincipal;
        public FormEjDos(FormularioPrincipal formularioPrincipal)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;
        }

        private void FormEjDos_FormClosed(object sender, FormClosedEventArgs e)
        {
            formularioPrincipal.Show();
        }

        private void btlAgregar_Click(object sender, EventArgs e)
        {
            /// use variable de tipo string para concatenar el apellido y el nombre
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string NombreCompleto = apellido + " " + nombre;
            lbSalida.Items.Add(NombreCompleto);
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ///utilize el comando remove para eleminar los elementos de la lista seleccionados..
           if (lbSalida.SelectedItem != null)
            {
                lbSalida.Items.Remove(lbSalida.SelectedItem);
            }

        }
    }
}
