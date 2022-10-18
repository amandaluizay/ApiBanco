using Business.Interfaces;
using Business.Models;

namespace Business.Services
{
    public class ContaBancariaService : BaseService, IContaBancariaService
    {
        private readonly IContaBancariaRepository _contaBancariaRepository;

        public ContaBancariaService(IContaBancariaRepository contaBancariaRepository, INotificador notificador) : base(notificador)
        {
            _contaBancariaRepository = contaBancariaRepository;
        }

        public async Task Adicionar(ContaBancaria conta)
        {
            //if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _contaBancariaRepository.Adicionar(conta);
        }

        public async Task Atualizar(ContaBancaria conta)
        {
            //if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _contaBancariaRepository.Atualizar(conta);
        }

        public async Task Remover(Guid id)
        {

            await _contaBancariaRepository.Remover(id);
        }

        public void Dispose()
        {
            _contaBancariaRepository?.Dispose();
        }
    }
}
