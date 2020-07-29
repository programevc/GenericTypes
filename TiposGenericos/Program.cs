using System;
using TiposGenericos.Entidades;

namespace TiposGenericos
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista2 = new GenericClassTypes<PedidoEntity>();
            lista2.MinhaLista.Add(new PedidoEntity() { Valor = 100 });
            lista2.MinhaLista.Add(new PedidoEntity() { Valor = 322 });

            var Pedido = new PedidoEntity();
            GenericMetodoTypes.GeraId(Pedido);

            var outra = new OutraEntity();
            outra.Id = Guid.NewGuid();
            var datas = GenericMetodoTypes.GetcamposData(outra);


            Console.ReadKey();
        }
    }
}
