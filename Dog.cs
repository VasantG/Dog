applies .gitingore
using System;

namespace CSharp
{
    class Program
    {
    //Create an enum Gender
    public enum Gender { Male,Female};
    //Class Dog
    class Dog
    {
        //Instance variables
        private string name;
        private string owner;
        private int age;
        private Gender gender;
        //Constructor
        public Dog(string name,string owner,int age,Gender gender)
        {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;
        }
        //Bark Sound
        public void Bark(int times)
        {
            for(int i = 0; i < times; i++)
            {
                Console.Write("Woof!");
            }
            Console.WriteLine();
        }
        //Missing Dog
        public string GetTag()
        {
            string tag = "If lost, call "+owner+". ";
            if (gender == 0)
            {
                tag += "His name is " + name + " he is " + age.ToString();
            }
            else
            {
                tag += "Her name is " + name + " she is " + age.ToString();
            }
            if (age > 1)
            {
                tag += " years old.";
            }
            else
            {
                tag += " year old.";
            }
            return tag;
        }
    }
    class Animal 
    {
        static void Main(string[] args)
        {
            // Class Animal 
            Dog puppy = new Dog("Duke", "Vasant", 5, Gender.Male); // create object instance
            puppy.Bark(5); 
            Console.WriteLine(puppy.GetTag()); 

            Dog myDog =new Dog("Diya", "Kelly", 2, Gender.Female); // create object instance
            myDog.Bark(2); 
            Console.WriteLine(myDog.GetTag()); 
    }
}
}
}


