using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_4
{
    internal class Barrier
    {
        public event EventHandler Event1;
        public event EventHandler Event2;

        public void TriggerRandomEvent(int randomNumber, string name)
        {
            if (randomNumber == 1)
            {
                Event1?.Invoke(this, EventArgs.Empty);
                Console.WriteLine($"\n{name} иду");
            }
            else
            {
                Event2?.Invoke(this, EventArgs.Empty);
                Console.WriteLine($"\n{name} стою");
            }
        }
    }
}
