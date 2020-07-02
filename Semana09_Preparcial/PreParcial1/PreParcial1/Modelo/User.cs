namespace PreParcial1.Modelo
{
    public class User
    {
        public bool administrador { get; set; }
        public bool act { get; set; }
        public string nombreuser { get; set; }
        public string password { get; set; }

        
        public User()
        { 
            administrador = false;
            act = false;
            nombreuser = "";
            password = "";

        }
    }
}