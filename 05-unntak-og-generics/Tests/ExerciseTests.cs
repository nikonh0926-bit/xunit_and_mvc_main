using Xunit;
using SpaceAcademy;

namespace SpaceAcademy.Tests;

public class ExerciseTests
{
    [Fact]
    public void Pop_EmptyStack_ThrowsInvalidOperationException()
    {
        var stack = new CargoStack<string>();
        Assert.Throws<InvalidOperationException>(() => stack.Pop());
        Assert.Equal(0, stack.Count);
    }
   
    [Fact]
    public void Test_Stack()
    {
        var stack = new CargoStack<string>();

        stack.Push("A");
        stack.Push("B");

        Assert.Equal(2, stack.Count);

        string b = stack.Pop();

        Assert.Equal("B", b);
        Assert.Equal(1, stack.Count);

        string a = stack.Pop();

        
        Assert.Equal("A", a);
        Assert.Equal(0, stack.Count);

        Assert.Throws<InvalidOperationException>(() => stack.Pop());
    }

    [Fact]
    public void Test_StackInt()
    {
        var stack = new CargoStack<int>();

        stack.Push(7);
        int seven = stack.Pop();

        Assert.Equal(7, seven);
        Assert.Equal(0, stack.Count);
    }

    [Fact]
    public void Test_ReuseStack()
    {
        var stack = new CargoStack<string>();

        stack.Push("A");
        string a = stack.Pop();

        Assert.Equal("A", a);
        Assert.Equal(0, stack.Count);

        stack.Push("C");
        string c = stack.Pop();

        Assert.Equal("C", c);
        Assert.Equal(0, stack.Count);
    }
}
