using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_4
{
    internal class Man
    {
        public string Name { get; }
        public event EventHandler Event1;
        public event EventHandler Event2;

        public Man(string name)
        {
            Name = name;
        }
    }
}
