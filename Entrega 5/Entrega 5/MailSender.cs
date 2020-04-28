using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace Entrega_5
{
    public class MailSender
    {
        public void OnRegistered(object source, RegisterEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nCorreo enviado a {e.Email}: \n Gracias por registrarte, {e.Username}!\n Por favor, para poder verificar tu correo, has click en: {e.VerificationLink}\n");
            Thread.Sleep(2000);
        }

        public void OnPasswordChanged(object source, ChangePasswordEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nCorreo enviado a {e.Email}:  \n {e.Username}, te notificamos que la contrasena de tu cuenta PlusCorp ha sido cambiada. \n");
            Thread.Sleep(2000);
        }


        //Paso 1: Creamos el delegate para verificar el mail
        public delegate void EmailSentEventHandler(object source, EventArgs args);
        //Paso 2: Creamos el evento que se basa en el verificador del mail
        public event EmailSentEventHandler EmailSent;
        //Paso 3: Publicamos el evento (OnEmailSent)
        protected virtual void OnEmailSent()
        {
            EmailSent(this, new EventArgs());
        }
    }
}
