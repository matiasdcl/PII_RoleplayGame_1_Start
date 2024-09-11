namespace Library;

public class Item
{
    public string Nombre { get; }
    public int Defensa { get; }
    public int Ataque { get; }

    public Item(string nombre, int defensa, int ataque)
    {
        Herramientas.ValidarNombre(nombre);
        this.Nombre = nombre;
        Herramientas.ValidarEstadistica(defensa);
        this.Defensa = defensa;
        Herramientas.ValidarEstadistica(ataque);
        this.Ataque = ataque;
    }
}