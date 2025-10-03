
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<NodeArchivo> BuscarPorNombre(string nombre)
        {
            return new List<NodeArchivo>();
        }

        public List<string> RecorridoPreOrden()
        {
            var listaRutas = new List<string>();
            void recorrerPreOrden(NodeArchivo nodoActual, string rutaActual)
            {
                if (nodoActual == null) return;
                listaRutas.Add(rutaActual);
                foreach (var hijo in nodoActual.Hijos)
                    recorrerPreOrden(hijo, rutaActual + "/" + hijo.Nombre);
            }
            recorrerPreOrden(Raiz, "/root");
            return listaRutas;
        }

        public List<string> RecorridoPostOrden()
        {
            var listaRutas =new List<string>();
            string RecorrerPostOrden(NodeArchivo nodoActual, string rutaActual)
            {
                if (nodoActual==null) return string.Empty;
                foreach (var hijo in nodoActual.Hijos)
                    RecorrerPostOrden(hijo, rutaActual + "/" + hijo.Nombre);
                listaRutas.Add(rutaActual);
                return rutaActual;
            }
            RecorrerPostOrden(Raiz, "/root");

            return listaRutas;
        }

        public List<string> RecorridoBFS()
        {
            var listaRutas = new List<string>();
            var q = new Queue<(NodeArchivo nodo, string ruta)>();
            q.Enqueue((Raiz, "/root"));
            while (q.Count > 0)
            {
                var (nodoActual, ruta) = q.Dequeue();
                listaRutas.Add(ruta);
                foreach (var hijo in nodoActual.Hijos)
                    q.Enqueue((hijo, ruta + "/" + hijo.Nombre));
            }
            return listaRutas;
            //return new List<string>();
        }

        public List<string> ListarTodosLosArchivos()
        {
            var listaRutas = new List<string>();
            void DFS(NodeArchivo nodoActual, string rutaActual)
            {
                if (nodoActual.Tipo == TipoNodo.Archivo) listaRutas.Add(rutaActual);
                foreach (var hijo in nodoActual.Hijos)
                    DFS(hijo, rutaActual + "/" + hijo.Nombre);
            }
            DFS(Raiz, "/root");
            return listaRutas;
        }

        public int ObtenerProfundidadMaxima()
        {
            return 0;
        }
    }
}