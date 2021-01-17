using ProjetoEmpresaStandBy2.Interfaces;
using ProjetoEmpresaStandBy2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEmpresaStandBy2.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ApplicationContext contexto;

        public ClienteRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
        }

        public IList<Cliente> GetClientes()
        {
            return contexto.Set<Cliente>().ToList();
        }

        public Cliente GetClienteId(int id)
        {
            return contexto.Set<Cliente>().Where(x => x.ClienteId == id).FirstOrDefault();
        }

        public List<Cliente> ProcurarClientes(string razao_social, string CNPJ, bool ativo)
        {
            return contexto.Set<Cliente>().Where(x => x.razao_social.Contains(razao_social) && x.cnpj.Contains(CNPJ) && x.status_cliente == ativo).ToList();
        }

        public bool AtualizaCliente(int ClienteId,Cliente cliente)
        {
            try
            {
                var clienteNew = contexto.Cliente.Where(x => x.ClienteId == ClienteId).FirstOrDefault();
                clienteNew.capital = cliente.capital;
                clienteNew.classificacao = cliente.classificacao;
                clienteNew.cnpj = cliente.cnpj;
                clienteNew.status_cliente = cliente.status_cliente;
                clienteNew.data_fundacao = cliente.data_fundacao;
                clienteNew.quarentena = cliente.quarentena;
                clienteNew.razao_social = cliente.razao_social;

                contexto.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool CriarCliente(Cliente cliente)
        {
            try
            {

                contexto.Cliente.Add(cliente);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool RemoverCliente(int ClienteId)
        {
            try
            {
                var cliente = contexto.Cliente.Where(x => x.ClienteId == ClienteId).FirstOrDefault();
                contexto.Cliente.Remove(cliente);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
    }
}
