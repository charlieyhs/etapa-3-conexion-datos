using etapa3conexiondatos.conexion;
using etapa3conexiondatos.DTO;
using etapa3conexiondatos.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace etapa3conexiondatos
{
    public partial class FormEditarNuevo : Form 
    {
        private const string TEXTO_ACTUALIZAR = "Actualizar";
        private IListenerAgregarRegistro listenerAgregarRegistro;
        private string nombreImagen;
        public FormEditarNuevo()
        {
            InitializeComponent();
        }
        public FormEditarNuevo(IListenerAgregarRegistro listenerAgregarRegistro)
        {
            InitializeComponent();
            this.listenerAgregarRegistro = listenerAgregarRegistro;
            btnEliminar.Visible = false;
            pictureImg.SizeMode = PictureBoxSizeMode.Zoom;
        }
        
        public FormEditarNuevo(EmpleadoDTO empleado,
                               IListenerAgregarRegistro listenerAgregarRegistro)
        {
            InitializeComponent();
            this.listenerAgregarRegistro = listenerAgregarRegistro;
            btnEliminar.Visible = true;
            btnGuardar.Text = TEXTO_ACTUALIZAR;
            pictureImg.SizeMode = PictureBoxSizeMode.Zoom;
            inputNroIdentidad.Text = empleado.nrodocidentidad;
            inputNombres.Text = empleado.nombres;
            inputApellidos.Text = empleado.apellidos;
            inputTelefono.Text = empleado.numerotel;
            inputCargo.Text = empleado.cargo;
            inputOficina.Text = empleado.oficina;
            if(empleado.datosfoto != null)
            {
                using (MemoryStream ms = new MemoryStream(empleado.datosfoto))
                {
                    pictureImg.Image = Image.FromStream(ms);
                }
            }
            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (pictureImg.Image == null)
            {
                MessageBox.Show("Cargue una imagen antes de guardarla.");
                return;
            }
            try
            {
                validacionDatos(inputNroIdentidad, inputNombres, inputApellidos, inputTelefono, inputCargo, inputOficina);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Datos Incompletos");
                return;
            }

            byte[] datosImagen;
            using (MemoryStream ms = new MemoryStream())
            {
                pictureImg.Image.Save(ms, pictureImg.Image.RawFormat);
                datosImagen = ms.ToArray();
            }

            

            EmpleadoDTO empleado = new EmpleadoDTO();
            empleado.nrodocidentidad = inputNroIdentidad.Text;
            empleado.nombres = inputNombres.Text;
            empleado.apellidos = inputApellidos.Text;
            empleado.numerotel = inputTelefono.Text;
            empleado.cargo = inputCargo.Text;
            empleado.oficina = inputOficina.Text;
            empleado.foto = nombreImagen;
            empleado.datosfoto = datosImagen;
            if (btnGuardar.Text == TEXTO_ACTUALIZAR)
            {
                new Conexion().actualizar(empleado);
            }
            else
            {
                new Conexion().insertar(empleado);
            }
            
            listenerAgregarRegistro.eventoAbrirFormulario(new FormDatos(listenerAgregarRegistro));
        }
        private void validacionDatos(params TextBox[] inputs)
        {
            foreach (TextBox input in inputs)
            {
                if (input.Text == null || input.Text.Trim() == "")
                {
                    throw new Exception("Debe rellenar todos los campos.");
                }
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            listenerAgregarRegistro.eventoAbrirFormulario(new FormDatos(listenerAgregarRegistro));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(inputNroIdentidad.Text == null || inputNroIdentidad.Text.Trim() == "")
            {
                MessageBox.Show("Debe digitar un nro de identificación.", "Datos Incompletos");
                return;
            }
            EmpleadoDTO empleado = new EmpleadoDTO();
            empleado.nrodocidentidad = inputNroIdentidad.Text;
            new Conexion().eliminar(empleado);
            listenerAgregarRegistro.eventoAbrirFormulario(new FormDatos(listenerAgregarRegistro));
        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog.Title = "Seleccionar imagen";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = openFileDialog.FileName;

                nombreImagen = Path.GetFileName(rutaImagen);
                pictureImg.Image = Image.FromFile(rutaImagen);

            }
        }

        private void inputNroIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionNumero(e);
        }

        private void inputTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacionNumero(e);
        }
        private void validacionNumero(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
