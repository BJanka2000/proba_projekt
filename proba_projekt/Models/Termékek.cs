using System;
using System.Collections.Generic;

namespace proba_projekt.Models;

public partial class Termékek
{
    public string TermékSk { get; set; } = null!;

    public string Terméknév { get; set; } = null!;

    public int Egységár { get; set; }

    public virtual ICollection<Rendelések> Rendelések { get; set; } = new List<Rendelések>();

    public virtual ICollection<Szállítók> Szállítók { get; set; } = new List<Szállítók>();
}
