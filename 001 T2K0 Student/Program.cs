using System;

namespace _001_T2K0_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implementieren Sie die Klasse Student mit folgenden Instanzvariablen
            //• Name
            //• Matrikelnummer
            //• Email Id
            //Implementieren Sie für jede Instanzvariable eine Property mit get und set Accessor. 
            //Legen Sie ein Studenten Objekt an und geben Sie alle Details des Objektes auf der Konsole aus.

            Console.WriteLine("Student anlegen:");
            Console.Write("Name eingeben: ");
            string name = Console.ReadLine();
            Console.Write("Matrikelnummer eingeben: ");
            int matr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Email eingeben: ");
            string email = Console.ReadLine();

            Student s = new Student(name, matr, email);

            Console.WriteLine("Name: {0}\nMatrikelnummer: {1}\nEmail: {2}", s.Name, s.Matrikelnummer, s.Email_Id);
        }
    }
}
