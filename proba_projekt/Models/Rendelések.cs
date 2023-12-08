using System;
using System.Collections.Generic;

namespace proba_projekt.Models;

public partial class Rendelések
{
    public string RendId { get; set; } = null!;

    public DateTime Időpont { get; set; }

    public string TermékFk { get; set; } = null!;

    public int Mennyiség { get; set; }

    public string VevőFk { get; set; } = null!;

    public virtual Termékek TermékFkNavigation { get; set; } = null!;

    public virtual Vevők VevőFkNavigation { get; set; } = null!;
}
