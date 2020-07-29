using System;
using System.Collections.Generic;
using System.Text;
using TiposGenericos.Entidades;

namespace TiposGenericos
{
    public class GenericClassTypes<T> where T : EntityBase
    {
        public GenericClassTypes()
        {
            MinhaLista = new List<T>();
        }
        public List<T> MinhaLista { get; set; }
    }
}
