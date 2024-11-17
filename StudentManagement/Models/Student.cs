using System;
using System.Collections.Generic;

namespace StudentManagement.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string FullName { get; set; } = null!;

    public DateOnly DateOfBirth { get; set; }

    public bool Gender { get; set; }

    public string Email { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public int ClassId { get; set; }

    public virtual Class Class { get; set; } = null!;
}
