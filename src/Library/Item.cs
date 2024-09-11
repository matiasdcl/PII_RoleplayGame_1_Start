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
        if (defensa < 0 || ataque < 0)
        {
            throw new AggregateException("Valor de defensa o ataque inválidos");
        }
        this.Defensa = defensa;
        this.Ataque = ataque;
    }
}