﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using SistemasVentas.Modelos;
namespace SistemasVentas.DAL
{
    public class PersonaDal
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "select * from persona";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarPersonaDal(Persona persona)
        {
            string consulta = "insert into persona values('" + persona.Nombre + "'," +
                                                         "'" + persona.Apellido + "'," +
                                                         "'" + persona.Telefono + "'," +
                                                         "'" + persona.Ci + "'," +
                                                         "'" + persona.Correo + "'," +
                                                         "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public Persona ObtenerPersonaId(int id)
        {
            string consulta = "select * from persona where idpersona=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Persona p = new Persona();
            if (tabla.Rows.Count > 0)
            {
                p.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.Apellido = tabla.Rows[0]["apellido"].ToString();
                p.Telefono = tabla.Rows[0]["telefono"].ToString();
                p.Ci = tabla.Rows[0]["ci"].ToString();
                p.Correo = tabla.Rows[0]["correo"].ToString();
                p.Estado = tabla.Rows[0]["estado"].ToString();

            }
            return p;
        }

        public void EditarPersonaDal(Persona persona)
        {
            string consulta = "update persona set nombre='" + persona.Nombre + "'," +
                                                 "apellido='" + persona.Apellido + "'," +
                                                 "telefono='" + persona.Telefono + "'," +
                                                 "ci='" + persona.Ci + "'," +
                                                 "correo='" + persona.Correo + "' " +
                               "where idpersona=" + persona.IdPersona;
            conexion.Ejecutar(consulta);
        }

        public void EliminarPersonaDal(int id)
        {
            string consulta = "delete from persona where idpersona=" + id;
            conexion.Ejecutar(consulta);
        }
    }


}