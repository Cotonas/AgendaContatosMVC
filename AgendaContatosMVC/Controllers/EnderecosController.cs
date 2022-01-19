using AgendaContatosMVC.Models;
using AgendaContatosMVC.Models.ViewModel;
using AgendaContatosMVC.Services;
using AgendaContatosMVC.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaContatosMVC.Controllers
{
    public class EnderecosController : Controller
    {
        private readonly EnderecoService _enderecoService;
        private readonly ContactService _contactService;

        public EnderecosController(EnderecoService enderecoService, ContactService contactService)
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
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }
            var obj = _enderecoService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
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

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }
            var obj = _enderecoService.FindById(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            return View(obj);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }
            
            var obj = _enderecoService.FindById(id.Value);
            
            if(obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }
            List<Contact> contacts = _contactService.FindAll();
            ContactFormViewModel viewModel = new ContactFormViewModel { Endereco = obj, Contacts = contacts };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Endereco endereco)
        {
            if(id != endereco.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id mismatch" });
            }
            try
            {
                _enderecoService.Update(endereco);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}
