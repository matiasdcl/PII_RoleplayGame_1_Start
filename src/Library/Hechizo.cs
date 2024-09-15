namespace Library;

public class Hechizo
{
    public string Nombre { get; }
    public int Vida { get; }
    public int Ataque { get; }

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