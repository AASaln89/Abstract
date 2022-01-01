using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Dag:Animal
    {
        string name;
        public override string Name
        {
            get => name;
            set => name = value;
        }
        public Dag(string name)
            : base(name)
        {
        }
        public override void Say()
        {
            Console.WriteLine("ГАВ");
        }
    }
}
