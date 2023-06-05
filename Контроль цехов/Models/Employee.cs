using System;
using System.Collections.Generic;

namespace УППО_Пропуски.Models;

public partial class Employee
{
    public int Code { get; set; }

    public string Surname { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Patronomic { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public DateOnly Birthdate { get; set; }

    public string? Photo { get; set; }

    public string? Password { get; set; }

    public int Workshop { get; set; }

    public int? Subdivision { get; set; }

    public string? Status { get; set; }

    public sbyte IsVerificated { get; set; }

    public sbyte CanVisitOtherWorkshops { get; set; }

    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();

    public virtual Division? SubdivisionNavigation { get; set; }

    public virtual Workshop WorkshopNavigation { get; set; } = null!;

    public Employee()
    {
    }

    public Employee(int code, string surname, string name, string patronomic, string gender, DateOnly birthdate, string? photo, string? password, int workshop, int? subdivision, string? status, sbyte isVerificated, sbyte canVisitOtherWorkshops, ICollection<Log> logs, Division? subdivisionNavigation, Workshop workshopNavigation)
    {
        Code = code;
        Surname = surname;
        Name = name;
        Patronomic = patronomic;
        Gender = gender;
        Birthdate = birthdate;
        Photo = photo;
        Password = password;
        Workshop = workshop;
        Subdivision = subdivision;
        Status = status;
        IsVerificated = isVerificated;
        CanVisitOtherWorkshops = canVisitOtherWorkshops;
        Logs = logs;
        SubdivisionNavigation = subdivisionNavigation;
        WorkshopNavigation = workshopNavigation;
    }
}
