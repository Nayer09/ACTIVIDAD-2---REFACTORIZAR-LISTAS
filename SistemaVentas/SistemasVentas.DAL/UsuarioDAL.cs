using DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioDAL
    {
        public DataTable ListarUsuariosDal()
        {
            string consulta = "SELECT USUARIO.IDUSUARIO, (PERSONA.NOMBRE +' '+ PERSONA.APELLIDO)NOMBRE_COMPLETO, USUARIO.NOMBREUSER, USUARIO.CONTRASEÑA, USUARIO.FECHAREG AS FECHA_DE_REGISTRO\r\nFROM     PERSONA INNER JOIN\r\n                  USUARIO ON PERSONA.IDPERSONA = USUARIO.IDPERSONA";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioDal(Usuario usuario)
        {
            string consulta = "insert into usuario values (" + usuario.IdPersona+ "," +
                                                          "'" + usuario.NombreUser+ "'," +
                                                          "'" + usuario.Contraeña+ "'," +
                                                          "'" + usuario.Fecha + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);

        }
    }
}
