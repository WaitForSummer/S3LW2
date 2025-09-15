using System;
using LW2;

namespace LW2
{
    public class Program
    {
        public static void Task1()
        {
            Console.WriteLine("Starting Task1...\n");
            ExcelentPupil pupil1 = new ExcelentPupil("John Connor", 16, 9);
            GoodPupil pupil2 = new GoodPupil("Arnold notnegr", 30, 12);
            ExcelentPupil pupil3 = new ExcelentPupil("Sara C", 25, 10);
            BadPupil pupil4 = new BadPupil("T1000", 18, 11);

            Console.WriteLine("Class with 2 pupils: ");
            ClassRoom class2 = new ClassRoom(pupil1, pupil2);
            class2.ShowClassInfo();

            Console.WriteLine("Class with 3 pupils: ");
            ClassRoom class3 = new ClassRoom(pupil1, pupil2, pupil3);
            class3.ShowClassInfo();

            Console.WriteLine("Class with 4 pupils: ");
            ClassRoom class4 = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
            class4.ShowClassInfo();

            //Console.WriteLine("Press any key to start 2nd task...");
            //Console.ReadKey();
            //Console.Clear();

        }

        public static void Task2()
        {
            Console.WriteLine("Starting task2...\n");
            Car car = new Car(50, 100, 2500000, 320, 2022);
            Plane plane = new Plane(1000, 500, 15000000, 750, 2015, 3000, 2);
            Ship ship = new Ship(75.5, 99.9, 50000000, 120, 2018, "Victory", 325);

            car.Print();
            plane.Print();
            ship.Print();
        }

        public static void Task3()
        {
            string key = "000";

            Console.WriteLine("Starting Task3\n");
            Console.WriteLine("Enter your key-actiavtor: ");
            //key = Console.ReadLine();

            if (key == "000")
            {
                DocumentWorker documentWorker = new DocumentWorker();
                documentWorker.Print();
                Console.WriteLine("\n");
            } else if (key == "777")
            {
                ProDocumentWorker documentWorker = new ProDocumentWorker();
                documentWorker.Print();
                Console.WriteLine("\n");
            } else if (key == "-1")
            {
                ExpertDocumentWorker documentWorker = new ExpertDocumentWorker();
                documentWorker.Print();
                Console.WriteLine("\n");
            } else
            {
                DocumentWorker documentWorker = new DocumentWorker();
                documentWorker.Print();
                Console.WriteLine("\n");
            }
        }

        public static void Main(string[] args)
        {
            Task1();

            Task2();

            Task3();
        }
    }
}