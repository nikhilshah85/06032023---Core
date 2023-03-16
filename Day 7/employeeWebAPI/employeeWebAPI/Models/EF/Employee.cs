using System;
using System.Collections.Generic;

namespace employeeWebAPI.Models.EF;

public partial class Employee
{
    public int EmpNo { get; set; }

    public string? EmpName { get; set; }

    public string? EmpDesigantion { get; set; }

    public int? EmpSalary { get; set; }

    public string? EmpEmail { get; set; }

    public bool? EmpIsPermenant { get; set; }
}
