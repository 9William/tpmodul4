﻿using System;

namespace tpmodul4_1302204126
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric.sapaUser("Gerry William Mathew Kurniawan");

            DataGeneric<String> data = new DataGeneric<String>("1302204126");

            data.printData();
        }
    }
}