using System;
using System.Collections.Generic;
using System.Data;
using PreParcial1.Controlador;

namespace PreParcial1.Modelo
{
    public class U
    {
        public static List<User> getLista()
        {
            string sql = "select * from usuario";
        
            DataTable dt = ConectionBD.realizarConsulta(sql);
        
            List<User> lista = new List<User>();
            foreach (DataRow fila in dt.Rows)
            {
                User s = new User();
                s.nombreuser = fila[0].ToString(); 
                s.password = fila[1].ToString();
                s.administrador = Convert.ToBoolean(fila[2].ToString());
                s.act = Convert.ToBoolean(fila[3].ToString());
        
                lista.Add(s);
            }
            return lista;
        }
        public static void Pass(string user, bool administrador, bool act)
        {
            string sql = String.Format(
                "update user set administrador={0}, act={1} where nombreuser='{2}';",
                administrador ? "true" : "false", act ? "true" : "false", user);
                            
            ConectionBD.realizarAccion(sql);
        }
        
        public static void actPassword(string user, string newPass)
        {
            string sql = String.Format(
                "update user set password='{0}' where nombreuser='{1}';",
                newPass, user);
                             
            ConectionBD.realizarAccion(sql);
        }
        
        public static void New(string user)
        {
            string sql = String.Format(
                "insert into usuario(nombreuser, password, administrador, act) " +
                "values('{0}', '{1}', false, true);" ,
                user, Encriptar.CrearMD5(user));
                    
            ConectionBD.realizarAccion(sql);
        }

        public static void delete(string user)
        {
            string sql = String.Format(
                "delete from orden where nombreuser ='{0}'; " +
                "delete from user where nombreuser ='{0}';",user);
                    
            ConectionBD.realizarAccion(sql);
        }
    }
}