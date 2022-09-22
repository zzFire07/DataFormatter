namespace Library.Tests;
using TestDateFormat;

public class DataFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        string expected = "2020-01-01";
        string actual = DateFormatter.ChangeFormat("01/01/2020");
        Assert.That(actual, Is.EqualTo(expected));
    }
    [Test]
    public void Test2()
    {
        try
        {
        string expected = "2020-01-01";
        string actual = DateFormatter.ChangeFormat("");
        Assert.That(actual, Is.EqualTo(expected));
        }
        catch (ArgumentException)
        {
            Assert.Pass();
        }
    }
    [Test]
    public void Test3()
    {
        string expected = "2020-01-01";
        string actual = DateFormatter.ChangeFormat("2020 01 01");
        Assert.That(actual, Is.EqualTo(expected));
    }
}