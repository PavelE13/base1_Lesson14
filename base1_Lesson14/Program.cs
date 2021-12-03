using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base1_Lesson14
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal;
            Dog dogname = new Dog("собака");
            Cat catname = new Cat("кошка");
            Console.Write(" Введите вид животного: 1 - собака, 2 - кошка?: ");
            string nameNumber = Console.ReadLine();
            if (nameNumber is "1")
            {
                string name = "собака";
                animal = dogname;
                animal.Showinfo(name);
            }
            else
            {
                if (nameNumber is "2")
                {
                    string name = "кошка";
                    animal = catname;
                    animal.Showinfo(name);
                }
                else
                {
                        Console.WriteLine(" Ошибка!Неверный формат ввода!Прерывание");
                }
            }
            Console.ReadKey();
        }
        abstract class Animal
        {
           public string name;
            public abstract string Name { get; set;}
            public Animal(string name)
            {
                Name = name;
            }
            public abstract void Say();
            public void Showinfo(string name)
            {
                Console.WriteLine(name);
                Say();
            }
        }
        class Dog : Animal
        {
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = "собака";
                }
            }
            public Dog(string name): base(name)
            {
                Name = name;
            }
            public override void Say()
            {
                Console.WriteLine(" Гав!");
            }
        }
        class Cat : Animal
        {
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = "кошка";
                }
            }
            public Cat(string name) :base(name)
            {
                Name = name;
            }
            public override void Say()
            {
                Console.WriteLine(" Мяу!");
                return;
            }
        }
    }
}
