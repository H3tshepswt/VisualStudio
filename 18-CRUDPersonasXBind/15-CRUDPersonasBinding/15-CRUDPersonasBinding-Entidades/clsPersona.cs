﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _15_CRUDPersonasBinding_Entidades
{
    public class clsPersona
    {
        #region constructor por defecto

        public clsPersona()
        {
            /*this.idPersona = 0;
            this.nombre = "";
            this.apellidos = "";
            this.fechaNacimiento = new DateTime();
            this.direccion = "";
            this.telefono = "";*/
            this.idDepartamento = 1;
        }

        #endregion

        #region constructor por parametros

        public clsPersona(int nIdPersona, String nNombre, String nApellido, DateTime nFechaNacimiento, String nDireccion, String nTelefono, int nIdDepartamento)
        {
            this.idPersona = nIdPersona;
            this.nombre = nNombre;
            this.apellidos = nApellido;
            this.fechaNacimiento = nFechaNacimiento;
            this.direccion = nDireccion;
            this.telefono = nTelefono;
            this.idDepartamento = nIdDepartamento;
        }

        #endregion


        #region atributos y propiedades

        public int idPersona { get; set; }
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        public int idDepartamento { get; set; }


        #endregion
    }
}