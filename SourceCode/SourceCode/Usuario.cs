namespace SourceCode
{
    public class Usuario
    {
        public string idUser { get; set; }
        public string fullName { get; set; }
        
        public string userName { get; set; }
        public string password { get; set; }
        
        public bool userType{ get; set; }


        public Usuario()
        {
            idUser = "";
            fullName= "";
            userName = "";
            password= "";
            userType = false;

        }
    }
}