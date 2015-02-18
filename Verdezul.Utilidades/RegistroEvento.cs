using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Configuration;
using System.Net;
using Verdezul.Utilidades.Configuracion;

namespace Verdezul.Utilidades
{
    /// <summary>
    /// Clase para registrar Eventos en el Visor de Eventos.
    /// </summary>
    public abstract class RegistroEvento
    {
        private static string sourceLog = (ConfigurationManager.GetSection("Verdezul") as VerdezulConfiguration).Conexiones.Fuente;
        private static string logName = "Verdezul";

        public static void Escribir(string mensaje, EventLogEntryType tipoEvento)
        {
            string machineName = Dns.GetHostName();

            string logNameRegistro = EventLog.LogNameFromSourceName(sourceLog, machineName);
            if ((logNameRegistro != "") && (logNameRegistro != logName))
                logName = logNameRegistro;

            EventLog EventLogVerdezul = new EventLog(logName);
            EventLogVerdezul.Source = sourceLog;
            EventLogVerdezul.WriteEntry(mensaje, tipoEvento);
        }
    }
}
