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
    }
}
