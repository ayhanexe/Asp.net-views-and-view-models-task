using aspnet_view_models.models;
using aspnet_view_models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace aspnet_view_models.controllers
{
    public class PharmacyController : Controller
    {
        public IActionResult Drug()
        {
            List<Drug> drugs = new List<Drug>()
            {
                new Drug() { Name = "Atilaza", Company = "Saşera-Med", Price = 25},
                new Drug() { Name = "Prozim N30", Company = "Cydonia Doo", Price = 32},
                new Drug() { Name = "Evkalipt yağı", Company = "Mirrolla", Price = 2}
            };

            List<DrugType> types = new List<DrugType>()
            {
                new DrugType() { Type = "Proteolitik" },
                new DrugType() { Type = "Iltihab Eleyhine" },
                new DrugType() { Type = "Antiseptik" }
            };


            PharmacyDrugViewModel model = new PharmacyDrugViewModel()
            {
                Drugs = drugs,
                DrugTypes = types
            };

            return View(model);
        }

        public IActionResult DrugTypes()
        {
            List<DrugType> types = new List<DrugType>()
            {
                new DrugType() { Type = "Proteolitik" },
                new DrugType() { Type = "Iltihab Eleyhine" },
                new DrugType() { Type = "Antiseptik" }
            };

            return View(types);
        }
    }
}
