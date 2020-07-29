using System;
using System.Collections.Generic;
using System.Text;

namespace TiposGenericos.Entidades
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }
        public DateTime MinhaData { get; set; }
    }
}
