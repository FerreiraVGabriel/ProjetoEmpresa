using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEmpresaStandBy2.Repositories
{
    public class BaseRepository
    {
        public ApplicationContext ctx = new ApplicationContext();

        public ApplicationContext Contexto => ctx;

    }
}
