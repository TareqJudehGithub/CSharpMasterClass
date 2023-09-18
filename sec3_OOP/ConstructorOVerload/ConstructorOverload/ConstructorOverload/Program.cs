// See https://aka.ms/new-console-template for more information

Console.WriteLine("Constructor Overload\n");

class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    // Constructors
    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    // Constructor Overdrive
    public MedicalAppointment(string patientNAme) : this(patientNAme, 7)
    {
    }
    public MedicalAppointment(string patientName, int daysFromNow)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }





    // Methods 
    public void Reschedule(DateTime @date)
    {
        _date = date;
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
}


