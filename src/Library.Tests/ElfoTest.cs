using System.Linq;
using Library;
using NUnit.Framework;

namespace Library.Tests;

[TestFixture]
public class ElfoTest
{
    
    [Test]
    public void TestVidaDespuesDeAtaqueElfo()
    {
        Elfo legolas = new Elfo("Legolas");
        Elfo atacante = new Elfo("Eric");
        atacante.AtacarElfo(legolas);
        Assert.That(legolas.GetVidaActual(), Is.EqualTo(110) );
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