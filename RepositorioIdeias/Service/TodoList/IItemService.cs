using RepositorioIdeias.DTO.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositorioIdeias.Service.TodoList
{
    public interface IItemService
    {
        public Task<bool> SetItem(Item item);
        public Task<IEnumerable<Item>> GetItens();
    }
}
