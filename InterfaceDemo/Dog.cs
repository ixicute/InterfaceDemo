namespace InterfaceDemo
{
    //Läs kommentaren för klassen "Cat". Samma princip häller här!
    //Enda skillnaden är att vi har valt att implementera metoderna
    //med en annorlunda kod (eftersom en hund inte är lik en katt!)
    class Dog : IDjur
    {
        public void Fur()
        {
            Console.WriteLine("Hunden har mycket päls!");
        }
        public void Legs()
        {
            Console.WriteLine("Hunden har långa ben!");
        }
        public void Nose()
        {
            Console.WriteLine("Hunden har en stor näsa!");
        }
    }
 }