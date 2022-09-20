namespace Assignment2.Tests;
using Assignment2;
using System;

public class ImmutableStudentTest{
    [Fact]
    public void ToString_Gives_Correct_Output(){
        // Arrange
        ImmutableStudent immutableStudent = new ImmutableStudent{
            id = 1, 
            givenname = "jane", 
            surname = "doe",  
            startdate = new DateTime(2000, 01, 01), 
            enddate = new DateTime(2020, 01, 01), 
            graduationdate = new DateTime(2020, 02, 01)
        };

        // Act
        var output = immutableStudent.ToString();

        // Assert
        Assert.Equal("ImmutableStudent { id = 1, givenname = jane, surname = doe, startdate = 01-01-2000 00:00:00, enddate = 01-01-2020 00:00:00, graduationdate = 01-02-2020 00:00:00, status = Graduated }", output);
    }

    [Fact]
    public void Equality_Comparison_For_Records() {
        // Arrange
        ImmutableStudent jane = new ImmutableStudent{
            id = 1, 
            givenname = "jane", 
            surname = "doe",  
            startdate = new DateTime(2000, 01, 01), 
            enddate = new DateTime(2020, 01, 01), 
            graduationdate = new DateTime(2020, 02, 01)
        };
        
        ImmutableStudent jane2 = new ImmutableStudent{
            id = 1, 
            givenname = "jane", 
            surname = "doe",  
            startdate = new DateTime(2000, 01, 01), 
            enddate = new DateTime(2020, 01, 01), 
            graduationdate = new DateTime(2020, 02, 01)
        };

        // Act
        var output = jane.Equals(jane2);
    
        // Assert
        Assert.True(output);
    }

    [Fact]
    public void Equality_Comparison_For_Class() {
        // Arrange
        Student jane = new Student{
            id = 1, 
            givenname = "jane", 
            surname = "doe",  
            startdate = new DateTime(2000, 01, 01), 
            enddate = new DateTime(2020, 01, 01), 
            graduationdate = new DateTime(2020, 02, 01)
        };
        
        Student jane2 = new Student{
            id = 1, 
            givenname = "jane", 
            surname = "doe",  
            startdate = new DateTime(2000, 01, 01), 
            enddate = new DateTime(2020, 01, 01), 
            graduationdate = new DateTime(2020, 02, 01)
        };

        // Act
        var output = jane.Equals(jane2);
    
        // Assert
        Assert.False(output);
    }
}
