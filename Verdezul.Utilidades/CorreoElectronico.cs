using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace Verdezul.Utilidades
{
    public class CorreoElectronico
    {
        public static void EnviarMail(MailMessage Correo)
        {
            SmtpClient Cliente = new SmtpClient();
            string mensaje = "";
            //try
            //{
                Cliente.Send(Correo);
                mensaje = "Correo Enviado";
            //}
            //catch (Exception ex)
            //{
            //    mensaje = "El correo no ha sido enviado";
            //}

        }
    }
}
