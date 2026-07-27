public class GreetingTests
{
    [Fact]
    public void CreateMessage_returns_hello_world()
    {
        Assert.Equal("Hello, World!", Greeting.CreateMessage());
    }
}
