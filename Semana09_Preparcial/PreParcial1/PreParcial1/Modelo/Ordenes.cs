namespace PreParcial1.Modelo
{
    public class Ordenes
    {
        public string nombreuser { get; set; }
        public string product { get; set; }
        public string cantidad { get; set; }
        
        public Ordenes()
        {
            nombreuser = "";
            product = "";
            cantidad = "";
        }
    }
}