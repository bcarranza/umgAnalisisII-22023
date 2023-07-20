public class MainClass
{
    public static void Main(string[] args)
    {
        // Create a Dog object
        IAnimal dog = new Dog();

        // Call the Speak() method on the Dog object
        string dogSound = dog.Speak();
        Console.WriteLine("The dog says: {0}", dogSound);

        // Create a Cat object
        IAnimal cat = new Cat();

        // Call the Speak() method on the Cat object
        string catSound = cat.Speak();
        Console.WriteLine("The cat says: {0}", catSound);
    }
}