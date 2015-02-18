using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    /// <summary>
    /// Clase de Acceso a Datos para Rubro
    /// </summary>
    public partial class RubroDataAccess : GenericDataAccess
    {
        /// <summary>
        /// Selecciona Rubros.
        /// </summary>
        /// <param name="Id">Id de Rubro</param>
        /// <returns>RubroDataSet</returns>
        public RubroDataSet.RubroDataTable Seleccionar(int id)
        {
            return ((RubroDataSet)SQLConexion.Seleccionar("Rubro_Seleccionar", id, typeof(RubroDataSet))).Rubro;
        }

        /// <summary>
        /// Inserta un nuevo Rubro.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Rubro a Insertar.</param>
        /// <returns>Id de Rubro Insertado</returns>
        public int Insertar(RubroDataSet ds)
        {
            RubroDataSet.RubroRow cr = ds.Rubro[0];
            SqlParameter[] parametros = {
                SqlParameterOutput("Id", DbType.Int32),
                SqlParameterInput("Nombre", cr.Nombre),
                SqlParameterInput("Descripcion", cr.Descripcion),
                SqlParameterInput("Valor", cr.Valor),
                SqlParameterInput("IVA", cr.IVA),
                SqlParameterInput("PVP", cr.PVP),
                SqlParameterInput("TieneIVA", cr.TieneIVA),
                SqlParameterInput("Activo", cr.Activo),
            };
            return SQLConexion.Insertar("Rubro_Insertar", parametros);
        }

        /// <summary>
        /// Modifica un Rubro.
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Rubro a Modificar.</param>
        public int Modificar(RubroDataSet ds)
        {
            RubroDataSet.RubroRow cr = ds.Rubro[0];
            SqlParameter[] parametros = {
                SqlParameterInput("Id", cr.Id),
                SqlParameterInput("Nombre", cr.Nombre),
                SqlParameterInput("Descripcion", cr.Descripcion),
                SqlParameterInput("Valor", cr.Valor),
                SqlParameterInput("IVA", cr.IVA),
                SqlParameterInput("PVP", cr.PVP),
                SqlParameterInput("TieneIVA", cr.TieneIVA),
                SqlParameterInput("Activo", cr.Activo),
            };
            return SQLConexion.Modificar("Rubro_Modificar", parametros);
        }

        /// <summary>
        /// Borra un Rubro
        /// </summary>
        /// <param name="ds">Conjunto de datos tipo Rubro a Borrar.</param>
        public int Borrar(RubroDataSet ds)
        {
            RubroDataSet.RubroRow cr = ds.Rubro[0];
            SqlParameter[] parametros = { SqlParameterInput("Id", cr.Id) };
            return SQLConexion.Borrar("Rubro_Borrar", parametros);
        }

        /// <summary>
        /// Borra un Rubro
        /// </summary>
        /// <param name="id">Identificador de Rubro</param>
        public int Borrar(int id)
        {
            SqlParameter[] parametros = { SqlParameterInput("Id", id) };
            return SQLConexion.Borrar("Rubro_Borrar", parametros);
        }
    }
}