namespace SeboPequeri.Models
{
    public class PedidoLivro
    {
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        public int LivroId { get; set; }
        public Livro Livro { get; set; }

        public int Quantidade { get; set; }
        public decimal PrecoPedido { get; set; }

        public PedidoLivro() { }

        public PedidoLivro(Pedido pedido, Livro livro, int quantidade, decimal precoPedido)
        {
            Pedido = pedido;
            Livro = livro;
            Quantidade = quantidade;
            PrecoPedido = precoPedido;
        }
    }
}
