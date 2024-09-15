using NUnit.Framework;

namespace Library.Tests;

[TestFixture]
[TestOf(typeof(Item))]
public class ItemTest
{
    [Test]
    public void TestNombre()
    {
        Item espada = new Item("Espada de hierro", 0, 1000);
        Assert.That(espada.GetNombre(), Is.EqualTo("Espada de hierro"));
    }

    [Test]
    public void TestDefensa()
    {
        Item capa = new Item("Capa de hierro", 250, 0);
        Assert.That(capa.GetDefensa(), Is.EqualTo(250));
    }

    [Test]
    public void TestAtaque()
    {
        Item espada = new Item("Espada de hierro", 0, 1000);
        Assert.That(espada.GetAtaque(), Is.EqualTo(1000));
    }
}