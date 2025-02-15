﻿using System;
using System.Collections.Generic;

namespace Orocom.DbLib.Class;

public partial class PasswordResetToken
{
    public string Email { get; set; } = null!;

    public string Token { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }
}
