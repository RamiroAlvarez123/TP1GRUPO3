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
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void btnEjUno_Click(object sender, EventArgs e)
        {
            FormEjUno formEjUno = new FormEjUno(this);
            formEjUno.Show();
            this.Hide();
        }

        private void btnEjDos_Click(object sender, EventArgs e)
        {
            FormEjDos formEjDos = new FormEjDos(this);
            formEjDos.Show();
            this.Hide();
        }

        private void btnEjTres_Click(object sender, EventArgs e)
        {
            FormEjTres formEjTres = new FormEjTres(this);
            formEjTres.Show();
            this.Hide();
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
