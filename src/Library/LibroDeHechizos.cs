namespace Library;

public class LibroDeHechizos
{
    private List<Hechizo> listaDeHechizos = new List<Hechizo>();

    public void AprenderHechizo(Hechizo hechizo)
    {
        listaDeHechizos.Add(hechizo);
    }
}