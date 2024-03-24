using etapa3conexiondatos.conexion;
using etapa3conexiondatos.DTO;
using etapa3conexiondatos.Interfaces;
using System;
using System.Windows.Forms;

namespace etapa3conexiondatos
{
    public partial class FormDatos : Form
    {
        private IListenerAgregarRegistro listenerAgregarRegistro;
        public FormDatos()
        {
            InitializeComponent();
        }
        public FormDatos(IListenerAgregarRegistro listenerAgregarRegistro)
        {
            this.listenerAgregarRegistro = listenerAgregarRegistro;
            InitializeComponent();
            listadodatos.ReadOnly = true;
            refresh();
            listadodatos.Columns["datosfoto"].Visible = false;
        }
        private void refresh()
        {
            Conexion conn = new Conexion();
            listadodatos.DataSource = conn.getEmpleados();
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            listenerAgregarRegistro.eventoAbrirFormulario(new FormEditarNuevo(listenerAgregarRegistro));
        }

        private void listadodatos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indiceFila = e.RowIndex;
            if (indiceFila < 0)
            {
                return;
            }
            DataGridViewRow filaClickeada = listadodatos.Rows[indiceFila];

            EmpleadoDTO empleado = new EmpleadoDTO();
            empleado.nrodocidentidad = filaClickeada.Cells["nrodocidentidad"].Value.ToString();
            empleado.nombres = filaClickeada.Cells["nombres"].Value.ToString();
            empleado.apellidos = filaClickeada.Cells["apellidos"].Value.ToString();
            empleado.numerotel = filaClickeada.Cells["numerotel"].Value.ToString();
            empleado.cargo = filaClickeada.Cells["cargo"].Value.ToString();
            empleado.oficina = filaClickeada.Cells["oficina"].Value.ToString();
            object valorDatosFoto = filaClickeada.Cells["datosfoto"].Value;
            empleado.datosfoto = valorDatosFoto != null ? (byte[])valorDatosFoto : null;
            listenerAgregarRegistro.eventoAbrirFormulario(new FormEditarNuevo(empleado, listenerAgregarRegistro));

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (inputbuscar.Text == null || inputbuscar.Text.Trim() == "")
            {
                MessageBox.Show("Debe digitar un nro de identificación.", "Datos Incompletos");
                return;
            }
            Conexion conn = new Conexion();
            listadodatos.DataSource = conn.getEmpleados(true, inputbuscar.Text);
        }

        private void btnLimpiarFiltro_Click(object sender, EventArgs e)
        {
            Conexion conn = new Conexion();
            listadodatos.DataSource = conn.getEmpleados();
        }
    }
}
