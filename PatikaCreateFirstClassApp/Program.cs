using System;

namespace PatikaCreateFirstClassApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person studentOne = new Person();
            studentOne.Name = "Mehmet";
            studentOne.Surname = "Akyüz";
            studentOne.BirthDate = new DateTime(1994, 12, 15);

            Person studentTwo = new Person();
            studentTwo.Name = "Ahmet";
            studentTwo.Surname = "Ekim";
            studentTwo.BirthDate = new DateTime(1995, 2, 3);

            Person teacherOne = new Person();
            teacherOne.Name = "Murat";
            teacherOne.Surname = "Akın";
            teacherOne.BirthDate = new DateTime(1985, 8, 30);

            Person teacherTwo = new Person();
            teacherTwo.Name = "Kerem";
            teacherTwo.Surname = "Solmaz";
            teacherTwo.BirthDate = new DateTime(1988, 4, 12);

            Console.WriteLine($"Birinci ögrencinin adi-soyadi: {studentOne.Name} {studentOne.Surname}. Dogum tarihi: {studentOne.BirthDate.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"İkinci ögrencinin adi-soyadi: {studentTwo.Name} {studentTwo.Surname}. Dogum tarihi: {studentTwo.BirthDate.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"Birinci ögretmenin adi-soyadi: {teacherOne.Name} {teacherOne.Surname}. Dogum tarihi: {teacherOne.BirthDate.ToString("dd.MM.yyyy")}");
            Console.WriteLine($"İkinci ögretmenin adi-soyadi: {teacherTwo.Name} {teacherTwo.Surname}. Dogum tarihi: {teacherTwo.BirthDate.ToString("dd.MM.yyyy")}");

        }
    }
}