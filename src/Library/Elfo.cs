namespace Library;

public class Elfo
{
    private int vida;
    private int ataque;
    private string nombre;
    private List<Item> items = new List<Item>();
    private List<LibroDeHechizos> libros = new List<LibroDeHechizos>();

    public int Vida
    {
        get { return this.vida; }
        set
        {
            if (value < 0)
            {
                this.vida = 0;
            }
            else
            {
                this.vida = value;
            }
        }
    }

    public int Ataque
    {
        get { return this.ataque; }
        set
        {
            Herramientas.ValidarEstadistica(value);
            this.ataque = value;
        }
    }

    public string Nombre
    {
        get { return this.nombre; }
        set
        {
            Herramientas.ValidarNombre(value);
            this.nombre = value;
        }
    }
    public Elfo(string nombre)
    {
        this.vida = 150;
        this.ataque = 40;
        Herramientas.ValidarNombre(nombre);
        this.nombre = nombre;
    }

    public void EquiparItem(Item item)
    {
        if (!this.items.Contains(item))
        {
            this.items.Add(item);
        }
    }

    public void DesequiparItem(Item item)
    {
        foreach (Item elemento in this.items)
        {
            if (elemento == item)
            {
                this.items.Remove(elemento);
            }
        }
    }

    public void AtacarElfo(Elfo elfo)
    {
        elfo.Vida -= this.Ataque;
    }
    
    public void AtacarEnano(Enano enano)
    {
        enano.Vida -= this.Ataque;
    }
    
    public void AtacarOrco(Orco orco)
    {
        orco.Vida -= this.Ataque;
    }
    
    public void AtacarMago(Mago mago)
    {
        mago.Vida -= this.Ataque;
    }

    public void EquiparLibro(LibroDeHechizos libro)
    {
        if (!this.libros.Contains(libro))
        {
            this.libros.Add(libro);
        }
    }

    public void DesequiparLibro(LibroDeHechizos libro)
    {
        foreach (LibroDeHechizos elemento in this.libros)
        {
            if (elemento == libro)
            {
                this.libros.Remove(elemento);
            }
        }
    }

    public void UsarHechiszo(Hechizo hechizo)
    {
        if (this.vida > 0)
        {
            return;
        }
        this.vida = 150;
    }
}