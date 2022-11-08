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
//DONE
//2 - Possa essere richiesto il dettaglio di una macchina: Tutte le informazioni relative alla macchina, nome del macchinario, stato del macchinario
//(in funzione o no), tipo di lavaggio in corso, quantità di detersivo presente (se una lavatrice), durata del lavaggio, tempo rimanente alla fine del
//lavaggio.
//ALMOST DONE
//3 - l’attuale incasso generato dall’utilizzo delle macchine.


// create macro obj lavanderia
Lavanderia lavanderia = new Lavanderia();

//create 3 programs
//ProgrammaLavatrice rinfrescante = new ProgrammaLavatrice(1, "Rinfrescante", 2, 20, 20, 5);
//ProgrammaLavatrice rinnovante = new ProgrammaLavatrice(2, "Rinnovante", 3, 40, 40, 10);
//ProgrammaLavatrice sgrassante = new ProgrammaLavatrice(3, "Sgrassante", 4, 60, 60, 15);

//very basic prompt.. need to create function to relaunch it
Console.WriteLine("Starting..");
Cycle();

void Cycle()
{
    Console.WriteLine("---");
    Console.WriteLine("Premi:");
    Console.WriteLine("1 - Stato generale macchine");
    Console.WriteLine("2 - Stato di una macchina");
    Console.WriteLine("3 - EndProgram");
    Console.WriteLine("---");
    int answer = Convert.ToInt32(Console.ReadLine());

    if(answer == 1)
    {
        lavanderia.StatusMachines();
        Cycle();

    } else if (answer == 2)
    {
        Console.WriteLine("---");
        Console.WriteLine("Premi:");
        Console.WriteLine("1 - Lavatrici");
        Console.WriteLine("2 - Asciugatrici");
        Console.WriteLine("---");
        int answer2 = Convert.ToInt32(Console.ReadLine());
        if (answer2 == 1)
        {
            Console.WriteLine("---");
            Console.WriteLine("Seleziona una macchina da 1 a 5");
            int answer3 = Convert.ToInt32(Console.ReadLine());
            lavanderia.StatusLavatrice(answer3);
            Console.WriteLine("---");
            Cycle();
        }
        else if (answer2 == 2)
        {
            Console.WriteLine("---");
            Console.WriteLine("Seleziona una macchina da 1 a 5");
            int answer3 = Convert.ToInt32(Console.ReadLine());
            lavanderia.StatusAsciugatrice(answer3);
            Console.WriteLine("---");
            Cycle();
        }
    }
}

