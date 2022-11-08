//class programs lavatrice
public class ProgrammaLavatrice
{
    public string NomeProgramma { get; }
    public int CostoInGettoni { get; }
    public int Durata { get; }
    public int QtDetersivo { get; }
    public int QtAmmorbidente { get; }

    //constructor
    public ProgrammaLavatrice(string nomeProgramma, int costo, int durata, int detersivo, int ammorbidente)
    {
        NomeProgramma = nomeProgramma;
        CostoInGettoni = costo;
        Durata = durata;
        QtDetersivo = detersivo;
        QtAmmorbidente = ammorbidente;
    }
}
