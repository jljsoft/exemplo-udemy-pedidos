using EstadosPedidos.Entities.Enum;
namespace EstadosPedidos.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }


        public override string ToString()
        {
            return "ID PEDIDO: "
                + Id
                + ", DATA DO PEDIDO: "
                + Moment
                + ", STATUS DO PEDIDO: "
                + Status;

        }
    }
}