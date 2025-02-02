namespace Assignment2;

public class Student{

    public int id {get; init;}
    public string? givenname {get; set;}
    public string? surname {get; set;}
    public DateTime startdate {get; set;}
    public DateTime enddate {get; set;}
    public DateTime graduationdate {get; set;}

    public Status status {get => determineStatus(startdate, enddate, graduationdate);}  

    public override string ToString(){
    return $"studentid: {id} full name: {givenname} {surname}, status: {status} start/enddate: {startdate} to {enddate}";
}

    public Status determineStatus(DateTime start, DateTime end, DateTime graduation) {
        Status status = Status.Active;
        if(DateTime.Now > end && graduation == null) {
            status = Status.Dropout;
        }
        else if(DateTime.Now < start) {
            status = Status.New;
        }
        else if(DateTime.Now > graduation) {
            status = Status.Graduated;
        }
        return status;
    }

}




public enum Status{
    New, Active, Dropout, Graduated
}