namespace PreParcial1.Modelo
{
    public class Inventario
    {
        public string product { get; set; }
        public string precio { get; set; }
        public string stock { get; set; }
        public string descripcion { get; set; }
    

        public Inventario()
        {
            product = "";
            precio = "";
            stock = "";
            descripcion = "";
        }
    }
}