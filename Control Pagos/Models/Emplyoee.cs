using System;
using System.Collections.Generic;

namespace Control_Pagos.Models;

public partial class Emplyoee
{
    public int Id { get; set; }

    public int PersonalCode { get; set; }

    public string UserName { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string SecondName { get; set; } = null!;

    public string LastName1 { get; set; } = null!;

    public string LastName2 { get; set; } = null!;

    public bool State { get; set; }

    public int Dpi { get; set; }

    public int Rol { get; set; }
}
