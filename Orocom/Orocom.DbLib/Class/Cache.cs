﻿using System;
using System.Collections.Generic;

namespace Orocom.DbLib.Class;

public partial class Cache
{
    public string Key { get; set; } = null!;

    public string Value { get; set; } = null!;

    public int Expiration { get; set; }
}
