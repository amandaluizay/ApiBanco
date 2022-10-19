﻿using Business.Interfaces;
using Business.Models;
using Business.Models.Validations;
using System.Collections.Generic;

namespace Business.Services
{
    public class ContaFisicaService : BaseService, IContaFisicaService
    {
        private readonly IContaFisicaRepository _contaFisicaRepository;

        public ContaFisicaService(IContaFisicaRepository contaBancariaRepository, INotificador notificador) : base(notificador)
        {
            _contaFisicaRepository = contaBancariaRepository;
        }

        public async Task<bool> Adicionar(ContaFisica conta)
        {
            if (_contaFisicaRepository.Buscar(c => c.CPF == conta.CPF).Result.Any())
            {
                Notificar("CPF já Existente.");
                return false;
            }

            await _contaFisicaRepository.Adicionar(conta);
            return true;

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
