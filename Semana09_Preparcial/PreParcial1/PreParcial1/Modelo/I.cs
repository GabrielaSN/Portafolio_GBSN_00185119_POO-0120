using System;
using System.Collections.Generic;
using System.Data;

namespace PreParcial1.Modelo
{
    public class I
    {
        public static List<Inventario> getLista()
        {
            string sql = "select * from inventario";
        
            DataTable dt = ConectionBD.realizarConsulta(sql);
        
            List<Inventario> list = new List<Inventario>();
            foreach (DataRow fila in dt.Rows)
            {
                Inventario i = new Inventario();
                i.product = fila[0].ToString();
                i.descripcion = fila[1].ToString();
                i.precio = fila[2].ToString();
                i.stock = fila[3].ToString();
        
                list.Add(i);
            }
        
            return list;
        }
        
        public static void enStock(string inventario, string newStock)
        {
            string sql = String.Format(
                "update inventario set stock={0} where product= '{1}' ;",
                newStock, inventario);
                
                ConectionBD.realizarAccion(sql);
        }
        
        public static void crearNuevo(string nombreproducto, string descripcion, string precio, string stock)
        {
            string sql = String.Format(
                "insert into inventario(nombreproducto, descripcion, precio, stock) " +
                "values('{0}', '{1}', {2} , {3});", nombreproducto, descripcion, precio, stock);
        
        
            ConectionBD.realizarAccion(sql);
        }
        
        public static void eliminar(string idproducto)
        {
            string sql = String.Format(
                "delete from pedidos where nombreproducto = '{0}'; " + 
                "delete from inventario where nombreproducto ='{0}';",
                idproducto);
            ConectionBD.realizarAccion(sql);
        }
    }
}