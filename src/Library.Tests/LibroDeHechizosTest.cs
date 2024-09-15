using Library;
using NUnit.Framework;

namespace Library.Tests;

[TestFixture]
[TestOf(typeof(LibroDeHechizos))]
public class LibroDeHechizosTest
{

    [Test]
    public void TestHechizo()
    {
        Hechizo hechizo = new Hechizo("Revivir", 200, 0);
        LibroDeHechizos libro = new LibroDeHechizos(hechizo);
        Assert.That(libro.Hechizo,Is.EqualTo(hechizo));
    }
}