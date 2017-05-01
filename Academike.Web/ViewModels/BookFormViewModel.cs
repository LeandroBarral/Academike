﻿using Academike.Web.Services;
using System.ComponentModel.DataAnnotations;

namespace Academike.Web.ViewModels
{
    public class BookFormViewModel : BaseViewModel
    {
        public BookFormViewModel(int id, IIcLayoutMetadataServiceContainer layoutMetadataService)
            : base(layoutMetadataService)
        {
            LayoutMetadataService.PageMetadataService.AddTitle("Cadernos");
            LayoutMetadataService.BreadcrumbService.Add("Cadernos");

            if (id > 0)
                LayoutMetadataService.BreadcrumbService.Add("Editar");
            else
                LayoutMetadataService.BreadcrumbService.Add("Novo");

            Id = id;
        }

        public BookFormViewModel(IIcLayoutMetadataServiceContainer layoutMetadataService)
            : this(0, layoutMetadataService)
        {

        }

        internal BookFormViewModel() : base() { }

        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }
    }
}
