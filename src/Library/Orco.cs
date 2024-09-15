using System;
namespace Library;

public class Orco
{
    private string nombre;
    private int vida;
    private int ataque;
    private int defensa;
    private List<Item> items;

    private string Nombre
    {
        get { return nombre; }
        set
        {
            Herramientas.ValidarNombre(Nombre);
            nombre = value;}
    }

    private int Vida
    {
        get { return vida; }
        set
        {
            if (value < 0)
            {
                vida = 0;
            }
            else
            {
                vida = value;
            }
        }
    }

    private int Ataque
    {
        get { return ataque; }
        set
        {
            Herramientas.ValidarEstadistica(value);
            ataque = value;
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

    public Orco(string nombre)
    {
        ataque = 35;
        vida = 220;
        defensa = 0;
        Herramientas.ValidarNombre(nombre);
        this.nombre = nombre;
        this.items = new List<Item>();
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
        if (this.vida - danoRealizado < 0)
        {
            return this.vida = 0;
        }
        else
        {
            return this.vida -= danoRealizado;
        }
    }

    public List<Item> GetEquipedItems()
    {
        return this.items;
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
}