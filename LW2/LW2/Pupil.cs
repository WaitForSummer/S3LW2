using System;

namespace LW2
{
    public class Pupil
    {
        private string Name;
        private int age;
        private int Class;

        public Pupil(string name, int age, int Class)
        {
            this.Name = name;
            this.age = age;
            this.Class = Class;
        }

        public string getName()
        {
            return Name;
        }


        public virtual void Study()
        {
            Console.WriteLine("The student is required to attend all classes, as well as wear a uniform.");
        }

        public virtual void Read()
        {
            Console.WriteLine("The student should read both the literature that is given at school and the one that will help him in self-development.");
        }

        public virtual void Write()
        {
            Console.WriteLine("The student must keep notes during classes, and the design must comply with local GOST standards.");
        }

        public virtual void Relax()
        {
            Console.WriteLine("The student can rest during after-school hours and on weekends.\n");
        }
    }

    public class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string name, int age, int Class) : base(name, age, Class) { }

        public override void Study()
        {
            Console.WriteLine("Excellent student always attends classes and actively participates in lessons.");
        }

        public override void Read()
        {
            Console.WriteLine("Excellent student reads additional literature beyond the school program.");
        }

        public override void Write()
        {
            Console.WriteLine("Excellent student keeps perfect notes with additional comments.");
        }

        public override void Relax()
        {
            Console.WriteLine("Excellent student rests productively, combining relaxation with self-development.\n");
        }
    }

    public class GoodPupil : Pupil
    {
        public GoodPupil(string name, int age, int Class) : base(name, age, Class) { }

        public override void Study()
        {
            Console.WriteLine("Good student regularly attends classes and completes assignments.");
        }

        public override void Read()
        {
            Console.WriteLine("A good student regularly reads school literature and sometimes additional");
        }

        public override void Write()
        {
            Console.WriteLine("A good student regularly reads school literature and sometimes additional");
        }

        public override void Relax()
        {
            Console.WriteLine("Good student balances study and rest effectively.\n");
        }
    }

    public class BadPupil : Pupil
    {
        public BadPupil(string name, int age, int Class) : base(name, age, Class) { }

        public override void Study()
        {
            Console.WriteLine("Bad student often skips classes and doesn't complete assignments.");
        }

        public override void Read()
        {
            Console.WriteLine("A bad student does not read the literature that is given for study.");
        }

        public override void Write()
        {
            Console.WriteLine("A bad student almost always does not write class notes.");
        }

        public override void Relax()
        {
            Console.WriteLine("Bad student prefers resting over studying.\n");
        }
    }
}
