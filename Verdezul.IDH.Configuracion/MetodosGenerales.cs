using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Verdezul.IDH.Configuracion.Enumerados;
using Verdezul.IDH.Entidades;

namespace Verdezul.IDH.Configuracion
{
    public class MetodosGenerales
    {
        public static DataTable PedirTiposAbono()
        {
            DataTable MotivoPagoDataTable = new DataTable();
            MotivoPagoDataTable.Columns.Add(new DataColumn("Valor", typeof(int)));
            MotivoPagoDataTable.Columns.Add(new DataColumn("Texto", typeof(TipoAbono)));
            foreach (TipoAbono ti in Enum.GetValues(typeof(TipoAbono)))
            {
                DataRow dr = MotivoPagoDataTable.NewRow();
                dr["Valor"] = (int)ti;
                dr["Texto"] = ti;
                MotivoPagoDataTable.Rows.Add(dr);
            }
            return MotivoPagoDataTable;
        }

        public static DataTable PedirMotivosPago()
        {
            DataTable MotivoPagoDataTable = new DataTable();
            MotivoPagoDataTable.Columns.Add(new DataColumn("Valor", typeof(MotivoPago)));
            MotivoPagoDataTable.Columns.Add(new DataColumn("Texto", typeof(MotivoPago)));
            foreach (MotivoPago ti in Enum.GetValues(typeof(MotivoPago)))
            {
                DataRow dr = MotivoPagoDataTable.NewRow();
                dr["Valor"] = ti;
                dr["Texto"] = ti;
                MotivoPagoDataTable.Rows.Add(dr);
            }
            return MotivoPagoDataTable;
        }

        public static DataTable PedirTiposDocumentoPago()
        {
            DataTable TipoDocumentoPagoDataTable = new DataTable();
            TipoDocumentoPagoDataTable.Columns.Add(new DataColumn("Valor", typeof(int)));
            TipoDocumentoPagoDataTable.Columns.Add(new DataColumn("Texto", typeof(TipoDocumentoPago)));
            foreach (TipoDocumentoPago tdp in Enum.GetValues(typeof(TipoDocumentoPago)))
            {
                DataRow dr = TipoDocumentoPagoDataTable.NewRow();
                dr["Valor"] = tdp;
                dr["Texto"] = tdp;
                TipoDocumentoPagoDataTable.Rows.Add(dr);
            }
            return TipoDocumentoPagoDataTable;
        }

        public static AreaDataSet.NivelDataTable FiltrarNivelesxArea(int idArea, AreaDataSet areasDataSet)
        {
            AreaDataSet.NivelDataTable ndt = new AreaDataSet.NivelDataTable();
            foreach (AreaDataSet.NivelRow nrow in areasDataSet.Nivel)
            {
                if (nrow.IdArea == idArea)
                    ndt.Rows.Add(nrow.Id, nrow.IdArea, nrow.Nombre);
            }
            return ndt;
        }

        public static AreaDataSet.NivelDataTable FiltrarNivelesxArea(int idArea, AreaDataSet areasDataSet, string adicional)
        {
            AreaDataSet.NivelDataTable ndt = FiltrarNivelesxArea(idArea, areasDataSet);
            AreaDataSet.NivelRow nr = ndt.NewNivelRow();
            nr.Id = 0;
            nr.IdArea = 0;
            nr.Nombre = adicional;
            ndt.Rows.InsertAt(nr, 0);
            return ndt;
        }

        public static int PedirIdAreaxIdNivel(int idNivel, AreaDataSet areasDataSet)
        {
            foreach (AreaDataSet.NivelRow nrow in areasDataSet.Nivel.Rows)
            {
                if (nrow.Id == idNivel)
                    return nrow.IdArea;
            }
            return 0;
        }

        public static DataTable Meses()
        {
            DataTable dtMeses = new DataTable();
            dtMeses.Columns.Add("NumeroMes", typeof(int));
            dtMeses.Columns.Add("NombreMes", typeof(string));

            dtMeses.Rows.Add(1, "Enero");
            dtMeses.Rows.Add(2, "Febrero");
            dtMeses.Rows.Add(3, "Marzo");
            dtMeses.Rows.Add(4, "Abril");
            dtMeses.Rows.Add(5, "Mayo");
            dtMeses.Rows.Add(6, "Junio");
            dtMeses.Rows.Add(7, "Julio");
            dtMeses.Rows.Add(8, "Agosto");
            dtMeses.Rows.Add(9, "Septiembre");
            dtMeses.Rows.Add(10, "Octubre");
            dtMeses.Rows.Add(11, "Noviembre");
            dtMeses.Rows.Add(12, "Diciembre");
            return dtMeses;
        }

        public static DataTable TresAnos()
        {
            DataTable dtAnos = new DataTable();
            dtAnos.Columns.Add("NombreAno", typeof(int));

            int anoActual = DateTime.Today.Year;
            dtAnos.Rows.Add(anoActual-1);
            dtAnos.Rows.Add(anoActual);
            dtAnos.Rows.Add(anoActual+1);
            return dtAnos;
        }

        public static HorarioDataSet.HorarioDataTable FiltrarHorariosxNivel(int idNivel, HorarioDataSet.HorarioDataTable HorariosDataTable)
        {
            HorarioDataSet.HorarioDataTable HorariosFiltradosDataTable = HorariosDataTable.Clone() as HorarioDataSet.HorarioDataTable;
            if (HorariosFiltradosDataTable != null)
            {
                HorariosFiltradosDataTable.Clear();
                foreach (HorarioDataSet.HorarioRow hrow in HorariosDataTable)
                {
                    if (hrow.IdNivel == idNivel)
                        HorariosFiltradosDataTable.Rows.Add(hrow.ItemArray);
                }
                MetodosGenerales.AdicionarTextoHorario(HorariosFiltradosDataTable, "(Seleccione)", 0);
                HorariosFiltradosDataTable.NombreHorarioColumn.Expression = MetodosGenerales.ExpresionHorarioNombre;
            }
            return HorariosFiltradosDataTable;
        }

        public static void AgregarFila(DataTable data, int posicion, params CampoFilaAdicional[] campos)
        {
            DataRow row = data.NewRow();
            foreach (CampoFilaAdicional campo in campos)
            {
                row[campo.NombreCampo] = campo.ValorCampo;
            }
            data.Rows.InsertAt(row, posicion);

        }

        public static void AdicionarTextoHorario(HorarioDataSet.HorarioDataTable HorarioFiltrados, string texto, int posicion)
        {
            HorarioDataSet.HorarioRow nrow = HorarioFiltrados.NewHorarioRow();
            nrow.Id = 0;
            nrow.TipoHorario = 0;
            nrow.IdCurso = 0;
            nrow.IdNivel = 0;
            nrow.IdAula = 0;
            nrow.IdDocente = 0;
            nrow.HoraInicio = new DateTime();
            nrow.HoraFin = new DateTime();
            nrow.Dias = texto;
            nrow.NombreHorario = texto;
            nrow.Activo = true;

            if (posicion >= 0)
                HorarioFiltrados.Rows.InsertAt(nrow, posicion);
            else
                HorarioFiltrados.Rows.Add(nrow);
        }

        public static void AdicionarTextoHorario(HorarioAlumnoDataSet.HorarioAlumnoDataTable HorarioFiltrados, string texto, int posicion)
        {
            HorarioAlumnoDataSet.HorarioAlumnoRow nrow = HorarioFiltrados.NewHorarioAlumnoRow();
            nrow.Id = 0;
            nrow.IdAlumno = 0;
            nrow.IdHorario = 0;
            nrow.FechaInicio = DateTime.Today;
            nrow["Curso"] = texto;
            nrow.Activo = true;

            if (posicion >= 0)
                HorarioFiltrados.Rows.InsertAt(nrow, posicion);
            else
                HorarioFiltrados.Rows.Add(nrow);
        }

        public static string BuscarValorParametro(string nombreParametro, ParametroDataSet.ParametroDataTable dtParametro)
        {
            foreach (ParametroDataSet.ParametroRow prow in dtParametro)
            {
                if (prow.Nombre == nombreParametro)
                    return prow.Valor;
            }
            return "";
        }

        public static string ExpresionHorarioNombre = 
            @"  ISNULL(Substring(Curso, 1, 22), '') +
                ISNULL(Nivel, '') + 
                ISNULL( Substring(Convert(HoraInicio, 'System.String'), 11, 6) + '-' +
                        Substring(Convert(HoraFin, 'System.String'), 11, 6) + ' ' +
                        Dias, '')";
                //+ ' ' + Aula + ' ' Docente";

        public static string ExpresionDetallePago =
            @"  ISNULL(Conferencia, '') +
                ISNULL(Rubro, '') + 
                ISNULL( Substring(Convert(MesPago, 'System.String'), 4, 2) + '/' + 
                        Substring(Convert(MesPago, 'System.String'), 9, 2) + ' ' + 
                        HorarioNombre , '')";

        public static string FormatoHoraEnHorario = "HH:mm";
        public static string FormatoMesAnio = "MMMM/yy";
    }
}
