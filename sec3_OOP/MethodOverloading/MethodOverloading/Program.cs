// See https://aka.ms/new-console-template for more information
Console.WriteLine("MEthod Overloading\n");

MedicalAppointment medicalAppointment = new MedicalAppointment(
    "John Smith", new DateTime(2023, 12, 5)
    );

medicalAppointment.Reschedule(new DateTime(2023, 11, 2));
class MedicalAppointmentPrinter
{
    public void Print(MedicalAppointment medicalAppointment)
    {
        Console.WriteLine("Appointment will take place on " + medicalAppointment.GetDate());
    }
}

public class MedicalAppointment
{
    #region fields

    #endregion
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        this._patientName = patientName;
        this._date = date; // ***
    }

    // Methods 
    public void Reschedule(DateTime date)
    {
        _date = date;
        MedicalAppointmentPrinter printer = new MedicalAppointmentPrinter();
        printer.Print(this);
    }
    public void OverwriteMonthAndDay(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }
    public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
    {
        _date = new DateTime(
            _date.Year,
            _date.Month + monthsToAdd,
            _date.Day + daysToAdd
            );
    }

    public DateTime GetDate() => this._date;

}
