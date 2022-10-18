using Business.Interfaces;
using Business.Models;

namespace Business.Services
{
    public class ContaFisicaService : BaseService, IContaFisicaService
    {
        private readonly IContaFisicaRepository _contaFisicaRepository;

        public ContaFisicaService(IContaFisicaRepository contaBancariaRepository, INotificador notificador) : base(notificador)
        {
            _contaFisicaRepository = contaBancariaRepository;
        }

        public async Task Adicionar(ContaFisica conta)
        {

            await _contaFisicaRepository.Adicionar(conta);
        }

        public async Task Atualizar(ContaFisica conta)
        {

            await _contaFisicaRepository.Atualizar(conta);
        }

        public async Task Remover(Guid id)
        {

            await _contaFisicaRepository.Remover(id);
        }

        public void Dispose()
        {
            _contaFisicaRepository.Dispose();
        }
    }
}
