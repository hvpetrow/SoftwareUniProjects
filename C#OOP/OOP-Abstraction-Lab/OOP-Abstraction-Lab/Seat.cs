﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {

        public Seat(string model , string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get; }
        public string Color { get; }

        public string Start()
       => "Engine start";

        public string Stop()
        => "Breaaak!";

        public override string ToString()
        {
             StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} Seat {Model}");
            sb.AppendLine($"{Start()}");
            sb.Append($"{Stop()}");
            return sb.ToString();
        }
    }
}
