﻿using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProveeDAL
    {
        public DataTable ListarProveeDal()
        {
            string consulta = "SELECT PROVEE.IDPROVEE, PRODUCTO.NOMBRE AS PRODUCTO, PROVEEDOR.NOMBRE AS PROVEEDOR, PROVEE.FECHA, PROVEE.PRECIO\r\nFROM     PROVEE INNER JOIN\r\n                  PRODUCTO ON PROVEE.IDPRODUCTO = PRODUCTO.IDPRODUCTO INNER JOIN\r\n                  PROVEEDOR ON PROVEE.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR\r\n";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}
