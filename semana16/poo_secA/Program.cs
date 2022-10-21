using System;
public class Animal
{
    public void Sleep()
    {
        Console.WriteLine("Zzzzzz");
    }
    public virtual void MakeNoise()
    {
        Console.WriteLine("Sonido Generico");
    }
}

class Dog : Animal
{
    public override void MakeNoise()
    {
        Console.WriteLine("WoofWoof");
    }
}
class Cat : Animal
{
    public override void MakeNoise()
    {
        Console.WriteLine("Meaaooooow");
    }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Instanciemos un nuevo perro");
        Dog dog1 = new Dog();
        Console.WriteLine("Ladrido del perro");
        Console.WriteLine(dog1.MakeNoise);
        Console.WriteLine("Perro anda dormi");
        Console.WriteLine(dog1.Sleep);

        Cat cat1 = new Cat();
        Console.WriteLine("Maullido del perro");
        Console.WriteLine(cat1.MakeNoise);
        Console.WriteLine("Gato anda dormi");
        Console.WriteLine(cat1.Sleep);

        Console.ReadKey();

        
    }
}