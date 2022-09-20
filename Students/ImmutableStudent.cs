namespace Assignment2;

public record ImmutableStudent {

    public int id {get; init;}
    public string? givenname {get; init;}
    public string? surname {get; init;}
    public DateTime startdate {get; init;}
    public DateTime enddate {get; init;}
    public DateTime graduationdate {get; init;}

    public Status status {get => determineStatus(startdate, enddate, graduationdate);}  

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