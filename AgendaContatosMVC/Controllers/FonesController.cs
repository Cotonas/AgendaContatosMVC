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
    public class FonesController : Controller
    {
        private readonly FoneService _foneService;
        private readonly ContactService _contactService;

        public FonesController(FoneService foneService, ContactService contactService)
        {
            _foneService = foneService;
            _contactService = contactService;
        }
        public IActionResult Index()
        {
            var list = _foneService.FindAll();
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
        public IActionResult Create(Fone fone)
        {
            _foneService.Insert(fone);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }
            var obj = _foneService.FindById(id.Value);
            if(obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _foneService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not provided" });
            }
            var obj = _foneService.FindById(id.Value);
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

            var obj = _foneService.FindById(id.Value);

            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id not found" });
            }

            List<Contact> contacts = _contactService.FindAll();
            ContactFormViewModel viewModel = new ContactFormViewModel { Fone = obj, Contacts = contacts };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Fone fone)
        {
            if (id != fone.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id mismatch" });
            }
            try
            {
                _foneService.Update(fone);
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
