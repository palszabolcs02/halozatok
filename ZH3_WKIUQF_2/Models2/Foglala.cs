using System;
using System.Collections.Generic;

namespace ZH3_WKIUQF_2.Models2;

public partial class Foglala
{
    public int FoglalasPk { get; set; }

    public string UgyfelFk { get; set; } = null!;

    public int SzobaFk { get; set; }

    public DateTime Mettol { get; set; }

    public DateTime Meddig { get; set; }

    public int FelnottSzam { get; set; }

    public int GyermekSzam { get; set; }

    public virtual Szoba SzobaFkNavigation { get; set; } = null!;

    public virtual Vendeg UgyfelFkNavigation { get; set; } = null!;
}
