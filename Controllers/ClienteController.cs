using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProjetoAcademia.Database;
using ProjetoAcademia.Models;

namespace ProjetoAcademia.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ApplicationDBContext database;

        public ClienteController(ApplicationDBContext database){
            this.database = database;
        }

        public IActionResult Index(){
            var clientes = database.Clientes.ToList();
            return View(clientes);
        }

        public IActionResult Cadastrar(){
            return View();
        }

        [HttpPost]
        public IActionResult Salvar(Cliente cliente){
            if (cliente.Id == 0){
                database.Clientes.Add(cliente);
            } else {
                Cliente clienteExistente = database.Clientes.First(registro => registro.Id == cliente.Id);      
                clienteExistente.Nome = cliente.Nome;
                clienteExistente.Plano = cliente.Plano;          
            }
            database.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id){
            Cliente cliente = database.Clientes.First(registro => registro.Id == id);
            return View("Cadastrar", cliente);
        }

        public IActionResult Deletar(int id){
            Cliente cliente = database.Clientes.First(registro => registro.Id == id);
            database.Clientes.Remove(cliente);
            database.SaveChanges();
            return View("Index");
        }
    }
}