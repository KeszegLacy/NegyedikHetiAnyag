using _8.gyak.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.gyak.Entities
{
    class BallFactory :IToyFactory
    {

        public Toy CreateNew() {
            return new Toy();
        }

        Abstractions.Toy IToyFactory.CreateNew()
        {
            return new Toy();
        }
    }
}
