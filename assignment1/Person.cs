namespace assignment1
{
    internal class Person
    {
        private string name ;
        private int age;

        public Person(int age , string name)
        {
            Name = name;
            Age = age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set {  age = value; }
        }
            
        


        public void Display()
        {
            Console.WriteLine($"Name = {Name}");
            Console.WriteLine($"Age = {Age}");
        }
    }
}
