using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IContaBancariaService : IDisposable
    {
        Task Adicionar(ContaBancaria conta);
        Task Atualizar(ContaBancaria conta);
        Task Remover(Guid id);
    }
}
