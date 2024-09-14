using Library;
using NUnit.Framework;

namespace Library.Tests;

[TestFixture]
public class ElfoTest
{
    
    [Test]
    public void TestVidaBeforeAtaqueElfo()
    {
        Elfo legolas = new Elfo("Legolas");
        int vidaActual = legolas.GetVidaActual();
        Elfo atacante = new Elfo("Eric");
        atacante.AtacarElfo(legolas);
        int vidaBeforeAtaque = legolas.GetVidaActual();
        Assert.That(vidaBeforeAtaque, Is.EqualTo(110) );
    }
}