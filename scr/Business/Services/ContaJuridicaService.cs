using Business.Interfaces;
using Business.Models;


namespace Business.Services
{
    public class ContaJuridicaService : BaseService, IContaJuridicaService
    {

        private readonly IContaJuridicaRepository _contaJuridicaRepository;
        public ContaJuridicaService(IContaJuridicaRepository contaJuridicaRepository, INotificador notificador) : base(notificador)
        {
            _contaJuridicaRepository = contaJuridicaRepository;
        }

        public async Task Adicionar(ContaJuridica conta)
        {
            await _contaJuridicaRepository.Adicionar(conta);
        }

        public async Task Atualizar(ContaJuridica conta)
        {
            await _contaJuridicaRepository.Atualizar(conta);
        }

        public void Dispose()
        {
            _contaJuridicaRepository?.Dispose();
        }

        public async Task Remover(Guid id)
        {
            await _contaJuridicaRepository.Remover(id);
        }
    }
}

