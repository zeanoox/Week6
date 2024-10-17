namespace assignment1
{
    internal class Person
    {
        private string Name;
        private int Age;

        public Person(int age , string name)
        {
            Name = name;
            Age = age;
        }


        public void Display()
        {
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Age = {Age}");
        }
    }
}
