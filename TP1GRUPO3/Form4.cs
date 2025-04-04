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
    public partial class FormEjTres : Form
    {
        FormularioPrincipal formularioPrincipal;
        public FormEjTres(FormularioPrincipal formularioPrincipal)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;
        }

        private void FormEjTres_FormClosed(object sender, FormClosedEventArgs e)
        {
            formularioPrincipal.Show();
        }

        private void gbNombre_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clbOficios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Mensaje inicial
            string mensaje = "Usted seleccionó los siguientes elementos:\n\n";

            // Verificar qué opción de sexo está seleccionada
            if (radioFem.Checked)
            {
                mensaje += "Sexo: Femenino\n";
            }
            else if (RadioMasc.Checked)
            {
                mensaje += "Sexo: Masculino\n";
            }

            // Verificar estado civil
            if (radioCasado.Checked)
            {
                mensaje += "Estado Civil: Casado\n";
            }
            else if (radioSoltero.Checked)
            {
                mensaje += "Estado Civil: Soltero\n";
            }
            lbElementos.Show();


            lbElementos.Text = mensaje;



            lblOficio.Show();

            

            foreach (string item in clbOficios.CheckedItems)
            {
                lblOficio.Text += item + Environment.NewLine;

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormEjTres_Load(object sender, EventArgs e)
        {
            lblOficio.Hide();
            lbElementos.Hide();

        }
    }
}
