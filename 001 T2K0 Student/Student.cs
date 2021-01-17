using System;
using System.Collections.Generic;
using System.Text;

namespace _001_T2K0_Student
{
    class Student
    {
        public Student(string _name, int _matr, string _email)
        {
            Name = _name;
            Matrikelnummer = _matr;
            Email_Id = _email;
        }

        //Eigenschaften
        public string Name { get; set; }
        public int Matrikelnummer { get; set; }
        public string Email_Id { get; set; }

        //Konstruktor

        //Methoden

    }
}
