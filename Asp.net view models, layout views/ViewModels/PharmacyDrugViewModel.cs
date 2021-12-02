using aspnet_view_models.models;
using System.Collections.Generic;

namespace aspnet_view_models.ViewModels
{
    public class PharmacyDrugViewModel
    {
        public List<Drug> Drugs { get; set; }
        public List<DrugType> DrugTypes { get; set; }
    }
}
