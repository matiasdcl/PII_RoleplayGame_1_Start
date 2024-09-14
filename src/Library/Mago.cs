namespace Library;

public class Mago
{
    private int vida;
    private int ataque;
    private int defensa;
    private string nombre;
    private List<Item> items = new List<Item>();
    private List<LibroDeHechizos> libros = new List<LibroDeHechizos>();

    private int Vida
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

    private int Ataque
    {
        get { return this.ataque; }
        set
        {
            Herramientas.ValidarEstadistica(value);
            this.ataque = value;
        }
    }

    private int Defensa
    {
        get { return this.defensa; }
        set
        {
            Herramientas.ValidarEstadistica(value);
            this.defensa = value;
        }
    }
    
    private string Nombre
    {
        get { return this.nombre; }
        set
        {
            Herramientas.ValidarNombre(value);
            this.nombre = value;
        }
    }
    
    public Mago(string nombre)
    {
        this.vida = 90;
        this.ataque = 150;
        this.defensa = 0;
        Herramientas.ValidarNombre(nombre);
        this.nombre = nombre;
    }

    public int GetVidaActual()
    {
        return this.vida;
    }

    public string GetNombre()
    {
        return this.nombre;
    }
    
    public int GetDefensa()
    {
        return this.defensa;
    }
    
    public int GetAtaque()
    {
        return this.ataque;
    }

    public int GetDaño(int danoRealizado)
    {
        return this.vida -= danoRealizado;
    }
    
    public List<Item> GetEquipedItems()
    {
        return this.items;
    }
    
    public List<LibroDeHechizos> GetEquipedLibros()
    {
        return this.libros;
    }
    
    public void EquiparItem(Item item)
    {
        if (!this.items.Contains(item))
        {
            this.items.Add(item);
            this.defensa += item.GetDefensa();
            this.ataque += item.GetAtaque();
        }
    }

    public void DesequiparItem(Item item)
    {
        foreach (Item elemento in this.items.ToList())
        {
            if (elemento == item)
            {
                this.items.Remove(elemento);
                this.defensa -= item.GetDefensa();
                this.ataque -= item.GetAtaque();
            }
        }
    }

    public void AtacarElfo(Elfo elfo)
    {
        if (this.ataque < elfo.GetDefensa())
        {
            Console.WriteLine("El ataque no pudo ser concretado");
        }
        else
        {
            int danoRealizado = this.ataque - elfo.GetDefensa();
            elfo.GetDaño(danoRealizado);
        }
    }
    
    public void AtacarEnano(Enano enano)
    {
        if (this.Ataque < enano.GetDefensa())
        {
            Console.WriteLine("El ataque no pudo ser concretado");
        }
        else
        {
            int danoRealizado = this.ataque - enano.GetDefensa();
            enano.GetDaño(danoRealizado);
        }
    }
    
    public void AtacarOrco(Orco orco)
    {
        if (this.Ataque < orco.GetDefensa())
        {
            Console.WriteLine("El ataque no pudo ser concretado");
        }
        else
        {
            int danoRealizado = this.ataque - orco.GetDefensa();
            orco.GetDaño(danoRealizado);
        }
    }
    
    public void AtacarMago(Mago mago)
    {
        if (this.Ataque < mago.GetDefensa())
        {
            Console.WriteLine("El ataque no pudo ser concretado");
        }
        else
        {
            int danoRealizado = this.ataque - mago.GetDefensa();
            mago.GetDaño(danoRealizado);
        }
    }

    public void EquiparLibro(LibroDeHechizos libro)
    {
        if (!this.libros.Contains(libro))
        {
            this.libros.Add(libro);
        }
        else
        {
            Console.WriteLine("El libro de hechizos ya fue equipado");
        }
    }

    public void DesequiparLibro(LibroDeHechizos libro)
    {
        foreach (LibroDeHechizos elemento in this.libros.ToList())
        {
            if (elemento == libro)
            {
                this.libros.Remove(elemento);
            }
            else
            {
                Console.WriteLine("No hay un libro de hechizos equipado");
            }
        }
    }

    public void UsarHechizo(Hechizo hechizo)
    {
        if (this.vida > 0)
        {
            return;
        }
        this.vida = hechizo.Vida;
    }
}