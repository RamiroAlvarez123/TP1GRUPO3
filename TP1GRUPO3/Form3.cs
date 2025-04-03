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


        //se debe completar los dos elementos nombre y apellido para que se pueda agregar a la lista
        private void btnAgrgar_Click(object sender, EventArgs e)
        {
            
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido))
            {
                MessageBox.Show("Debe completar ambos campos: Nombre y Apellido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            string NombreCompleto = $"{apellido} {nombre}";
            bool repetido = false;

            foreach (var item in lbSalida.Items)
            {
                if (item.ToString().Equals(NombreCompleto, StringComparison.OrdinalIgnoreCase))
                {
                    repetido = true;
                    break;
                }
            }

            // Evita nombres repetidos
            if (! repetido)
            {
                lbSalida.Items.Add(NombreCompleto);
                lbSalida.Sorted = true;
                txtNombre.Clear();
                txtApellido.Clear();
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Este nombre y apellido ya han sido ingresados.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ///utilize el comando remove para eleminar los elementos de la lista seleccionados.
            if (lbSalida.SelectedItem != null)
            {
                List<string> itemRemove = new List<string>();

                foreach (string item in lbSalida.SelectedItems)
                {
                    itemRemove.Add(item);
                }

                foreach (string item in itemRemove)
                {
                    lbSalida.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento para borrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

       
     


        private void FormEjDos_Load(object sender, EventArgs e)
        {

        }

        private void lbSalida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
