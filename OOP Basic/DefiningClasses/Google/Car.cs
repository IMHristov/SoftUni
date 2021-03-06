﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Car
    {
        private string model;
        private int speed;

        public Car(string model, int speed)
        {
            this.model = model;
            this.speed = speed;
        }

        public override string ToString()
        {
            return $"{this.model} {this.speed}";
        }
    }
}
