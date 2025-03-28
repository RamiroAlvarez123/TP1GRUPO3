using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            bool duplicado = false;

            if (txtNombres.Text != "")
            {
                foreach (string nombre in lbNombres.Items)
                {
                    if (txtNombres.Text.Trim().ToUpper() == nombre.ToUpper()) { duplicado = true; }
                }
                if (!duplicado)
                {
                    lbNombres.Items.Add(txtNombres.Text.Trim());
                    txtNombres.Text = "";
                }
                else { MessageBox.Show("el nombre ya se encuentra en las listas"); }
                    
            }
            else
            {
                MessageBox.Show("Ingrese un nombre");
            }

        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbNombres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           //Traspasar los strings seleccionados de un ListBox a otro y validar que haya al menos un item seleccionado.
           if(lbNombres.SelectedItems.Count > 0)
            {
                foreach(string item in lbNombres.SelectedItems)
                {
                    lbSalida.Items.Add(item.ToString()); 
                }
           }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un item.");
            }
        }
    }
}
