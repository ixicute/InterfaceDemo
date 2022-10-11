namespace InterfaceDemo
{
    //Detta är en interface.
    //Tänk att en interface är en "mall" för det du vill skapa.
    //I den här demo skapar vi en katt och en hund. Båda är ju djur men
    //de är olika. T.ex hunden har långa ben medans katten har en liten näsa.
    //Men likheten är att båda har ben och båda har näsa!
    //Därför kan det vara bra att skapa en mall för vad vi vill att djuren vi skapar
    //ska bestå av!
    interface IDjur
    {
        //Alla metoder vi lägger till här kommer att krävas för att kunna ärva från interfacet!
        //Kolla kommentarerna i Katt och sedan Dog klasserna!
        void Fur();
        void Legs();
        void Nose();
    }

}