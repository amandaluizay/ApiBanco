using Business.Interfaces;
using Business.Models;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ContaBancariaRepository : Repository<ContaBancaria>, IContaBancariaRepository
    {
        public ContaBancariaRepository(MeuDbContext context) : base(context)
        {

        }
    }
}
