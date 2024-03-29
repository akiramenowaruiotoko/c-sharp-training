﻿using System.Drawing;
using PolymorphismSamples.Properties;

namespace PolymorphismSamples
{
    internal class Cat : Animal // inherit from animal class
    {
        public string Ear { get; set; } = "round"; // Ear shape
        public override Image Sing()
        {
            return Resources.CatCookieSing;
        }

        public override Image Reset()
        {
            return Resources.CatCookie;
        }
    }
}
