using System;
using LW2;

namespace LW2.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ExcelentPupil pupil1 = new ExcelentPupil("John Connor", 16, 9);
            GoodPupil pupil2 = new GoodPupil("Arnold notnegr", 30, 12);
            ExcelentPupil pupil3 = new ExcelentPupil("Sara C", 25, 10);
            BadPupil pupil4 = new BadPupil("T1000", 18, 11);

            System.Console.WriteLine("Class with 2 pupils: ");
            ClassRoom class2 = new ClassRoom(pupil1, pupil2);
            class2.ShowClassInfo();

            System.Console.WriteLine("Class with 3 pupils: ");
            ClassRoom class3 = new ClassRoom(pupil1, pupil2, pupil3);
            class3.ShowClassInfo();

            System.Console.WriteLine("Class with 4 pupils: ");
            ClassRoom class4 = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
            class4.ShowClassInfo();

        }
    }
}