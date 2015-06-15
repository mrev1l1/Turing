﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turing.Core
{
    public class Ribbon
    {
        public Ribbon()
        {

        }

        public Ribbon(Char[] initialRibbon)
        {
            RibbonString = initialRibbon;
        }

        public Char[] RibbonString
        {
            get;

            set;
        }

        public int CurrentPosition
        {
            get;

            set;
        }

        public override string ToString()
        {
            string s = string.Empty;

            foreach (var c in RibbonString)
            {
                s += c.ToString();

                s += " | ";
            }

            return s;
        }
    }
}
