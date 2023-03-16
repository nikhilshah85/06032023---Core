using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace empMangement_dataAnnotation.Models.EF;

public partial class Employee
{
    [System.ComponentModel.DataAnnotations.Display(Name ="Employee Number")]
    [Required(ErrorMessage = "Please provide employee Number")]
    public int EmpNo { get; set; }
    
    [Display(Name ="Name")]
    [Required(ErrorMessage ="Name cannot be left blank")]
    [StringLength(20,MinimumLength =3, ErrorMessage ="Name should be between 3 and 20 characters")]
    public string? EmpName { get; set; }

    [Display(Name ="Works As")]
    public string? EmpDesigantion { get; set; }

    [Display(Name ="Monthly Pay")]
    [Range(5000,65000,ErrorMessage ="Salary can be between 5 and 65 Thousand only")]
    public int? EmpSalary { get; set; }

    [Display(Name ="Connect")]
    [EmailAddress(ErrorMessage ="Please provide a valid email address")]
    public string? EmpEmail { get; set; }
    [Display(Name ="Status")]
    public bool? EmpIsPermenant { get; set; }
}
