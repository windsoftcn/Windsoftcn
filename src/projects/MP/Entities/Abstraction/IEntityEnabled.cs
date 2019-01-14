using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MP.Entities
{
    public interface IEntityEnabled
    {
        bool Enabled { get; set; }
    }
}
