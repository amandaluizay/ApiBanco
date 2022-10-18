using Business.Models;

namespace Business.Interfaces
{
    public interface IContaBancariaService : IDisposable
    {
        Task Adicionar(ContaBancaria conta);
        Task Atualizar(ContaBancaria conta);
        Task Remover(Guid id);
    }
}
