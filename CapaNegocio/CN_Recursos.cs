using System;
using System.Security.Cryptography;
using System.Text;
//Clases para enviar correo eletronicos
using System.Net.Mail;
using System.Net;

using System.IO;


namespace CapaNegocio
{
    public class CN_Recursos
    {

        public static string GenerarClave()
        {
            string clave = Guid.NewGuid().ToString("N").Substring(0,6);
            return clave;
        }


        public static string ConvertirSha256(string texto)
        {
            StringBuilder Sb = new StringBuilder();
            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(texto));

                foreach (byte b in result) 
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }


        public static bool EnviarCorreo(string correo, string asunto,string mensaje)
        {
            bool resultado = false;

            //Para concegir estas credenciales debes ir a google -> Contraseñas de aplicaciones
            //https://myaccount.google.com/apppasswords?pli=1&rapt=AEjHL4N2VEoeXoIgrWoF4CkN1U688XvyFkB1rG6wwxIcYylUZGUmQKAqwSGjL9j3XbOzxk0HdTv9952IRRWbk8EO5PmDgtoYnH2IJqM0QNDQpLdDW2Psbv0


            string dir_correo = "lit.io30303@gmail.com";
            string pass_correo = "lxjx itbb fjga tphu";
            try
            {
                MailMessage mail = new MailMessage();

                mail.To.Add(correo);
                mail.From = new MailAddress(dir_correo);
                mail.Subject = asunto;
                mail.Body = mensaje;
                mail.IsBodyHtml = true;

                var smtp = new SmtpClient()
                {
                    Credentials =  new NetworkCredential(dir_correo, pass_correo),
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true
                };

                smtp.Send(mail);
                resultado = true;


            }
            catch (Exception ex)
            {
                ex.ToString();
                resultado = false;
            }

            return resultado;
        }

        public static string ConvertirBase64(string ruta, out bool conversion)
        {
            string textoBase64 = string.Empty;
            conversion = true;

            try
            {
                byte[] bytes = File.ReadAllBytes(ruta);
                textoBase64 = Convert.ToBase64String(bytes);


            } catch
            {
                conversion = false;
            }

            return textoBase64;

        }



    }
}
