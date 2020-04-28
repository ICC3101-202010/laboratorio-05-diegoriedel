using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega_5
{
    public class User
    {

        //Paso 1: Definimos el delegate
        public delegate void VerifiedEmailEventHandler(object source, EventArgs args);
        //Paso 2: definir el evento del delgate
        public event VerifiedEmailEventHandler EmailVerified;
        //paso 3: disparar
        public virtual void OnEmailVerified()
        {
            EmailVerified(this, new EventArgs());
        }

        public void OnEmailSent(object source, EventArgs args)
        {

            Console.Write("¿Quiere revisar su correo?");
            Console.WriteLine("1) Si");
            Console.WriteLine("2) No");
            string option = Console.ReadLine();
            while (true)
            {
                if (option == "1")
                {
                    EmailVerified(source, args);
                    break;
                }
                else if (option == "2")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opcion no valida, seleccione 1 o 2");
                }
            }

        }
    }
}
