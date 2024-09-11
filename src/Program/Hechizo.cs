namespace Program;

public class Hechizo
{
    public string Nombre { get; }
    public int Vida { get; }
    public int Ataque { get; }

    public Hechizo(string nombre, int vida, int ataque)
    {
        string caracteresPermitidos = "qQwWeErRtTyYuUiIoOpPsSaAdDFfGgHhJjKkLlÑñZzXxCcVvBbNnMm";
        foreach (char caracter in nombre)
        {
            if (!caracteresPermitidos.Contains(caracter))
            {
                throw new ArgumentException("Nombre inválido");
            }
        }

        this.Nombre = nombre;
        if (vida < 0 || ataque < 0)
        {
            throw new AggregateException("Valor de defensa o ataque inválidos");
        }

        this.Vida = vida;
        this.Ataque = ataque;
    }
}