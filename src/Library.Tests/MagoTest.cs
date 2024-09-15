using NUnit.Framework;

namespace Library.Tests;

[TestFixture]
[TestOf(typeof(Mago))]
public class MagoTest
{

    [Test]
    public void TestGetVida()
    {
        Mago gandalf = new Mago("Gandalf");
        int vida = gandalf.GetVidaActual();
        Assert.That(vida, Is.EqualTo(90));
    }
    
    [Test]
    public void TestGetAtaque()
    {
        Mago gandalf = new Mago("Gandalf");
        int ataque = gandalf.GetAtaque();
        Assert.That(ataque, Is.EqualTo(150));
    }
    
    [Test]
    public void TestGetDefensa()
    {
        Mago gandalf = new Mago("Gandalf");
        int ataque = gandalf.GetDefensa();
        Assert.That(ataque, Is.EqualTo(0));
    }
    
    [Test]
    public void TestGetNombre()
    {
        Mago gandalf = new Mago("Gandalf");
        string nombre = gandalf.GetNombre();
        Assert.That(nombre, Is.EqualTo("Gandalf"));
    }
    
    [Test]
    public void TestGetEquippedItems()
    {
        Mago gandalf = new Mago("Gandalf");
        Assert.That(gandalf.GetEquipedItems(), Is.Empty);
    }
    
    [Test]
    public void TestGetEquippedLibros()
    {
        Mago gandalf = new Mago("Gandalf");
        Assert.That(gandalf.GetEquipedLibros(), Is.Empty);
    }
    
    [Test]
    public void TestAtaqueMagoVsElfo()
    {
        Mago gandalf = new Mago("Gandalf");
        Elfo legolas = new Elfo("Legolas");
        gandalf.AtacarElfo(legolas);
        Assert.That(legolas.GetVidaActual(), Is.EqualTo(0) );
    }
    
    [Test]
    public void TestAtaqueMagoVsOrco()
    {
        Mago gandalf = new Mago("Gandalf");
        Orco grom = new Orco("Grom");
        gandalf.AtacarOrco(grom);
        Assert.That(grom.GetVidaActual(), Is.EqualTo(70));
    }
    
    [Test]
    public void TestAtaqueMagoVsMago()
    {
        Mago gandalf = new Mago("Gandalf");
        Mago radagast = new Mago("Radagast");
        gandalf.AtacarMago(radagast);
        Assert.That(radagast.GetVidaActual(), Is.EqualTo(0) );
    }
    
    [Test]
    public void TestAtaqueMagoVsEnano()
    {
        Mago gandalf = new Mago("Gandalf");
        Enano minion = new Enano("minion");
        gandalf.AtacarEnano(minion);
        Assert.That(minion.GetVidaActual(), Is.EqualTo(50) );
    }

    [Test]
    public void TestEquiparItem()
    {
        Item item1 = new Item("Baculo Magico", 0, 150);
        Mago gandalf = new Mago("Gandalf");
        gandalf.EquiparItem(item1);
        Assert.That(gandalf.GetEquipedItems().Contains(item1), Is.True);
        Assert.That(gandalf.GetAtaque(), Is.EqualTo(300));
        Item item2 = new Item("Tunica", 90, 0);
        gandalf.EquiparItem(item2);
        Assert.That(gandalf.GetEquipedItems().Contains(item2), Is.True);
        Assert.That(gandalf.GetDefensa(),Is.EqualTo(90));
    }

    [Test]
    public void TestDesequiparItem()
    {
        Item item = new Item("Baculo Magico", 0, 150);
        Mago gandalf = new Mago("Gandalf");
        gandalf.EquiparItem(item);
        gandalf.DesequiparItem(item);
        Assert.That(gandalf.GetEquipedItems().Contains(item), Is.False);
        Assert.That(gandalf.GetAtaque(),Is.EqualTo(150));
    }

    [Test]
    public void TestEquiparLibroDesequiparLibro()
    {
        Hechizo hechizo = new Hechizo("Curacion Completa", 150, 0);
        LibroDeHechizos libro = new LibroDeHechizos(hechizo);
        Mago gandalf = new Mago("Gandalf");
        gandalf.EquiparLibro(libro);
        Assert.That(gandalf.GetEquipedLibros().Contains(libro), Is.True);
        gandalf.DesequiparLibro(libro);
        Assert.That(gandalf.GetEquipedLibros().Contains(libro), Is.False);
    }

    [Test]
    public void TestUsarHechizo()
    {
        Hechizo hechizo = new Hechizo("Curacion Completa", 150, 0);
        LibroDeHechizos libro = new LibroDeHechizos(hechizo);
        Mago gandalf = new Mago("Gandalf");
        gandalf.EquiparLibro(libro);
        gandalf.GetDaño(150);
        gandalf.UsarLibroDeHechizos(libro);
        Assert.That(gandalf.GetVidaActual(), Is.EqualTo(150));
    }
}
