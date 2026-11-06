using Xunit;
using SpaceAcademy;
using Xunit.Sdk;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Fact]
    public void Constructor_StartsEmpty()
    {
        var bay = new CargoBay();
        Assert.Equal(0, bay.Count);
    }
    [Fact]
    public void AddToCargoBay()
    {
        var bay = new CargoBay();

        bay.TryAdd("mat");

        Assert.Equal(1, bay.Count);
    }
    [Fact]
    public void NewCargoBay_2Items()
    {
        var bay = new CargoBay();

        bay.TryAdd("mat");
        bay.TryAdd("vann");

        Assert.Equal(2, bay.Count);
    }
    [Fact]
    public void NewCargoBay_3Items()
    {
        var bay = new CargoBay();

        bay.TryAdd("mat");
        bay.TryAdd("vann");
        bool result = bay.TryAdd("verktøy");

        Assert.True(!result);
        Assert.Equal(2, bay.Count);
    }
    [Fact]
    public void TwoNewCargoBays()
    {
        var bay = new CargoBay();
        var bay2 = new CargoBay();

        bay.TryAdd("mat");

        Assert.Equal(1, bay.Count);
        Assert.Equal(0, bay2.Count);
    }
}
