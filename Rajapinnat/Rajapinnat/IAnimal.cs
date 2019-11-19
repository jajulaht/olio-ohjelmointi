using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rajapinnat
{
    interface IAnimal
    {
        string Name { get; set; }
        string Talk();
    }
}
