using System;
using System.Collections.Generic;

namespace diplom2.Models;

public partial class Booking
{
    public int Id { get; set; }

    public int Clientid { get; set; }

    public int Roomid { get; set; }

    public DateTime Startdate { get; set; }

    public DateTime Enddate { get; set; }

    public string Status { get; set; } = null!;

    public virtual Client Client { get; set; } = null!;

    public virtual Room Room { get; set; } = null!;
}
