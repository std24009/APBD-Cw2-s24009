namespace APBD_Cw2_s24009.Models;

public class Employee(string fName, string lName) : User(fName, lName)
{
    public override int GetMaxReservations() => 5;
}