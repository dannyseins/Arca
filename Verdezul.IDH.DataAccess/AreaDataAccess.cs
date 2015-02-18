using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;
using Verdezul.IDH.Entidades;
//using Verdezul.IDH.Configuracion.Enumerados;

namespace Verdezul.IDH.DataAccess
{
    public partial class AreaDataAccess
    {
        public int InsertarNivel(AreaDataSet ds)
        {
            using (TransactionScope ts = new TransactionScope())
            {
                AreaDataSet.AreaRow pr = ds.Area[0];
                SqlParameter[] parametrosArea = {
                    SqlParameterOutput("Id", DbType.Int32),
                    SqlParameterInput("Nombre", pr.Nombre)
                };

                List<SqlParameter[]> listaParametrosDetalleArea = new List<SqlParameter[]>();

                foreach (AreaDataSet.NivelRow dpr in ds.Nivel.Rows)
                {
                    SqlParameter[] parametrosDetalleArea = {
                        SqlParameterOutput("Id", DbType.Int32),
                        SqlParameterInput("IdArea", null),
                        SqlParameterInput("Nombre", dpr.Nombre)
                    };
                    listaParametrosDetalleArea.Add(parametrosDetalleArea);
                }

                int IdArea = SQLConexion.InsertarNivel("Area_Insertar", "Nivel_Insertar",
                    parametrosArea, listaParametrosDetalleArea, "IdArea");

                ts.Complete();
                return IdArea;
            }
        }

        public AreaDataSet SeleccionarConNiveles(int idArea)
        {
            SqlParameter[] parametros = {
                SqlParameterInput("IdArea", idArea)
            };

            return (AreaDataSet)SQLConexion.SeleccionarDatos("Area_SeleccionarConNiveles", parametros, typeof(AreaDataSet));
        }
    }
}
