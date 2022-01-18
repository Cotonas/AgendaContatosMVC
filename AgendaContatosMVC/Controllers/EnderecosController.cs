using AgendaContatosMVC.Models;
using AgendaContatosMVC.Models.ViewModel;
using AgendaContatosMVC.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaContatosMVC.Controllers
{
    public class EnderecosController : Controller
    {
        private readonly EnderecoService _enderecoService;
        private readonly ContactService _contactService;
        
        public EnderecosController(EnderecoService enderecoService,ContactService contactService)
        {
            _enderecoService = enderecoService;
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var list = _enderecoService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var contacts = _contactService.FindAll();
            var viewModel = new ContactFormViewModel { Contacts = contacts };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Endereco endereco)
        {
            _enderecoService.Insert(endereco);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _enderecoService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _enderecoService.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
