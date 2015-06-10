using System;
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

        public Ribbon(List<Char> initialRibbon)
        {
            RibbonString = initialRibbon;
        }

        public List<Char> RibbonString
        {
            get;

            set;
        }

        public int CurrentPosition
        {
            get;

            set;
        }
    }
}
