using Library;
namespace Program;

public class Program
{
    public static void Main()
    {
         Item espada = new Item("Espada Cool", 0, 5000);
         Console.WriteLine(espada.GetAtaque());
        //

        
         Elfo legolas = new Elfo("Legolas");
         Console.WriteLine(legolas.GetAtaque());
         Console.WriteLine(legolas.GetVidaActual());
         legolas.EquiparItem(espada);
        
         Console.WriteLine(legolas.GetNombre());
         Console.WriteLine(legolas.GetAtaque());
        
         Enano krenko = new Enano("Krenko");
         krenko.AtacarElfo(legolas);
         Console.WriteLine(legolas.GetVidaActual()); legolas.AtacarEnano(krenko);
         Console.WriteLine(krenko.GetVidaActual());
    }
}


