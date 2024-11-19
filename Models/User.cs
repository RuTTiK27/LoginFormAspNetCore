using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoginFormAspNetCore.Models;

public partial class User
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = null!;
    
    [Required]
    public int? Age { get; set; }

    [Required]
    [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email")]
    public string Email { get; set; } = null!;

    [RegularExpression(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$",ErrorMessage ="Uppercase, Lowercase, Numbers, Symbols, Min 8 Chars")]
    [DataType(DataType.Password)]
    [Required]
    public string Password { get; set; } = null!;
}
