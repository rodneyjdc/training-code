﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ContactLib
{
    public class Manager: Employee// inheritance
    {
        public Manager(float bsal, float hra, float bonus, float medical, int id):base(bsal,hra,bonus,medical,id)
        {
            Console.WriteLine("Parametrized constructor of Manager class" );
        }

    }
}
