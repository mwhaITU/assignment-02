namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void IsSecure_Returns_Correct_Boolean()
    {
        // Arrange
        Uri uri = new Uri("https://github.com/");

        // Act
        bool result = uri.IsSecure();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void WordCount_Returns_Correct_Amount_Of_Words() 
    {
         // Arrange
        string sentence = "This is my sentence and I am fine";

        // Act
        int result = sentence.WordCount();

        // Assert
        Assert.Equal(8, result);
    }
}
