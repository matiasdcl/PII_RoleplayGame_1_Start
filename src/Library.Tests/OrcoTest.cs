using NUnit.Framework;

namespace Library.Tests;

[TestFixture]
[TestOf(typeof(Orco))]
public class OrcoTest
{

    [Test]
    public void TestGetVida()
    {
        Orco grom = new Orco("Grom");
        int vida = grom.GetVidaActual();
        Assert.That(vida, Is.EqualTo(220));
    }
    
    [Test]
    public void TestGetAtaque()
    {
        Orco grom = new Orco("Grom");
        int ataque = grom.GetAtaque();
        Assert.That(ataque, Is.EqualTo(35));
    }
    
    [Test]
    public void TestGetDefensa()
    {
        Orco grom = new Orco("Grom");
        int ataque = grom.GetDefensa();
        Assert.That(ataque, Is.EqualTo(0));
    }
    
    [Test]
    public void TestGetNombre()
    {
        Orco grom = new Orco("Grom");
        string nombre = grom.GetNombre();
        Assert.That(nombre, Is.EqualTo("Grom"));
    }
    
    [Test]
    public void TestGetEquippedItems()
    {
        Orco grom = new Orco("Grom");
        Assert.That(grom.GetEquipedItems().Count, Is.EqualTo(0));
    }
    
    [Test]
    public void TestAtaqueOrcoVsElfo()
    {
        Orco grom = new Orco("Grom");
        Elfo legolas = new Elfo("Legolas");
        grom.AtacarElfo(legolas);
        Assert.That(legolas.GetVidaActual(), Is.EqualTo(115));
    }
    
    [Test]
    public void TestAtaqueOrcoVsOrco()
    {
        Orco grom = new Orco("Grom");
        Orco krenko = new Orco("Krenko");
        grom.AtacarOrco(krenko);
        Assert.That(krenko.GetVidaActual(), Is.EqualTo(185));
    }
    
    [Test]
    public void TestAtaqueOrcoVsMago()
    {
        Orco grom = new Orco("Grom");
        Mago radagast = new Mago("Radagast");
        grom.AtacarMago(radagast);
        Assert.That(radagast.GetVidaActual(), Is.EqualTo(55));
    }
    
    [Test]
    public void TestAtaqueOrcoVsEnano()
    {
        Orco grom = new Orco("Grom");
        Enano rand = new Enano("Rand");
        grom.AtacarEnano(rand);
        Assert.That(rand.GetVidaActual(), Is.EqualTo(165) );
    }

    [Test]
    public void TestEquiparItem()
    {
        Item item1 = new Item("Excalibur", 0, 100);
        Orco grom = new Orco("Grom");
        grom.EquiparItem(item1);
        Assert.That(grom.GetEquipedItems().Contains(item1), Is.True);
        Assert.That(grom.GetAtaque(), Is.EqualTo(135));
        Item item2 = new Item("Ropa", 40, 0);
        grom.EquiparItem(item2);
        Assert.That(grom.GetEquipedItems().Contains(item2), Is.True);
        Assert.That(grom.GetDefensa(),Is.EqualTo(40));
    }

    [Test]
    public void TestDesequiparItem()
    {
        Item item = new Item("Excalibur", 0, 100);
        Orco grom = new Orco("Grom");
        grom.EquiparItem(item);
        grom.DesequiparItem(item);
        Assert.That(grom.GetEquipedItems().Contains(item), Is.False);
        Assert.That(grom.GetAtaque(),Is.EqualTo(35));
    }
}
