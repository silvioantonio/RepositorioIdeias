using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RepositorioIdeias.DTO.Enum;
using RepositorioIdeias.DTO.ViewModel;
using RepositorioIdeias.Service.TodoList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositorioIdeias.Pages.TodoList
{
    public class IndexModel : PageModel
    {
        private readonly IItemService _itemService;

        public IndexModel(IItemService itemService)
        {
            _itemService = itemService;
        }

        [BindProperty]
        public Item Item { get; set; }

        [BindProperty]
        public IEnumerable<Item> Itens { get; set; }

        public SelectList tiposItem => new SelectList(LoadTiposItem(), "Value", "Text", Item.TipoItem);

        public async Task<IActionResult> OnGetAsync()
        {
            Item = new Item();
            Itens = new List<Item>();
            //Itens = await _itemService.GetItens();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Item.Titulo))
                {
                    ModelState.AddModelError("", "O título deve ser preenchido.");
                }
                if (ModelState.IsValid)
                {
                    await _itemService.SetItem(Item);
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return Page();
        }

        private List<SelectListItem> LoadTiposItem()
        {
            var tiposItens = new List<SelectListItem>();
            var enumTiposItens = Enum.GetValues(typeof(EnumTipoItem)).Cast<EnumTipoItem>().Select(tipo => new SelectListItem
            {
                Text = EnumHelper.GetDescription(tipo),
                Value = ((int)tipo).ToString()
            }).ToList();

            foreach (var item in enumTiposItens)
            {
                tiposItens.Add(item);
            }
            return tiposItens;
        }
    }
}
