static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        return DateTime.Parse(appointmentDateDescription);
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return DateTime.Compare(appointmentDate, DateTime.UtcNow) < 0 ? true : false;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        return (appointmentDate.Hour < 18 && appointmentDate.Hour >= 12) ? true : false;
    }

    public static string Description(DateTime appointmentDate)
    {
        // return $"You have an appointment on {appointmentDate.Date.ToString("d")} {appointmentDate.Hour}:{appointmentDate.Minute}:{appointmentDate.Second} {appointmentDate:t}";
        return $"You have an appointment on {appointmentDate.ToString()}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
    }
}
