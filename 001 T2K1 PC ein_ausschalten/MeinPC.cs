using System;
using System.Collections.Generic;
using System.Text;

namespace _002_T2K1_PC_ein_ausschalten
{
    class MeinPC
    {
        bool status;

        public void Einschalten()
        {
            status = true;
            Console.WriteLine("PC eingeschaltet");
        }
        public void Ausschalten()
        {
            status = false;
            Console.WriteLine("PC ausgeschaltet");
        }
        public bool Status()
        {
            bool stat = status;
            return stat;
        }
    }
}
