﻿namespace Google_P12
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Pokemon
    {
        public Pokemon(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        public string Name { get; set; }

        public string Type { get; set; }
    }
}
