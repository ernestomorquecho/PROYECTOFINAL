using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProyectoFinal
{
    public class ProductosTienda
    {
        private int id;
        private string imagen;
        private string nombre;
        private string descripcion;
        private int precio;
        private int existencias;

        public ProductosTienda()
        {

        }

        public ProductosTienda(int id, string imagen, string nombre, string descripcion, int precio, int existencias)
        {
            this.Id = id;
            this.Imagen = imagen;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Precio = precio;
            this.Existencias = existencias;
        }

        public int Id { get => id; set => id = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Existencias { get => existencias; set => existencias = value; }
    }
}
