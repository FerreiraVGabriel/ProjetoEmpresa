using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoEmpresaStandBy2.Interfaces;
using ProjetoEmpresaStandBy2.Models;

namespace ProjetoEmpresaStandBy2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClienteRepository clienteRepository;
        public HomeController( IClienteRepository clienteRepository)
        {
            this.clienteRepository = clienteRepository;
        }
        public IActionResult Index()
        {
            var lista = clienteRepository.GetClientes();
            ViewBag.razaoSocial = "";
            ViewBag.cnpj = "";
            ViewBag.status = 1;
            return View(lista);
        }

        [HttpPost]
        public IActionResult Index(string razaoSocial, string cnpj, int status)
        {
            bool statusBool = true;
            if (status == 0)
                statusBool = false;

            var lista = clienteRepository.ProcurarClientes(razaoSocial,cnpj, statusBool);
            ViewBag.razaoSocial = razaoSocial;
            ViewBag.cnpj = cnpj;
            ViewBag.status = status;
            return View(lista);
        }

        public ActionResult Create()
        {
            Cliente cliente = new Cliente();
            cliente.classificacao = "B";
            cliente.data_fundacao = DateTime.Now.Date;
            cliente.status_cliente = true;
            return View(cliente);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cliente cliente)
        {
            var lista = clienteRepository.GetClientes().Where(x => x.razao_social.ToLower() == cliente.razao_social.ToLower());
            if (lista.Count() > 0)
            {
                TempData["error"] = "Razão Social já existe na tabela, favor inserir outro nome.";
                return View();
            }
             var lista2 = clienteRepository.GetClientes().Where(x => x.cnpj == cliente.cnpj);
            if (lista2.Count() > 0)
            {
                TempData["error"] = "CNPJ já existe na tabela, favor inserir outro CNPJ.";
                return View();
            }

            if (ModelState.IsValid)
            {
                TimeSpan date = DateTime.Now.Date - cliente.data_fundacao;
                int totalDias = date.Days;
                if (totalDias > 365)
                    cliente.quarentena = false;
                else
                    cliente.quarentena = true;
                if (Convert.ToDouble(cliente.capital) <= 10000.00)
                    cliente.classificacao = "C";
                else if (Convert.ToDouble(cliente.capital) > 10000.00 && Convert.ToDouble(cliente.capital) <= 1000000.00)
                    cliente.classificacao = "B";
                else if (Convert.ToDouble(cliente.capital) > 1000000.00)
                    cliente.classificacao = "A";
                var ret = clienteRepository.CriarCliente(cliente);
                if (ret == true)
                    TempData["success"] = "Cliente Adicionado com Sucesso.";
                else
                    TempData["error"] = "Falha Adicionar o Cliente.";

                return RedirectToAction("Index");
            }
            TempData["error"] = "Falha ao apagar o item selecionado. Verifique todas as referências antes de excluir.";

            return View();
        }

        public ActionResult Edit(int ClienteId)
        {
            var cliente = clienteRepository.GetClienteId(ClienteId);
            return View(cliente);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int ClienteId, Cliente cliente)
        {
            var lista = clienteRepository.GetClientes().Where(x => x.razao_social.ToLower() == cliente.razao_social.ToLower());
            if (lista.Count() > 0)
            {
                if(lista.First().ClienteId != ClienteId)
                {
                    TempData["error"] = "Razão Social já existe na tabela, favor inserir outro nome.";
                    return View();
                }

            }
            var lista2 = clienteRepository.GetClientes().Where(x => x.cnpj == cliente.cnpj);
            if (lista2.Count() > 0)
            {
                if (lista2.First().ClienteId != ClienteId)
                {
                    TempData["error"] = "CNPJ já existe na tabela, favor inserir outro CNPJ.";
                    return View();
                }
            }
            if (ModelState.IsValid)
            {
                TimeSpan date = DateTime.Now.Date - cliente.data_fundacao;
                int totalDias = date.Days;
                if (totalDias > 365)
                    cliente.quarentena = false;
                else
                    cliente.quarentena = true;

                if (Convert.ToDouble(cliente.capital) <= 10000.00)
                    cliente.classificacao = "C";
                else if (Convert.ToDouble(cliente.capital) > 10000.00 && Convert.ToDouble(cliente.capital) <= 1000000.00)
                    cliente.classificacao = "B";
                else if (Convert.ToDouble(cliente.capital) > 1000000.00)
                    cliente.classificacao = "A";
                var ret = clienteRepository.AtualizaCliente(ClienteId,cliente);

                if (ret == true)
                    TempData["success"] = "Cliente Editado com Sucesso.";
                else
                    TempData["error"] = "Falha ao Editar o Cliente.";

                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int idClienteDelete)
        {
            var ret = clienteRepository.RemoverCliente(idClienteDelete);
            if (ret == true)
                TempData["success"] = "Cliente Excluido com Sucesso.";
            else
                TempData["error"] = "Falha ao Excluir o Cliente.";

            return RedirectToAction("Index");
        }

        public ActionResult Limpar()
        {
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
