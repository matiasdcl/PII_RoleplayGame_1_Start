namespace Library;

class Program{
    public static void Main()
    {
        Enano tato = new Enano("Tato");
        Console.WriteLine(tato.Nombre);
        Console.WriteLine(tato.Vida);
        Console.WriteLine(tato.Ataque);
    }
}