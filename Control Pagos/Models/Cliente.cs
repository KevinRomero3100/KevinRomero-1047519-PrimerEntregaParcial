using System;
using System.Collections.Generic;

namespace Control_Pagos.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public int PersonalCode { get; set; }

    public string FirstName { get; set; } = null!;

    public string SecondName { get; set; } = null!;

    public string LastName1 { get; set; } = null!;

    public string LastName2 { get; set; } = null!;

    public bool State { get; set; }

    public int Dpi { get; set; }
}
