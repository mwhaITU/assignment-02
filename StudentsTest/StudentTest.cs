namespace Assignment2.Tests;
using Assignment2;
using System;



public class StudentTest{
[Fact]
public void testToString(){
    //arrange
    //var student1 = new Student(1,"john", "doe", status.Active, DateTime.Now, DateTime.Now, DateTime.Now);
    var student1 = new Student{
        id = 1, 
        givenname = "john", 
        surname = "doe",  
        startdate = new DateTime(2000, 01, 01), 
        enddate = new DateTime(2020, 01, 01), 
        graduationdate = new DateTime(2020, 02, 01)
        };
    

    

    
    //act
    var output = student1.ToString();

    //assert
    Assert.Equal("studentid: 1 full name: john doe, status: Graduated start/enddate: 01-01-2000 00:00:00 to 01-01-2020 00:00:00", output);

}

}

