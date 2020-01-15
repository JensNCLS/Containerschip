using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerSchip
{
    public enum Type
    {
        Normal,
        Fragile,
        Cooled
    };
    class Container
    {
        public Type Type { get; }
        public int Height { get; set; }
        public int Length { get; set; }
        public int Weight { get; set; }
    }
}
