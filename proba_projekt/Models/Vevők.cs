using System;
using System.Collections.Generic;

namespace proba_projekt.Models;

public partial class Vevők
{
    public string VevőSk { get; set; } = null!;

    public string Név { get; set; } = null!;

    public string? Login { get; set; }

    public string Email { get; set; } = null!;

    public virtual ICollection<Rendelések> Rendelések { get; set; } = new List<Rendelések>();
}
