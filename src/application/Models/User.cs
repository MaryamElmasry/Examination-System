using System;
using System.Collections.Generic;

namespace application.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; }

    public string Email { get; set; }

    public string Address { get; set; }

    public string Password { get; set; }

    public string Phone { get; set; }

    public string Gender { get; set; }

    public virtual Instructor Instructor { get; set; }

    public virtual Student Student { get; set; }
}
