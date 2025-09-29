
using System;
using System.Windows.Forms;

namespace SistemaDeArchivo_Gerarquico
{
    public partial class Form1 : Form
    {
        private ArbolSistemaArchivos sistemaArchivos;

        public Form1()
        {
            InitializeComponent();
            sistemaArchivos = new ArbolSistemaArchivos();
            CargarEstructuraEjemplo();
            ActualizarVisualizacion();
        }

        private void CargarEstructuraEjemplo()
        {
            sistemaArchivos.AgregarNodo("/root", "documentos", TipoNodo.Carpeta);
            sistemaArchivos.AgregarNodo("/root/documentos", "cv.docx", TipoNodo.Archivo);
            sistemaArchivos.AgregarNodo("/root/documentos", "tesis.pdf", TipoNodo.Archivo);

            sistemaArchivos.AgregarNodo("/root", "fotos", TipoNodo.Carpeta);
            sistemaArchivos.AgregarNodo("/root/fotos", "vacaciones", TipoNodo.Carpeta);
            sistemaArchivos.AgregarNodo("/root/fotos/vacaciones", "playa.jpg", TipoNodo.Archivo);
            sistemaArchivos.AgregarNodo("/root/fotos/vacaciones", "montaña.jpg", TipoNodo.Archivo);
            sistemaArchivos.AgregarNodo("/root/fotos", "perfil.jpg", TipoNodo.Archivo);

            sistemaArchivos.AgregarNodo("/root", "sistema", TipoNodo.Carpeta);
            sistemaArchivos.AgregarNodo("/root/sistema", "config.sys", TipoNodo.Archivo);
        }

        public void ActualizarVisualizacion()
        {
            txtEstructura.Text = sistemaArchivos.ObtenerEstructuraArbol();
            var (carpetas, archivos) = sistemaArchivos.ContarElementos();
            lblEstadisticas.Text = $"Carpetas: {carpetas} | Archivos: {archivos}";
        }

        private void btnAgregarCarpeta_Click(object sender, EventArgs e)
        {
            string rutaPadre = txtRutaPadre.Text.Trim();
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Debe ingresar un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(rutaPadre))
                rutaPadre = "/root";

            bool exito = sistemaArchivos.AgregarNodo(rutaPadre, nombre, TipoNodo.Carpeta);

            if (exito)
            {
                MessageBox.Show($"Carpeta '{nombre}' creada en {rutaPadre}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Clear();
                ActualizarVisualizacion();
            }
            else
            {
                MessageBox.Show("No se pudo crear la carpeta. Verifique la ruta padre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarArchivo_Click(object sender, EventArgs e)
        {
            string rutaPadre = txtRutaPadre.Text.Trim();
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Debe ingresar un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(rutaPadre))
                rutaPadre = "/root";

            bool exito = sistemaArchivos.AgregarNodo(rutaPadre, nombre, TipoNodo.Archivo);

            if (exito)
            {
                MessageBox.Show($"Archivo '{nombre}' creado en {rutaPadre}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Clear();
                ActualizarVisualizacion();
            }
            else
            {
                MessageBox.Show("No se pudo crear el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string ruta = txtRutaEliminar.Text.Trim();

            if (string.IsNullOrEmpty(ruta))
            {
                MessageBox.Show("Ingrese la ruta del elemento a eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show($"¿Eliminar '{ruta}'?\nSe eliminará todo su contenido.", 
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                bool exito = sistemaArchivos.EliminarNodo(ruta);

                if (exito)
                {
                    MessageBox.Show("Elemento eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRutaEliminar.Clear();
                    ActualizarVisualizacion();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar. Verifique la ruta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Reiniciar el sistema?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                sistemaArchivos = new ArbolSistemaArchivos();
                CargarEstructuraEjemplo();
                ActualizarVisualizacion();
                txtNombre.Clear();
                txtRutaPadre.Text = "/root";
                txtRutaEliminar.Clear();
                MessageBox.Show("Sistema reiniciado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Persona 2 implementará esta función", "En desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRutaAbsoluta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Persona 2 implementará esta función", "En desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPreOrden_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Persona 3 implementará esta función", "En desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPostOrden_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Persona 3 implementará esta función", "En desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBFS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Persona 3 implementará esta función", "En desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnListarArchivos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Persona 3 implementará esta función", "En desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Persona 3 implementará esta función", "En desarrollo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Evento vacío - no es necesario aquí
        }
    }
}