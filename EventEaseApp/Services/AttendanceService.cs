using System.Collections.Generic;

public class AttendanceService
{
    private readonly List<Attendance> _attendances = new();

    public void AddAttendance(Attendance attendance)
    {
        _attendances.Add(attendance);
    }

    public IEnumerable<Attendance> GetAttendances()
    {
        return _attendances;
    }
}
