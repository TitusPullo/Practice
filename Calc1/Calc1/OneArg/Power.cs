﻿using System;

namespace Calc1.OneArg
{
    public class Power : I2Calculator 
    {
            public double Calculate(double first)
            {
                return Math.Pow(10, first);
            }
        }
    
}