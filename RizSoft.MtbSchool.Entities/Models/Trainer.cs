﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RizSoft.MtbSchool.Domain.Models;

public partial class Trainer
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Grade { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public byte[] Photo { get; set; }

    public virtual ICollection<CourseEdition> Courses { get; set; } = new List<CourseEdition>();
}