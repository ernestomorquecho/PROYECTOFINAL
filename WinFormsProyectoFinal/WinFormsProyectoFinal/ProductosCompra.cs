namespace WinFormsProyectoFinal
{
    public class ProductosCompra
    {
        public int IdCompra { get; set; }
        public string Producto { get; set; }
        public string Usuario { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }

        public ProductosCompra()
        {
        }

        public ProductosCompra(int idCompra, string producto, string usuario, int cantidad, int precio)
        {
            IdCompra = idCompra;
            Producto = producto;
            Usuario = usuario;
            Cantidad = cantidad;
            Precio = precio;
        }
    }
}
