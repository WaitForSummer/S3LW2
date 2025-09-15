using System;
using System.Collections.Generic;

namespace LW2
{
    public class ClassRoom
    {
        private List<Pupil> pupils;

        public ClassRoom(params Pupil[] pArr)
        {
            pupils = new List<Pupil>(pArr);
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3 = null, Pupil p4 = null) 
        {
            pupils = new List<Pupil> { p1, p2 };

            if (p3 != null) pupils.Add(p3);
          
            if (p4 != null) pupils.Add(p4);

        }

        public void ShowClassInfo()
        {
            Console.WriteLine("\n=== Info about class ===");
            Console.WriteLine($"Count of pupils: {pupils.Count}\n");

            for (int i = 0; i < pupils.Count; i++)
            {
                Console.WriteLine($"Info about pupil №{i + 1}: {pupils[i].getName()}");

                Console.WriteLine("Study: ");
                pupils[i].Study();

                Console.WriteLine("Read: ");
                pupils[i].Read();

                Console.WriteLine("Write: ");
                pupils[i].Write();

                Console.WriteLine("Relax: ");
                pupils[i].Relax();
            }
        }
    }
}
