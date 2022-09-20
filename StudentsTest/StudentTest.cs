namespace Assignment2.Tests;
using Assignment2;
using System;



public class StudentTest{
[Fact]
public void testTooString(){
    //arrange
    //var student1 = new Student(1,"john", "doe", status.Active, DateTime.Now, DateTime.Now, DateTime.Now);
    var student1 = new Student{
        id = 1, 
        givenname = "john", 
        surname = "doe", 
        status = status.Active, 
        startdate = new DateTime(01/01/2000), 
        enddate = new DateTime(01/01/2020), 
        graduationdate = DateTime.Now
        };
    

    

    
    //act
    var output = student1.ToString();

    //assert
    Assert.Equal("studentid: 1 full name: john doe, status: Active start/enddate: 01-01-0001 00:00:00 to 01-01-0001 00:00:00", output);

}

}

