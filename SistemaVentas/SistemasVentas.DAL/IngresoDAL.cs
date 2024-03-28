using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class IngresoDAL
    {
        public DataTable ListarIngresoDal()
        {
            string consulta = "SELECT INGRESO.IDINGRESO, PROVEEDOR.NOMBRE AS PROVEEDOR, INGRESO.FECHAINGRESO, INGRESO.TOTAL, INGRESO.ESTADO\r\nFROM     INGRESO INNER JOIN\r\n                  PROVEEDOR ON INGRESO.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR\r\n";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}
