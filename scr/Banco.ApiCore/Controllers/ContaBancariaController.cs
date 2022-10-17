using AutoMapper;
using Banco.ApiCore.ViewModel;
using Business.Interfaces;
using Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace Banco.ApiCore.Controllers
{
    [Route("v1/contaFisica/api")]
    public class ContaBancariaController : HomeController
    {
        private readonly IContaBancariaRepository _contabancariaRepository;
        private readonly IContaBancariaService _contabancariaService;
        private readonly IMapper _mapper;

        public ContaBancariaController(IContaBancariaRepository contabancariaRepository,
                                       IContaBancariaService contabancariaService,
                                       INotificador notificador,
                                       IMapper mapper) : base(notificador)
        {
            _contabancariaRepository = contabancariaRepository;
            _contabancariaService = contabancariaService;
            _mapper = mapper;
        }
        [HttpGet]

        public async Task<IEnumerable<ContaBancariaViewModel>> ObterTodos()
        {

            var fornecedor = _mapper.Map<IEnumerable<ContaBancariaViewModel>>(await _contabancariaRepository.ObterTodos());

            return fornecedor;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ContaBancariaViewModel>> ObterPorId(Guid id)
        {
            var Conta = _mapper.Map<ContaBancariaViewModel>(await _contabancariaRepository.ObterPorId(id));

            if (Conta == null) return NotFound();

            return Conta;
        }
        [HttpPost]
        public async Task<ActionResult<ContaBancariaViewModel>> Adicionar(ContaBancariaViewModel ContaModel)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _contabancariaService.Adicionar(_mapper.Map<ContaBancaria>(ContaModel));

            return CustomResponse(ContaModel);
        }


        [HttpPut("{id:guid}")]
        public async Task<ActionResult<ContaBancariaViewModel>> Atualizar(Guid id, ContaBancariaViewModel ContaModel)
        {
            if (id != ContaModel.Id)
            {
                NotificarErro("O id informado não é o mesmo que foi passado na query");
                return CustomResponse(ContaModel);
            }

            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _contabancariaService.Atualizar(_mapper.Map<ContaBancaria>(ContaModel));

            return CustomResponse(ContaModel);
        }

        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<ContaBancariaViewModel>> Excluir(Guid id)
        {
            var ContaModel = await ObterPorId(id);

            if (ContaModel == null) return NotFound();

            await _contabancariaService.Remover(id);

            return CustomResponse(ContaModel);
        }





    }
}
