using System;

namespace Exercise6
{
    internal class DogTest
    {
        public static DogTest doggos = new DogTest();

        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Max", "male");
            Dog dog2 = new Dog("Rocky", "male");
            Dog dog3 = new Dog("Sparky", "male");
            Dog dog4 = new Dog("Buster", "male");
            Dog dog5 = new Dog("Sam", "male");
            Dog dog6 = new Dog("Lady", "female");
            Dog dog7 = new Dog("Molly", "female");
            Dog dog8 = new Dog("Coco", "female");

            dog1.SetMother(dog6);
            dog8.SetMother(dog7);
            dog2.SetMother(dog7);
            dog4.SetMother(dog6);

            dog1.SetFather(dog2);
            dog8.SetFather(dog4);
            dog2.SetFather(dog5);
            dog4.SetFather(dog3);

            Console.WriteLine("Cocos dad : " + dog8.GetFathersName());
            Console.WriteLine("Sparkys dad : " + dog3.GetFathersName());

            Console.Write("\nDoes Coco have the same mother as Rocky :: ");
            Console.Write(dog8.HasSameMotherAs(dog2).ToString());
            Console.ReadKey();
        }
    }
}
