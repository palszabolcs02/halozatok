using System;
using System.Collections.Generic;

namespace ZH3_WKIUQF_2.Models2;

public partial class Szoba
{
    public int SzobaId { get; set; }

    public string SzobaSzama { get; set; } = null!;

    public int Ferohely { get; set; }

    public int? Potagy { get; set; }

    public string? Klimas { get; set; }

    public int? SzallasFk { get; set; }

    public virtual ICollection<Foglala> Foglalas { get; } = new List<Foglala>();

    public virtual Szallashely? SzallasFkNavigation { get; set; }
}
