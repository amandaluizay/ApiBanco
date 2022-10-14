using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IContaBancariaRepository: IDisposable 
    {
        Task Adicionar(ContaBancaria conta);
        Task<ContaBancaria> ObterPorId(Guid id);
        Task<List<ContaBancaria>> ObterTodos();
        Task Atualizar(ContaBancaria conta);
        Task Remover(Guid id);
        Task<IEnumerable<ContaBancaria>> Buscar(Expression<Func<ContaBancaria, bool>> predicate);
        Task<int> SaveChanges();
    }
}
