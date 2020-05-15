﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToStringSourceGenerator.Attributes
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public sealed class SkipToStringAttribute : Attribute
    {
    }
}
