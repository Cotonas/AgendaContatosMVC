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
    }
}
