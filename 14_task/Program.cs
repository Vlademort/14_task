using System;

namespace _14_task
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кот");
            cat.ShowInfo();
            Console.WriteLine();
            Dog dog = new Dog("Пёс");
            dog.ShowInfo();

            Console.ReadKey();
        }
    }

    abstract class Animal
    {                
        public abstract string Name { get; set; }
       

        public Animal()
        {
           
        }
        public abstract string Say();

        public void ShowInfo()
        {
            Console.WriteLine("{0} говорит {1}", Name, Say());
        }
    }

    class Cat : Animal
    {
        string name = "Кот";

        public Cat(string n)
        {
            name = n;
        }

        public override string Say()
        {
            return "Мяу!";
        }
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

    class Dog : Animal
    {
        string name = "Пёс";

        public Dog(string n)
        {
            name = n;
        }

        public override string Say()
        {
            return "Гав!";
        }
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
