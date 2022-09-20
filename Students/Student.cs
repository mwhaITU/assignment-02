namespace Assignment2;

public class Student{

    public int id {get; set;}
    public string? givenname {get; set;}
    public string? surname {get; set;}
    public status status {get; set;}  
    public DateTime startdate {get; set;}
    public DateTime enddate {get; set;}
    public DateTime graduationdate {get; set;}

    public override string ToString(){
    return $"studentid: {id} full name: {givenname} {surname}, status: {status} start/enddate: {startdate} to {enddate}";
}

}




public enum status{
    New, Active, Dropout, Graduated
}