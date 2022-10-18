using System;
using Business.Models;
namespace Business.Interfaces
{
    public interface IContaJuridicaService : IDisposable
    {

        Task Adicionar(ContaJuridica conta);
        Task Atualizar(ContaJuridica conta);
        Task Remover(Guid id);
    }
}

