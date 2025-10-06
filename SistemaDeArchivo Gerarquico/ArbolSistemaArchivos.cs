
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemaDeArchivo_Gerarquico
{
    internal class ArbolSistemaArchivos
    {
        public NodeArchivo Raiz { get; set; }

        public ArbolSistemaArchivos()
        {
            Raiz = new NodeArchivo("root", TipoNodo.Carpeta);
        }

        // Metodo para buscar un nodo por su ruta
        public NodeArchivo? BuscarNodoPorRuta(string ruta)
        {
            if (string.IsNullOrEmpty(ruta) || ruta == "/" || ruta == "/root")
            {
                return Raiz; // Retorna la raiz si la ruta es vacia o "/"
            }

            var partesRuta = ruta.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            var nodoActual = Raiz;

            // Saltar "root" si está presente
            int inicio = (partesRuta.Length > 0 && partesRuta[0] == "root") ? 1 : 0;

            for (int i = inicio; i < partesRuta.Length; i++)
            {
                nodoActual = nodoActual.Hijos.FirstOrDefault(h => h.Nombre == partesRuta[i]);
                if (nodoActual == null)
                {
                    return null; // No se encontro el nodo en la ruta
                }
            }

            return nodoActual;
        }

        // Metodo para agregar un nuevo nodo en una ruta especifica
        public bool AgregarNodo(string rutaPadre, string nombreNuevoNodo, TipoNodo tipoNuevoNodo)
        {
            var nodoPadre = BuscarNodoPorRuta(rutaPadre);
            if (nodoPadre == null || nodoPadre.Tipo != TipoNodo.Carpeta)
            {
                return false; // No se encontro el padre o el padre no es una carpeta
            }

            var nuevoNodo = new NodeArchivo(nombreNuevoNodo, tipoNuevoNodo);
            return nodoPadre.AgregarHijo(nuevoNodo);
        }

        // Metodo para eliminar un nodo por su ruta
        public bool EliminarNodo(string ruta)
        {
            var partesRuta = ruta.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

            if (partesRuta.Length == 0 || (partesRuta.Length == 1 && partesRuta[0] == "root"))
            {
                return false; // No se puede eliminar la raiz
            }

            var nombreNodoAEliminar = partesRuta.Last();
            var rutaPadre = string.Join("/", partesRuta.Take(partesRuta.Length - 1));

            if (string.IsNullOrEmpty(rutaPadre) || rutaPadre == "root")
            {
                rutaPadre = "/root";
            }

            var nodoPadre = BuscarNodoPorRuta(rutaPadre);
            if (nodoPadre == null || nodoPadre.Tipo != TipoNodo.Carpeta)
            {
                return false; // No se encontro el padre o el padre no es una carpeta
            }

            return nodoPadre.EliminarHijo(nombreNodoAEliminar);
        }

        // Metodo para obtener la estructura del árbol en formato visual
        public string ObtenerEstructuraArbol()
        {
            StringBuilder sb = new StringBuilder();
            GenerarEstructuraArbol(Raiz, "", true, sb);
            return sb.ToString();
        }

        // Metodo recursivo para generar la estructura visual del árbol
        private void GenerarEstructuraArbol(NodeArchivo nodo, string indent, bool ultimo, StringBuilder sb)
        {
            sb.Append(indent);

            if (ultimo)
            {
                sb.Append("└── ");
                indent += "    ";
            }
            else
            {
                sb.Append("├── ");
                indent += "│   ";
            }

            // Agregar icono según el tipo
            string icono = nodo.Tipo == TipoNodo.Carpeta ? "📁" : "📄";
            sb.AppendLine($"{icono} {nodo.Nombre}");

            // Procesar hijos recursivamente
            for (int i = 0; i < nodo.Hijos.Count; i++)
            {
                GenerarEstructuraArbol(nodo.Hijos[i], indent, i == nodo.Hijos.Count - 1, sb);
            }
        }

        // Metodo para contar elementos del sistema (carpetas y archivos)
        public (int carpetas, int archivos) ContarElementos()
        {
            int carpetas = 0;
            int archivos = 0;
            ContarElementosRecursivo(Raiz, ref carpetas, ref archivos);
            return (carpetas, archivos);
        }

        // Metodo recursivo privado para contar elementos
        private void ContarElementosRecursivo(NodeArchivo nodo, ref int carpetas, ref int archivos)
        {
            if (nodo.Tipo == TipoNodo.Carpeta)
                carpetas++;
            else
                archivos++;

            foreach (var hijo in nodo.Hijos)
            {
                ContarElementosRecursivo(hijo, ref carpetas, ref archivos);
            }
        }

        // ============================================================
        // MÉTODOS VACÍOS - Necesitan implementación
        // ============================================================

        public void BuscarPorNombre(string nombre)
        {
            if (Raiz == null)
            {
                MessageBox.Show("No existe una ruta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } else if (nombre == "")
            {
                MessageBox.Show("Por favor ingrese el termino que busca.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else 
            {
                Queue<NodeArchivo> queue = new Queue<NodeArchivo>();
                HashSet<string> visitado = new HashSet<string>();
                HashSet<string> ruta = new HashSet<string>();

                queue.Enqueue(Raiz);
                visitado.Add(Raiz.Nombre);

                while (queue.Count > 0)
                {
                    NodeArchivo nodoActual = queue.Dequeue();

                    if (nodoActual.Nombre == nombre)
                    {
                        while (nodoActual.Nombre != "root")
                        {
                            ruta.Add(nodoActual.Nombre);
                            nodoActual = nodoActual.Padre;
                        }
                        ruta.Add(Raiz.Nombre);
                        List<string> rutaFinal = ruta.ToList();
                        rutaFinal.Reverse();

                        MessageBox.Show("Se encontro el archivo que buscaba.\nSu ruta es: " + string.Join("/", rutaFinal), "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    foreach (NodeArchivo hijo in nodoActual.Hijos)
                    {

                        if (!visitado.Contains(hijo.Nombre))
                        {
                            visitado.Add(hijo.Nombre);
                            queue.Enqueue(hijo);
                        }
                    }
                }
                MessageBox.Show("No existe una ruta para el archivo que busca.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return;
        }

        public List<string> VerInfo(string rutaAbsoluta)
        {
            List<string> archivosEncontrados = new List<string>();
            if (Raiz == null)
            {
                MessageBox.Show("No existe esa ruta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return archivosEncontrados;
            }
            else if (rutaAbsoluta == "")
            {
                MessageBox.Show("Por favor ingrese la ruta absoluta que busca.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return archivosEncontrados;
            }
            else
            {
                List<string> rutaAbsolutaList = rutaAbsoluta.Split('/').ToList();
                string carpeta = rutaAbsolutaList[^1];
                Queue<NodeArchivo> queue = new Queue<NodeArchivo>();
                HashSet<string> visitado = new HashSet<string>();
                PictureBox pictureBox = new PictureBox();

                queue.Enqueue(Raiz);
                visitado.Add(Raiz.Nombre);

                while (queue.Count > 0)
                {
                    NodeArchivo nodoActual = queue.Dequeue();

                    if (nodoActual.Nombre == carpeta)
                    {
                        if (carpeta.Length == 0)
                        {
                            MessageBox.Show("Esta carpeta no contiene archivos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        foreach (NodeArchivo archivo in nodoActual.Hijos)
                        {
                            archivosEncontrados.Add(archivo.Nombre);
                        }
                        return archivosEncontrados;
                    } else
                        foreach (NodeArchivo hijo in nodoActual.Hijos)
                        {

                            if (!visitado.Contains(hijo.Nombre))
                            {
                                visitado.Add(hijo.Nombre);
                                queue.Enqueue(hijo);
                            }
                        }
                }
                MessageBox.Show("La carpeta que busca no existe.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return archivosEncontrados;
            }
        }

        public List<string> RecorridoPreOrden()
        {
            return new List<string>();
        }

        public List<string> RecorridoPostOrden()
        {
            return new List<string>();
        }

        public List<string> RecorridoBFS()
        {
            return new List<string>();
        }

        public List<string> ListarTodosLosArchivos()
        {
            return new List<string>();
        }

        public int ObtenerProfundidadMaxima()
        {
            return 0;
        }
    }
}