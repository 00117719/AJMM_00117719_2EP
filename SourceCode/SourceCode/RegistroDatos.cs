using System;

namespace SourceCode
{
    public class RegistroDatos
    {
        public static void iniciarSesion(string usuario)
        {
            agregarUsuario(usuario,true);
        }

        public static void cerrarSesion(string usuario)
        {
            agregarUsuario(usuario,false);
            
        }

        public static void agregarUsuario(string usuario, bool tipoUsuario)
        {
            string sql = String.Format("insert into appuser(username,usertype) values('{0}',{1});",
                usuario, tipoUsuario);

            ConexionBD.realizarEvento(sql);

        }
    }
}