using SneakerStore.Models;
using SneakerStore.Data;
using Microsoft.EntityFrameworkCore;

namespace SneakerStore.Services
{
    public class EstoqueService
    {
        private readonly AppDbContext _context;

        public EstoqueService(AppDbContext context)
        {
            _context = context;
        }

        public List<Estoque> ListarEstoque()
        {
            return _context.Estoques.Include(e => e.Produto).ToList();
        }

        public void AtualizarQuantidade(int produtoId, int quantidadeAlterada)
        {
            var estoque = _context.Estoques.FirstOrDefault(e => e.ProdutoId == produtoId);
            if (estoque != null)
            {
                estoque.QuantidadeAtual += quantidadeAlterada;
                _context.SaveChanges();
            }
        }
    }
}
