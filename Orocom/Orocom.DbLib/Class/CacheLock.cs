﻿using System;
using System.Collections.Generic;

namespace Orocom.DbLib.Class;

public partial class CacheLock
{
    public string Key { get; set; } = null!;

    public string Owner { get; set; } = null!;

    public int Expiration { get; set; }
}
