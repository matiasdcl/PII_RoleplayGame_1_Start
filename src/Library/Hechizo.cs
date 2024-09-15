namespace Library;

public class Hechizo
{
    private string Nombre { get; }
    private int Vida { get; }
    private int Ataque { get; }
    
    public string GetNombre()
    {
        return this.Nombre;
    }
    
    public int GetVida()
    {
        return this.Vida;
    }
    
    public int GetAtaque()
    {
        return this.Ataque;
    }

    public Hechizo(string nombre, int vida, int ataque)
    {
        Herramientas.ValidarNombre(nombre);
        this.Nombre = nombre;
        Herramientas.ValidarEstadistica(vida);
        this.Vida = vida;
        Herramientas.ValidarEstadistica(ataque);
        this.Ataque = ataque;
    }
}