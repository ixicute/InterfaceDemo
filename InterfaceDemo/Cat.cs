namespace InterfaceDemo
{
    //Vi skapar en "Katt"-klass som ärver ifrån "IDjur"-interfacet:
    //Det innebär att:
    //Vi använder vår mall/definition för "Djur" för att skapa en katt.
    class Cat : IDjur 
    {
        //Vi skapar 2 variabler och ger de default-värden:
        private string Name = "nina";
        private int Age = 3;

        //Eftersom variablerna/fälten ovan är "Private" så lägger vi till properties
        //så att vi kan nå dessa variabler utanför klassen "Cat".
        //I andra ord, vi kan nå "Name" i Main-metoden med följande:
        public string CatName
        {
            get { return Name; }
            set { Name = value; }
        }

        //Vi når "Age" i Main-metoden med följande:
        public int CatAge
        {
            get { return Age; }
            set { Age = value; }
        }

        //En metod som returnerar kattens namn och ålder.
        //Det finns olika sätt att göra den här biten på så tänk inte att det jag skrev här är det "bästa" sättet!!!
        public string CatInfo()
        {
            string result;
            result = "Katten heter " + CatName + " och är " + CatAge + " år!";
            return result;
        }


        //Implementerade metoderna från Interfacet IDjur
        public void Fur()
        {
            //Den här delen av koden är vad man menar med "implementation".
            //Man säger vad metoden ska göra.
            //I det här fallet så skriver den ut en text.
            Console.WriteLine("Katten har lite päls");
        }

        public void Legs()
        {
            //Samma gäller här som i metoden "Fur()".
            Console.WriteLine("Katten har korta ben");
        }

        public void Nose()
        {
            //Samma gäller här som i metoden "Fur()".
            Console.WriteLine("Katten har en liten näsa!");
        }
    }
 }