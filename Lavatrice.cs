//class lavatrice
public class Lavatrice
{
    public ProgrammaLavatrice[] programmiArray { get; }
   
    //properties
    public string Nome { get; }
    public bool InFunzione { get; }

    public string Programma { get; }
    public int QtDetersivo { get; }
    public int QtAmmorbidente { get; }

    //constructor
    public Lavatrice(string nome)
    {
        programmiArray = new ProgrammaLavatrice[3];

        programmiArray[0] = new ProgrammaLavatrice("Rinfrescante", 2, 20, 20, 5);
        programmiArray[1] = new ProgrammaLavatrice("Rinnovante", 3, 40, 40, 10);
        programmiArray[2] = new ProgrammaLavatrice("Rinfrescante", 2, 20, 20, 5);

        Nome = nome;
        Random rnd = new Random();
        var randomBool = rnd.Next(2) == 1; // 0 = false, 1 = true;
        InFunzione = randomBool;
        if(InFunzione)
        {
            var numProgramm = rnd.Next(programmiArray.Length+1);
            Programma = programmiArray[numProgramm].NomeProgramma;
            //programm array 0-N Next is below N, so plus one to go 0 TO N and + 1 to avoid 0
            //to change for direct action on array.
            QtDetersivo = 1000 - programmiArray[numProgramm].QtDetersivo;
            QtAmmorbidente = 500 - programmiArray[numProgramm].QtAmmorbidente;
        }
        else
        {
            Programma = "";
            QtDetersivo = 1000;
            QtAmmorbidente = 500;
        }
        
    }
}
