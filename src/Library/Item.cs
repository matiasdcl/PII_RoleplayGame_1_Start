namespace Library;

public class Item
{
    private string Nombre { get; }
    private int Defensa { get; }
    private int Ataque { get; }
    
    public string GetNombre()
    {
        return this.Nombre;
    }
    
    public int GetDefensa()
    {
        return this.Defensa;
    }
    
    public int GetAtaque()
    {
        return this.Ataque;
    }

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