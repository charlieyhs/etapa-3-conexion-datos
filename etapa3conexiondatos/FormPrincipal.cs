using etapa3conexiondatos.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etapa3conexiondatos
{
    public partial class FormPrincipal : Form, IListenerAgregarRegistro
    {
        private Form formularioActivo = null;
        public FormPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            mostrarPanelHijo(new FormDatos(this));
        }
        
        private void mostrarPanelHijo(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlcontenedor.Controls.Add(formularioHijo);
            pnlcontenedor.Tag = formularioHijo;
            formularioHijo.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
        }
        
        
        public void eventoAbrirFormulario(Form formulario)
        {
            mostrarPanelHijo(formulario);
        }
    }
}
