using Library;
using NUnit.Framework;

namespace Library.Tests;

[TestFixture]
[TestOf(typeof(Hechizo))]
public class HechizoTest
{

    [Test]
    public void TestNombre()
    {
        Hechizo hechizo = new Hechizo("Revivir", 200, 0);
        Assert.That(hechizo.Nombre, Is.EqualTo("Revivir"));
    }
    [Test]
    public void TestVida()
    {
        Hechizo hechizo = new Hechizo("Revivir", 200, 0);
        Assert.That(hechizo.Vida, Is.EqualTo(200));
    }
    
    [Test]
    public void TestAtaque()
    {
        Hechizo hechizo = new Hechizo("Revivir", 200, 0);
        Assert.That(hechizo.Ataque, Is.EqualTo(0));
    }
}