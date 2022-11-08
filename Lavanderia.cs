// create macro obj lavanderia
public class Lavanderia
{
    public Lavatrice[] LavatriciArray { get; }
    public Asciugatrice[] AsciugatriciArray { get; }

    //constructor
    public Lavanderia()
    {
        //brute force Lavatrici
        LavatriciArray = new Lavatrice[5];

        for(int i=0; i< LavatriciArray.Length; i++)
        {
            LavatriciArray[i] = new Lavatrice( "Lavatrice "+(i + 1)); 
        }

        //brute force Asciugatrici
        AsciugatriciArray = new Asciugatrice[5];

        for (int i = 0; i < AsciugatriciArray.Length; i++)
        {
            AsciugatriciArray[i] = new Asciugatrice("Asciugatrice " + (i + 1));
        }

    }
    public void StatusMachines()
    {
        //to print general status washingmachinces
        Console.WriteLine("STATO LAVATRICI:");
        for (int i = 0; i < LavatriciArray.Length; i++)
        {
            Console.WriteLine("Nome: " + LavatriciArray[i].Nome);
            if (LavatriciArray[i].InFunzione)
            {
                Console.WriteLine("Stato: lavaggio in corso");
            }
            else
            {
                Console.WriteLine("Stato: inattiva");
            }
        }
        Console.WriteLine("------");
        //to print general status dryers
        Console.WriteLine("STATO ASCIUGATRICI:");
        for (int i = 0; i < AsciugatriciArray.Length; i++)
        {
            Console.WriteLine("Nome: " + AsciugatriciArray[i].Nome);
            if (AsciugatriciArray[i].InFunzione)
            {
                Console.WriteLine("Stato: lavaggio in corso");
            }
            else
            {
                Console.WriteLine("Stato: inattiva");
            }
        }
    }
    public void StatusLavatrice(int number)
    {
        //In this context number is gonna be between 1-5 but Lavatrici index is 0-4
        Console.WriteLine("Status Lavatrice:");
        Console.WriteLine(LavatriciArray[number - 1].Nome);
        Console.WriteLine("In uso: " + LavatriciArray[number - 1].InFunzione);
        Console.WriteLine("Programma " + LavatriciArray[number - 1].Programma);
        //if(LavatriciArray[number - 1].Programma == 1)
        //{
        //    Console.WriteLine("Programma Rinfrescante, max 20 minutes");
        //} else if (LavatriciArray[number - 1].Programma == 2)
        //{
        //    Console.WriteLine("Programma Rinnovante, max 40 minutes");
        //} else if (LavatriciArray[number - 1].Programma == 3)
        //{
        //    Console.WriteLine("Programma Sgrassante, max 60 minutes");
        //} else
        //{
        //    Console.WriteLine("");
        //}
        Console.WriteLine("QtDetersivo: " + LavatriciArray[number - 1].QtDetersivo);
        Console.WriteLine("QtAmmorbidente: " + LavatriciArray[number - 1].QtAmmorbidente);
    }   
    public void StatusAsciugatrice(int number)
    {
        //In this context number is gonna be between 1-5 but Asciugatrici index is 0-4
        Console.WriteLine("Status Asciugatrice:");
        Console.WriteLine(AsciugatriciArray[number - 1].Nome);
        Console.WriteLine("In uso: " + AsciugatriciArray[number - 1].InFunzione);
    }
}