using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
   public class MC
    {
        public string Nummerplade { get { return Nummerplade; } }
        public DateTime Dato { get { return Dato; } }

        public int Pris()
        {
            return 125;
        }

        public string køretøj()
        {
            return "MC";
        }
    }
}
