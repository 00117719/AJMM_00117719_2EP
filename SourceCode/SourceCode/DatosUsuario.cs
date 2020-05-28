using System;
using System.Collections.Generic;
using System.Data;


namespace SourceCode
{
    public class DatosUsuario
    {
         public static List<Usuario> getList()
                {
                    string sql = "select * from appuser";
        
                    DataTable dt = ConexionBD.realizarConsulta(sql);
        
                    List<Usuario> list = new List<Usuario>();
                    foreach (DataRow fila in dt.Rows)
                    {
                        Usuario u = new Usuario();
                        u.idUser = fila[0].ToString();
                        u.fullName= fila[1].ToString();
                        u.userName = fila[2].ToString();
                        u.password = (fila[3].ToString());
                        u.userType= Convert.ToBoolean(fila[4].ToString());
        
                        list.Add(u);
                    }
                    return list;
                }
         
         
         public static void actualizarContra(string usuario, string nuevaContra)
         {
             string sql = String.Format(
                 "update appuser set password='{0}' where userName='{1}';",
                 nuevaContra, usuario);
            
             ConexionBD.realizarEvento(sql);
         }
 public static void crearNuevoUsuario(string usuario)
        {
            string sql = String.Format(
                "insert into usuario(fullname, username, password, userType) " +
                "values('{0}', '{1}', '{2}', true);",
                usuario, Encriptador.CrearMD5(usuario));
            
            ConexionBD.realizarEvento(sql);
        }
         
         
          public static void eliminar(string idUsuario)
                 {
                     string sql = String.Format(
                         "delete from appuser where idUser ='{0}'; " +
                         "delete from address where idUser='{0}';",
                         idUsuario);
                     
                     ConexionBD.realizarEvento(sql);
                 }
         
    }
}