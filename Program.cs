//Una lavanderia è aperta 24 ore su 24 e permette ai clienti di servizi autonomamente di 5 Lavatrici e 5 Asciugatrici.
//I clienti che usufruiscono delle macchine, possono effettuare diversi programmi di lavaggio e asciugatura ognuno con un costo diverso (in gettoni)
//e di una specifica durata. Ogni gettone costa 0.50 centesimi di euro e ogni lavaggio consuma detersivo e ammorbidente dai serbatoi della lavatrice.
//Ogni lavatrice può tenere fino ad un massimo di 1 litro di detersivo e 500ml di ammorbidente.

//I programmi di lavaggio hanno quindi queste caratteristiche
//Rinfrescante, costo di 2 gettoni, durata di 20 minuti, consumo di 20ml di detersivo e 5ml di ammorbidente.
//Rinnovante, costo di 3 gettoni, durata di 40 minuti, consumo di 40ml di detersivo e 10ml di ammorbidente.
//Sgrassante, costo di 4 gettoni, durata di 60 minuti, consumo di 60 ml di detersivo e 15ml di ammorbidente.

//Le asciugatrici invece hanno soltanto due programmi di asciugatura,
//rapido 2 gettoni e intenso 4 gettoni della durata di 30 minuti e 60 minuti rispettivamente.

//Si richiede di creare un sistema di controllo in grado di riportare lo stato della lavanderia, in particolare si vuole richiedere:
//1 - Lo stato generale di utilizzo delle macchine: un elenco di tutte le macchine che semplicemente dica quali sono in funzione e quali non lo sono
//(in lavaggio / asciugatura oppure ferme)
//2 - Possa essere richiesto il dettaglio di una macchina: Tutte le informazioni relative alla macchina, nome del macchinario, stato del macchinario
//(in funzione o no), tipo di lavaggio in corso, quantità di detersivo presente (se una lavatrice), durata del lavaggio, tempo rimanente alla fine del
//lavaggio.
//3 - l’attuale incasso generato dall’utilizzo delle macchine.


// create obj lavatrice and asciugatrice.

Lavanderia lavanderia = new Lavanderia();

Console.WriteLine("Premi:");
Console.WriteLine("1 - Stato generale macchine");
Console.WriteLine("2 - Stato di una macchina");
int answer = Convert.ToInt32(Console.ReadLine());

if(answer == 1)
{
    lavanderia.StatusMachines();
} else if (answer == 2)
{
    Console.WriteLine("Premi:");
    Console.WriteLine("1 - Lavatrici");
    Console.WriteLine("2 - Asciugatrici");
    int answer2 = Convert.ToInt32(Console.ReadLine());
    if (answer2 == 1)
    {
        Console.WriteLine("Seleziona una macchina da 1 a 5");
        int answer3 = Convert.ToInt32(Console.ReadLine());
        lavanderia.StatusLavatrice(answer3);
    }
    else if (answer2 == 2)
    {
        Console.WriteLine("Seleziona una macchina da 1 a 5");
        int answer3 = Convert.ToInt32(Console.ReadLine());
        lavanderia.StatusLavatrice(answer3);
    }
}


//class lavatrice

public class Lavatrice
{
    //properties
    public string Nome { get; }
    public bool InFunzione { get; }
    public int QtDetersivo { get; }
    public int QtAmmorbidente { get; }

    //costruttore
    public Lavatrice(string nome)
    {
        Nome = nome;
        Random rnd = new Random();
        var randomBool = rnd.Next(2) == 1; // 0 = false, 1 = true;
        InFunzione = randomBool;
        QtDetersivo = rnd.Next(1001);
        QtAmmorbidente = rnd.Next(501);
    }
}

//class asciugatrice

public class Asciugatrice
{
    //properties
    public string Nome { get; }
    public bool InFunzione { get; }

    //costruttore
    public Asciugatrice(string nome)
    {
        Nome = nome;
        Random rnd = new Random();
        var randomBool = rnd.Next(2) == 1; // 0 = false, 1 = true;
        InFunzione = randomBool;
    }
}

//class lavanderia
public class Lavanderia
{
    public Lavatrice[] Lavatrici { get; }
    public Asciugatrice[] Asciugatrici { get; }

    //constructor
    public Lavanderia()
    {
        Lavatrici = new Lavatrice[5];

        Lavatrice lavatrice1 = new Lavatrice("Lavatrice 1");
        Lavatrice lavatrice2 = new Lavatrice("Lavatrice 2");
        Lavatrice lavatrice3 = new Lavatrice("Lavatrice 3");
        Lavatrice lavatrice4 = new Lavatrice("Lavatrice 4");
        Lavatrice lavatrice5 = new Lavatrice("Lavatrice 5");

        Lavatrici[0] = lavatrice1;
        Lavatrici[1] = lavatrice2;
        Lavatrici[2] = lavatrice3;
        Lavatrici[3] = lavatrice4;
        Lavatrici[4] = lavatrice5;

        Asciugatrici = new Asciugatrice[5];

        Asciugatrice asciugatrice1 = new Asciugatrice("Asciugatrice 1");
        Asciugatrice asciugatrice2 = new Asciugatrice("Asciugatrice 2");
        Asciugatrice asciugatrice3 = new Asciugatrice("Asciugatrice 3");
        Asciugatrice asciugatrice4 = new Asciugatrice("Asciugatrice 4");
        Asciugatrice asciugatrice5 = new Asciugatrice("Asciugatrice 5");

        Asciugatrici[0] = asciugatrice1;
        Asciugatrici[1] = asciugatrice2;
        Asciugatrici[2] = asciugatrice3;
        Asciugatrici[3] = asciugatrice4;
        Asciugatrici[4] = asciugatrice5;

        
    }
    public void StatusMachines()
    {
        //to print general status washingmachinces
        Console.WriteLine("STATO LAVATRICI:");
        for (int i = 0; i < Lavatrici.Length; i++)
        {
            Console.WriteLine("Nome: " + Lavatrici[i].Nome);
            if (Lavatrici[i].InFunzione)
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
        for (int i = 0; i < Asciugatrici.Length; i++)
        {
            Console.WriteLine("Nome: " + Asciugatrici[i].Nome);
            if (Asciugatrici[i].InFunzione)
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
        Console.WriteLine(Lavatrici[number - 1].Nome);
        Console.WriteLine("In uso: " + Lavatrici[number - 1].InFunzione);
        Console.WriteLine("QtDetersivo: " + Lavatrici[number - 1].QtDetersivo);
        Console.WriteLine("QtAmmorbidente: " + Lavatrici[number - 1].QtAmmorbidente);

    }

    public void StatusAsciugatrici(int number)
    {
        //In this context number is gonna be between 1-5 but Asciugatrici index is 0-4
        Console.WriteLine("Status Asciugatrice:");
        Console.WriteLine(Asciugatrici[number - 1].Nome);
        Console.WriteLine("In uso: " + Asciugatrici[number - 1].InFunzione);

    }
}