using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Szállítók
{
    public string SzállításId { get; set; } = null!;

    public string? SzállítóFk { get; set; }

    public string TermékFk { get; set; } = null!;

    public int MennyiségSzállító { get; set; }

    public DateTime MegrendelésIdőpontja { get; set; }

    public DateTime? TeljesítésIdőpontja { get; set; }

    public int EgységárSzállító { get; set; }

    public virtual SzállítóAdatok? SzállítóFkNavigation { get; set; }

    public virtual Termékek TermékFkNavigation { get; set; } = null!;
}
