using System;
using System.Collections.Generic;
using System.Text;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.DataAccess
{
    public partial class RubroDataAccess
    {
        /// <summary>
        /// Selecciona Rubros Activos
        /// </summary>
        /// <returns></returns>
        public RubroDataSet.RubroDataTable SeleccionarActivos()
        {
            return ((RubroDataSet)SQLConexion.SeleccionarDatos("Rubro_SeleccionarActivos", typeof(RubroDataSet))).Rubro;
        }

        public RubroDataSet.RubroDataTable SeleccionarPrueba()
        {
            RubroDataSet.RubroDataTable dtRubros = new RubroDataSet.RubroDataTable();
            for (int i = 1; i <= 10; i++)
            {
                RubroDataSet.RubroRow dr = dtRubros.NewRubroRow();
                dr.Id = i;
                dr.Nombre = "Rubro " + i.ToString();
                dr.PVP = 2 * i;
                dr.Activo = true;
                dtRubros.Rows.Add(dr);
            }
            return dtRubros;
        }
    }
}
