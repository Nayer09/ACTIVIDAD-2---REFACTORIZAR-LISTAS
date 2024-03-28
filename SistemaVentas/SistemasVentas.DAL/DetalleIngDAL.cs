using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleIngDAL
    {
        public DataTable ListarDetalleIngDal()
        {
            string consulta = "SELECT DETALLEING.IDDETALLEING, INGRESO.TOTAL AS INGRESO, PRODUCTO.NOMBRE AS PRODUCTO, DETALLEING.FECHAVENC, DETALLEING.CANTIDAD, DETALLEING.PRECIOCOSTO, DETALLEING.PRECIOVENTA, DETALLEING.SUBTOTAL, \r\n                  DETALLEING.ESTADO\r\nFROM     DETALLEING INNER JOIN\r\n                  INGRESO ON DETALLEING.IDINGRESO = INGRESO.IDINGRESO INNER JOIN\r\n                  PRODUCTO ON DETALLEING.IDPRODUCTO = PRODUCTO.IDPRODUCTO";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}
