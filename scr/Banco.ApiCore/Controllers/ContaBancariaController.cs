using AutoMapper;
using Banco.ApiCore.ViewModel;
using Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Banco.ApiCore.Controllers
{
    [Route("ContaBancaria/api")]
    public class ContaBancariaController : HomeController
    {
        private readonly IContaBancariaRepository _contabancariaRepository;
        private readonly IContaBancariaService _contabancariaService;
        private readonly IMapper _mapper;

        public ContaBancariaController(IContaBancariaRepository contabancariaRepository, 
            IContaBancariaService contabancariaService, 
            IMapper mapper)
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
    }
}
