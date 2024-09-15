using NUnit.Framework;

namespace Library.Tests;

[TestFixture]
[TestOf(typeof(Enano))]
public class EnanoTest
{
    [Test]
    public void TestGetVida()
    {
        Enano minion = new Enano("minion");
        int vida = minion.GetVidaActual();
        Assert.That(vida, Is.EqualTo(200));
    }
    
    [Test]
    public void TestGetAtaque()
    {
        Enano minion = new Enano("minion");
        int ataque = minion.GetAtaque();
        Assert.That(ataque, Is.EqualTo(40));
    }
    
    [Test]
    public void TestGetDefensa()
    {
        Enano minion = new Enano("minion");
        int ataque = minion.GetDefensa();
        Assert.That(ataque, Is.EqualTo(0));
    }
    
    [Test]
    public void TestGetNombre()
    {
        Enano minion = new Enano("minion");
        string nombre = minion.GetNombre();
        Assert.That(nombre, Is.EqualTo("minion"));
    }
    
    [Test]
    public void TestGetEquippedItems()
    {
        Enano minion = new Enano("minion");
        Assert.That(minion.GetEquipedItems(), Is.Empty);
    }
    
    [Test]
    public void TestAtaqueEnanoVsElfo()
    {
        Enano minion = new Enano("minion");
        Elfo legolas = new Elfo("Legolas");
        minion.AtacarElfo(legolas);
        Assert.That(legolas.GetVidaActual(), Is.EqualTo(110) );
    }
    
    [Test]
    public void TestAtaqueEnanoVsOrco()
    {
        Enano minion = new Enano("minion");
        Orco grom = new Orco("Grom");
        minion.AtacarOrco(grom);
        Assert.That(grom.GetVidaActual(), Is.EqualTo(180));
    }
    
    [Test]
    public void TestAtaqueEnanoVsMago()
    {
        Enano minion = new Enano("minion");
        Mago radagast = new Mago("Radagast");
        minion.AtacarMago(radagast);
        Assert.That(radagast.GetVidaActual(), Is.EqualTo(50) );
    }
    
    [Test]
    public void TestAtaqueEnanoVsEnano()
    {
        Enano minion = new Enano("minion");
        Enano rand = new Enano("Rand");
        minion.AtacarEnano(rand);
        Assert.That(rand.GetVidaActual(), Is.EqualTo(160) );
    }

    [Test]
    public void TestEquiparItem()
    {
        Item item1 = new Item("Baculo Magico", 0, 150);
        Enano minion = new Enano("minion");
        minion.EquiparItem(item1);
        Assert.That(minion.GetEquipedItems().Contains(item1), Is.True);
        Assert.That(minion.GetAtaque(), Is.EqualTo(300));
        Item item2 = new Item("Tunica", 90, 0);
        minion.EquiparItem(item2);
        Assert.That(minion.GetEquipedItems().Contains(item2), Is.True);
        Assert.That(minion.GetDefensa(),Is.EqualTo(90));
    }

    [Test]
    public void TestDesequiparItem()
    {
        Item item = new Item("Lanza", 0, 70);
        Enano minion = new Enano("minion");
        minion.EquiparItem(item);
        minion.DesequiparItem(item);
        Assert.That(minion.GetEquipedItems().Contains(item), Is.False);
        Assert.That(minion.GetAtaque(),Is.EqualTo(200));
    }
}