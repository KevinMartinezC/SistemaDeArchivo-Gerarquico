using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeArchivo_Gerarquico
{
    // Enumeracion para el tipo de nod 
    public enum TipoNodo
    {
        Archivo,
        Carpeta
    }
    
    internal class NodeArchivo
    {
        //Propiedades del nodo 
        public string Nombre { get; set; }
        public TipoNodo Tipo { get; set; }
        public List<NodeArchivo> Hijos { get; set; }
        public NodeArchivo? Padre { get; set; }

        // Constructor: crea un nuevo nodo con el nombre, tipo y padre especificados
        public NodeArchivo(string nombre, TipoNodo tipo)
        {
            Nombre = nombre;
            Tipo = tipo;
            Hijos = new List<NodeArchivo>();
            Padre = null;
        }

        //Agrega un hijo a este nodo si es una carpeta y no existe un hijo con el mismo nombre

        public bool AgregarHijo(NodeArchivo hijo)
        {
            if( this.Tipo != TipoNodo.Carpeta)
            {
                return false; // No se pueden agregar hijos a un archivo
            }

            if (Hijos.Any(h => h.Nombre == hijo.Nombre))
            {
                return false; // Ya existe un hijo con el mismo nombre
            }
            hijo.Padre = this;
            Hijos.Add(hijo);
            return true;
        }

        // Elimina un hijo por nombre y actualiza la referencia del padre del hijo eliminado
        public bool EliminarHijo(string nombreHijo)
        {
            var hijo = Hijos.FirstOrDefault(h => h.Nombre == nombreHijo);
            if (hijo != null)
            {
                hijo.Padre = null;
                Hijos.Remove(hijo);
                return true;
            }
            return false; // No se encontró el hijo
        }

        public string ObtenerRutaAbsoluta()
        {
            if (Padre == null)
            {
                return "/" + Nombre; // Nodo raíz
            }
            return Padre.ObtenerRutaAbsoluta() + "/" + Nombre;
        }

        public bool EsHoja()
        {
            return Tipo == TipoNodo.Archivo || Hijos.Count == 0;
        }

        public int ObtenerCantidadDescendientes()
        {
            if (Tipo == TipoNodo.Archivo)
            {
                return 0; // Los archivos no tienen descendientes
            }
            int count = Hijos.Count;
            foreach (var hijo in Hijos)
            {
                count += hijo.ObtenerCantidadDescendientes();
            }
            return count;
        }

        public override string ToString()
        {
            return $"{(Tipo == TipoNodo.Carpeta ? "Carpeta" : "Archivo")}: {Nombre}";
        }
    }
}
