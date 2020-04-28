using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega_5
{
    public class ChangePasswordEventArgs
    {
       
        public string Email { get; set; }
        public string Number { get; set; }
        public string Username { get; set; }
    }
}
