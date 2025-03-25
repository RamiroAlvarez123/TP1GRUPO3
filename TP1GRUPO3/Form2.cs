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
    }
}
