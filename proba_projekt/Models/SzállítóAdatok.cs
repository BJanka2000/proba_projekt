using System;
using System.Collections.Generic;

namespace proba_projekt.Models;

public partial class SzállítóAdatok
{
    public string SzállítóSk { get; set; } = null!;

    public string Cégnév { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Székhely { get; set; } = null!;

    public virtual ICollection<Szállítók> Szállítók { get; set; } = new List<Szállítók>();
}
