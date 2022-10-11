namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //här skapar vi objekt av båda klasserna och anropar metoderna.
            Cat kitty = new Cat();
            kitty.Fur();
            kitty.Legs();
            kitty.Nose();

            Console.WriteLine("---------------------------");
            Dog dogo = new Dog();
            dogo.Fur();
            dogo.Legs();
            dogo.Nose();

            //Testa själv att anropa "properties" i klasserna vi skapade

            //Testa vad som händer om man ändrar värdet i, exempelvis kattens namn.

            //Testa ändra i klasserna (Dog och Cat) och se om du kan få den att skriva ut
            //kattens namn både FÖRE och EFTER att du ändrar namnet!
        }
    }
}