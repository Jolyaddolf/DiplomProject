using System;
using System.Collections.Generic;

namespace diplom2.Models;

public partial class Room
{
    public int Id { get; set; }

    public string Roomnumber { get; set; } = null!;

    public string Status { get; set; } = null!;

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
