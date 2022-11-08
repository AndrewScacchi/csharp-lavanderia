//class asciugatrice
public class Asciugatrice
{
    //properties
    public string Nome { get; }
    public bool InFunzione { get; }

    //constructor
    public Asciugatrice(string nome)
    {
        Nome = nome;
        Random rnd = new Random();
        var randomBool = rnd.Next(2) == 1; // 0 = false, 1 = true;
        InFunzione = randomBool;
    }
}
