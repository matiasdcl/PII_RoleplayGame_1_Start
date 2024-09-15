namespace Library;

public class Elfo
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
    public Elfo(string nombre)
    {
        this.vida = 150;
        this.defensa = 0;
        this.ataque = 40;
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
            this.Defensa += item.GetDefensa();
            this.Ataque += item.GetAtaque();
        }
        else
        {
            Console.WriteLine("El item indicado ya fue equipado");
        }
    }

    public void DesequiparItem(Item item)
    {
        if (this.items.Contains(item))
        {
            this.items.Remove(item);
            this.Vida -= item.GetDefensa();
            this.Ataque -= item.GetAtaque();
        }
        else
        {
            Console.WriteLine("El personaje no tiene ese item.");
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
            int danoRealizado = this.ataque - elfo.GetDefensa() ;
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
        if (this.libros.Contains(libro))
        {
            this.libros.Remove(libro);
        }
        else
        {
            Console.WriteLine("El personaje no tiene ese libro.");
        }
    }

    public void UsarLibroDeHechizos(LibroDeHechizos libro)
    {
        if (this.libros.Contains(libro))
        {
            if (this.vida > 0)
            {
                return;
            }
            this.vida = libro.Hechizo.Vida;
        }
    }
}