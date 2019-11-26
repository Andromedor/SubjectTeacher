using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherSubject.Teacher;
using TeacherSubject.Subject;

namespace TeacherSubject
{
    class Program
    {
        static void Main(string[] args)
        {
            DBTeahcer dBTeahcer = new DBTeahcer();
            DBSubjects dBSubjects = new DBSubjects();
            SubjectMenu subjectMenu = new SubjectMenu(dBSubjects);
            MenuTeacher menuTeacher = new MenuTeacher(dBTeahcer);
            bool exit = false;

            do
            {
                Console.WriteLine(new string('-', 20) + "Menu" + new string('-', 20));
                Console.WriteLine("Press the key number of menu");
                Console.WriteLine("1 - Teacher menu");
                Console.WriteLine("2 - Subject menu");
                Console.WriteLine("0 - Exit");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1:
                        menuTeacher.Run();
                        Console.WriteLine();
                        break;
                    case ConsoleKey.D2:
                        subjectMenu.Run();
                        break;
                    case ConsoleKey.D0:
                        Console.WriteLine("Good by!");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Wrong key command!");
                        break;
                }
            }
            while (!exit);
        }
    }
}
