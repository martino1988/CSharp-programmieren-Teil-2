using System;
using System.Collections.Generic;
using System.Text;

namespace _001_T2K0_Student
{
    class Student
    {
        //Eigenschaften
        private string name;
        private int matrikelnummer;
        private string email_Id;

        //Konstruktor
        public Student()
        {

        }

        //Methoden
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Matrikelnummer
        {
            get { return matrikelnummer; }
            set { matrikelnummer = value; }
        }
        public string Email_Id
        {
            get { return email_Id; }
            set { email_Id = value; }
        }


    }
}
