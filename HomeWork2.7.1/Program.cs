using System;

namespace HomeWork2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            string FullName = "Антон Петров";
            int Age = 18;
            string Email = "AnPetrov@mail.com";
            int markProgramming = 55;
            int markMath = 45;
            int markPhysics = 65;
            //Console.WriteLine($"Ф.И.О. - {FullName}");
            //Console.WriteLine($"Возраст - {Age}");
            //Console.WriteLine($"Эл. почта - {Email}");
            //Console.WriteLine($"Баллы по программированию - {markProgramming}");
            //Console.WriteLine($"Баллы по математике - {markMath}");
            //Console.WriteLine($"Баллы по физике - {markPhysics}");

            string infoStudent = "Ф.И.О. - {0} \nВозраст - {1} \nЭл. почта - {2}" +
                "\nБаллы по программированию - {3} \nБаллы по математике - {4} \nБаллы по физике - {5}";
            Console.WriteLine(infoStudent,
                                FullName,
                                Age,
                                Email,
                                markProgramming,
                                markMath,
                                markPhysics);
            Console.ReadLine();

        }
    }
}