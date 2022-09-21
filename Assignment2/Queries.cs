namespace Assignment2;

public class Queries
{
    public static void main(string[] args) {
        var wizards = WizardCollection.Create();
        // 1.
        var rowling = from wizard in wizards
                    where wizard.Creator == "J.K. Rowling"
                    select wizard.Name;


        // 2.
        var darth = from wizard in wizards
                    where wizard.Name.Contains("Darth")
                    select wizard.Year;

        // 3. 
        var potters = from wizard in wizards
                    where wizard.Medium == "Harry Potter"
                    select (wizard.Name,wizard.Year);
    }

}
