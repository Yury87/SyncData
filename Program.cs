﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncData
{
    class Program
    {
        static void Main(string[] args)
        {
            IAData ia = new IAData();
            ia.GetData();
        }


    }
}