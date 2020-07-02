using System;
using System.Collections.Generic;
using System.Data;
namespace PreParcial1.Modelo
{
    public class O
    {
        public static List<Ordenes> getLista()
        {
            string sql = "select * from pedidos";
        
            DataTable dt = ConectionBD.realizarConsulta(sql);
        
            List<Ordenes> lista = new List<Ordenes>();
            foreach (DataRow fila in dt.Rows)
            {
                Ordenes s = new Ordenes();
                        
                s.nombreuser = fila[0].ToString();
                s.product = fila[1].ToString();
                s.cantidad = fila[2].ToString();
                            
                lista.Add(s);
            }
            return lista;
        }
        public static void add(string nombreuser, string product, string cantidad)
        {
            string sql = String.Format(
                "insert into pedidos(nombreuser, product, cantidad) " +
                "valores('{0}' , '{1}' , '{2}');", nombreuser , product, cantidad);
            ConectionBD.realizarAccion(sql);
        }
    }
}