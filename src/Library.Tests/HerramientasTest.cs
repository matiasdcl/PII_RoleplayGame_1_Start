using System;
using NUnit.Framework;

namespace Library.Tests;

[TestFixture]
[TestOf(typeof(Herramientas))]
public class HerramientasTest
{

    [Test]
    public void TestValidarNombreVacio()
    {
        Assert.Throws<ArgumentException>(() => Herramientas.ValidarNombre(""));
    }

    [Test]
    public void TestValidarNombreCaracteresNoPermitidos()
    {
       Assert.Throws<ArgumentException>(() => Herramientas.ValidarNombre("#@("));
    }

    [Test]
    public void TestValidarEstadistica()
    {
        Assert.Throws<ArgumentException>(() => Herramientas.ValidarEstadistica(-100));
    }
}