﻿using AutoMapper;
using Banco.ApiCore.Controllers;
using Banco.ApiCore.ViewModel;
using Business.Interfaces;
using Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace Banco.ApiCore.V1.Controllers
{
    //[Authorize]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/contafisica")]

    public class ContaFisicaController : HomeController
    {
        private readonly IContaFisicaRepository _contaFisicaRepository;
        private readonly IContaFisicaService _contaFisicaService;
        private readonly IMapper _mapper;

        public ContaFisicaController(IContaFisicaRepository contabancariaRepository,
                                       IContaFisicaService contabancariaService,
                                       INotificador notificador,
                                       IMapper mapper, IUser user) : base(notificador, user)
        {
            _contaFisicaRepository = contabancariaRepository;
            _contaFisicaService = contabancariaService;
            _mapper = mapper;
        }

        //[Authorize]
        [HttpGet]

        public async Task<IEnumerable<ContaFisicaViewModel>> ObterTodos()
        {

            var conta = _mapper.Map<IEnumerable<ContaFisicaViewModel>>(await _contaFisicaRepository.ObterTodos());

            return conta;
        }

        //[Authorize]
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ContaFisicaViewModel>> ObterPorId(Guid id)
        {
            var Conta = _mapper.Map<ContaFisicaViewModel>(await _contaFisicaRepository.ObterPorId(id));

            if (Conta == null) return NotFound();

            return Conta;
        }

        //[Authorize]
        [HttpPost]
        public async Task<ActionResult<ContaFisicaViewModel>> Adicionar(ContaFisicaViewModel ContaModel)
        {
            if (!ModelState.IsValid) return CostumResponse(ModelState);

            await _contaFisicaService.Adicionar(_mapper.Map<ContaFisica>(ContaModel));


            return CostumResponse(ContaModel);
        }

        //[Authorize]
        [HttpPut("{id:guid}")]
        public async Task<ActionResult<ContaFisicaViewModel>> Atualizar(Guid id, ContaFisicaViewModel ContaModel)
        {
            if (id != ContaModel.Id)
            {
                NotificarErro("O id informado não é o mesmo que foi passado na query");
                return CostumResponse(ContaModel);
            }

            if (!ModelState.IsValid) return CostumResponse(ModelState);

            await _contaFisicaService.Atualizar(_mapper.Map<ContaFisica>(ContaModel));

            return CostumResponse(ContaModel);
        }

       // [Authorize]
        [HttpDelete("{id:guid}")]
        public async Task<ActionResult<ContaFisicaViewModel>> Excluir(Guid id)
        {
            var ContaModel = await _contaFisicaRepository.ObterPorId(id);

            if (ContaModel == null) return NotFound();

            await _contaFisicaRepository.Remover(id);

            return CostumResponse(ContaModel);
        }

    }
}
