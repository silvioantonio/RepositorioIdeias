using RepositorioIdeias.DTO.Enum;
using RepositorioIdeias.DTO.ViewModel;
using RepositorioIdeias.Repository.TodoList;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositorioIdeias.Service.TodoList
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<IEnumerable<Item>> GetItens()
        {
            return await _itemRepository.GetItens<IEnumerable<Item>>();
        }

        public async Task<bool> SetItem(Item item)
        {
            if (string.IsNullOrWhiteSpace(item.Titulo))
            {
                throw new ArgumentException("O título deve ser preenchido.");
            }
            item.DataCriacao = DateTime.Now;
            item.StatusItem = EnumStatusItem.Criado;
            return await _itemRepository.SetItem<bool>(item);
        }
    }
}
