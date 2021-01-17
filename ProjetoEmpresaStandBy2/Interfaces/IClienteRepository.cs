using ProjetoEmpresaStandBy2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEmpresaStandBy2.Interfaces
{
    public interface IClienteRepository
    {
        IList<Cliente> GetClientes();
        Cliente GetClienteId(int id);
        List<Cliente> ProcurarClientes(string razao_social, string CNPJ, bool ativo);
        bool AtualizaCliente(int ClienteId, Cliente cliente);
        bool CriarCliente(Cliente cliente);
        bool RemoverCliente(int ClienteId);
    }
}
