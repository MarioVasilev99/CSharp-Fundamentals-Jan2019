﻿namespace Google_P12
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Car
    {
        public Car(string model, int speed)
        {
            this.Model = model;
            this.Speed = speed;
        }

        public string Model { get; set; }

        public int Speed { get; set; }
    }
}