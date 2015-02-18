using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Microsoft.Reporting.WinForms;

namespace Verdezul.Utilidades.Clases
{
    public class ElementosReporte
    {
        #region Constructor
        public ElementosReporte(string titulo, string nombreReporte, DataTable dataSource, List<ReportParameter> parametrosReporte)
        {
            Titulo = titulo;
            NombreReporte = nombreReporte;
            DataSource = dataSource;
            ParametrosReporte = parametrosReporte;
        }

        public ElementosReporte()
        {
            ParametrosReporte = new List<ReportParameter>();
        }
        #endregion

        #region Propiedades
        private string _Titulo;
        public string Titulo
        {
            get { return _Titulo; }
            set { _Titulo = value; }
        }

        private string _NombreReporte;
        public string NombreReporte
        {
            get { return _NombreReporte; }
            set { _NombreReporte = value; }
        }

        private DataTable _DataSource;
        public DataTable DataSource
        {
            get { return _DataSource; }
            set { _DataSource = value; }
        }

        private List<ReportParameter> _ParametrosReporte;
        public List<ReportParameter> ParametrosReporte
        {
            get { return _ParametrosReporte; }
            set { _ParametrosReporte = value; }
        }
        #endregion
    }
}