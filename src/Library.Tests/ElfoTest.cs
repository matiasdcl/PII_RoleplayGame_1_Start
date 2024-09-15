using NUnit.Framework;

namespace Library.Tests;

[TestFixture]
public class ElfoTest
{
    
    [Test]
    public void TestGetVida()
    {
        Elfo legolas = new Elfo("Legolas");
        int vida = legolas.GetVidaActual();
        Assert.That(vida, Is.EqualTo(150));
    }
    
    [Test]
    public void TestGetAtaque()
    {
        Elfo legolas = new Elfo("Legolas");
        int ataque = legolas.GetAtaque();
        Assert.That(ataque, Is.EqualTo(40));
    }
    
    [Test]
    public void TestGetDefensa()
    {
        Elfo legolas = new Elfo("Legolas");
        int ataque = legolas.GetDefensa();
        Assert.That(ataque, Is.EqualTo(0));
    }
    
    [Test]
    public void TestGetNombre()
    {
        Elfo legolas = new Elfo("Legolas");
        string nombre = legolas.GetNombre();
        Assert.That(nombre, Is.EqualTo("Legolas"));
    }
    
    [Test]
    public void TestGetEquippedItems()
    {
        Elfo legolas = new Elfo("Legolas");
        Assert.That(legolas.GetEquipedItems(), Is.Empty);
    }
    
    [Test]
    public void TestGetEquippedLibros()
    {
        Elfo legolas = new Elfo("Legolas");
        Assert.That(legolas.GetEquipedLibros(), Is.Empty);
    }
    
    [Test]
    public void TestAtaqueElfoVsElfo()
    {
        Elfo legolas = new Elfo("Legolas");
        Elfo atacante = new Elfo("Eric");
        legolas.AtacarElfo(atacante);
        Assert.That(atacante.GetVidaActual(), Is.EqualTo(110) );
    }
    
    [Test]
    public void TestAtaqueElfoVsOrco()
    {
        Elfo legolas = new Elfo("Legolas");
        Orco grom = new Orco("Grom");
        legolas.AtacarOrco(grom);
        Assert.That(grom.GetVidaActual(), Is.EqualTo(180) );
    }
    
    [Test]
    public void TestAtaqueElfoVsMago()
    {
        Elfo legolas = new Elfo("Legolas");
        Mago gandalf = new Mago("Gandalf");
        legolas.AtacarMago(gandalf);
        Assert.That(gandalf.GetVidaActual(), Is.EqualTo(50) );
    }
    
    [Test]
    public void TestAtaqueElfoVsEnano()
    {
        Elfo legolas = new Elfo("Legolas");
        Enano minion = new Enano("minion");
        legolas.AtacarEnano(minion);
        Assert.That(minion.GetVidaActual(), Is.EqualTo(160) );
    }

    [Test]
    public void TestEquiparItem()
    {
        Item item1 = new Item("Espada", 0, 100);
        Elfo legolas = new Elfo("Legolas");
        legolas.EquiparItem(item1);
        Assert.That(legolas.GetEquipedItems().Contains(item1), Is.True);
        Assert.That(legolas.GetAtaque(), Is.EqualTo(140));
        Item item2 = new Item("Escudo", 100, 0);
        legolas.EquiparItem(item2);
        Assert.That(legolas.GetEquipedItems().Contains(item2), Is.True);
        Assert.That(legolas.GetDefensa(),Is.EqualTo(100));
    }

    [Test]
    public void TestDesequiparItem()
    {
        Item item = new Item("Espada", 0, 100);
        Elfo legolas = new Elfo("Legolas");
        legolas.EquiparItem(item);
        legolas.DesequiparItem(item);
        Assert.That(legolas.GetEquipedItems().Contains(item), Is.False);
        Assert.That(legolas.GetAtaque(),Is.EqualTo(40));
    }

    [Test]
    public void TestEquiparLibroDesequiparLibro()
    {
        Hechizo hechizo = new Hechizo("Revivir", 200, 0);
        LibroDeHechizos libro = new LibroDeHechizos(hechizo);
        Elfo legolas = new Elfo("Legolas");
        legolas.EquiparLibro(libro);
        Assert.That(legolas.GetEquipedLibros().Contains(libro), Is.True);
        legolas.DesequiparLibro(libro);
        Assert.That(legolas.GetEquipedLibros().Contains(libro), Is.False);
    }

    [Test]
    public void TestUsarHechizo()
    {
        Hechizo hechizo = new Hechizo("Revivir", 200, 0);
        LibroDeHechizos libro = new LibroDeHechizos(hechizo);
        Elfo legolas = new Elfo("Legolas");
        legolas.EquiparLibro(libro);
        legolas.GetDaño(150);
        legolas.UsarLibroDeHechizos(libro);
        Assert.That(legolas.GetVidaActual(), Is.EqualTo(200));
    }
}