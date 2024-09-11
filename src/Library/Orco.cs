using System;
namespace Library;

public class Orco
{
    private string nombre;
    private int vida;
    private int ataque;
    private List<Item> items;

    public string Nombre
    {
        get { return nombre; }
        set
        {
            Herramientas.ValidarNombre(Nombre);
            nombre = value;}
    }

    public int Vida
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

    public int Ataque
    {
        get { return ataque; }
        set
        {
            Herramientas.ValidarEstadistica(value);
            ataque = value;
        }
    }

    public List<Item> Items
    {
        get { return items; }
        set { items = value; }
    }

    public Orco(string nombre)
    {
        this.nombre = nombre;
        ataque = 35;
        vida = 220;
        items = new List<Item>();
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
        foreach (Item elemento in this.items.ToList())
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
    
}