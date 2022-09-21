namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void Rowling_Query_Returns_Rowling_Wizards()
    {
        // Arrange
        var wizards = WizardCollection.Create();
        


        // Act
        var actual = from wizard in wizards
                    where wizard.Creator == "J.K. Rowling"
                    select wizard.Name;
        var expected = new List<string>() { "Bellatrix Lestrange", "Harry Potter", "Sirius Black", "Voldemort", "Mads Depp", "Ablus Dumledoor" };

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Darth_Returns_Correct_Year_Output() {
        // Arrange
        var wizards = WizardCollection.Create();

        // Act
        var actual = from wizard in wizards
                    where wizard.Name.Contains("Darth")
                    select wizard.Year;
        var expected = new List<int?>() { 1977 };

        // Assert
        Assert.Equal<int?>(expected, actual);
    }

    [Fact]
    public void Potters_Returns_All_Wizards_From_Harry_Potter() {
        // Arrange
        var wizards = WizardCollection.Create();

        // Act
        var actual = from wizard in wizards
                    where wizard.Medium == "Harry Potter"
                    select (wizard.Name,wizard.Year);
        var expected = new List<(string, int?)>() { ("Bellatrix Lestrange", 1990), ("Harry Potter", 2030), ("Sirius Black", 1999), ("Voldemort", 1998), ("Ablus Dumledoor", 1460) };

        // Assert
        Assert.Equal<(string, int?)>(expected, actual);
    }
}
