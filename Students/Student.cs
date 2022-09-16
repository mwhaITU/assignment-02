namespace Assignment2;

public class Student{

    int id {get; set;}
    string givenname {get; set;}
    string surname {get; set;}
    status status {get; set;}  
    DateTime startdate {get; set;}
    DateTime enddate {get; set;}
    DateTime graduationdate {get; set;}

    public override string ToString(){
    return $"studentid: {id} full name: {givenname} {surname}, status: {status} start/enddate: {startdate}-{enddate}";
}

}




public enum status{
    New, Active, Dropout, Graduated
}