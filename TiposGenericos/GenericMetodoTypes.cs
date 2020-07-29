using System;
using System.Collections.Generic;
using TiposGenericos.Entidades;

namespace TiposGenericos
{
    public static class GenericMetodoTypes
    {
        public static T GeraId<T>(T data) where T : EntityBase
        {
            data.Id = Guid.NewGuid();
            return data;
        }

        public static List<string> GetcamposData<T>(T data)
        {
            var output = new List<string>();

            foreach (var item in data.GetType().GetProperties())
            {
                if (item.PropertyType == typeof(DateTime))
                {
                    output.Add(item.Name);
                }
            }
            return output;
        }
    }
}
