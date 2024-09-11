namespace Library;

public class Program
{
    public static void Main()
    {
        Item espada = new Item("Espada Cool", 0, 5000);
        Console.WriteLine(espada.Ataque);

        Hechizo hechizo = new Hechizo("Revivir", 150, 0);
        LibroDeHechizos libro = new LibroDeHechizos();
        libro.AprenderHechizo(hechizo);

        Elfo legolas = new Elfo("Legolas");
        Console.WriteLine(legolas.Ataque);
        Console.WriteLine(legolas.Vida);
        legolas.EquiparItem(espada);
        legolas.EquiparLibro(libro);
        
        Console.WriteLine(legolas.Nombre);
        Console.WriteLine(legolas.Ataque);
        Console.WriteLine(legolas.Vida);
        legolas.Vida = 0;
        Console.WriteLine(legolas.Vida);

        legolas.UsarHechizo(hechizo);
        Console.WriteLine(legolas.Vida);

        Enano krenko = new Enano("Krenko");
        krenko.AtacarElfo(legolas);
        Console.WriteLine(legolas.Vida);
        legolas.AtacarEnano(krenko);
        Console.WriteLine(krenko.Vida);



    }
}


