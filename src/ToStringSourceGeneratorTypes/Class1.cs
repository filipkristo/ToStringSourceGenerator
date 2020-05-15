﻿using System;
using ToStringSourceGenerator.Attributes;

namespace ToStringSourceGeneratorTypes
{
    
    [AutoToString]
    public partial class DemoTypeWithAutoToString
    {
        public int Id { get; set; }
        public string Text { get; set; }

        [SkipToString]
        public string Password { get; set; }
    }

    [AutoToString]
    public partial class DemoTypeWithInvalidAutoToString
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }

    public class DemoTypeWithOutAutoToString
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }

    [AutoToString]
    public partial class DemoTypeWithAutoToStringAndToString
    {
        public int Id { get; set; }
        public string Text { get; set; }

        //public override string ToString()
        //{
        //    return "Pepe";
        //}
    }

    [AutoToString]
    public partial class DemoTypeWithNoProperties
    {
    }
}




