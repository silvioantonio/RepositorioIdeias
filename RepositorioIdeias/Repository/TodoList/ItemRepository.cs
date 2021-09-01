using RepositorioIdeias.DTO.ViewModel;
using System;
using System.Threading.Tasks;

namespace RepositorioIdeias.Repository.TodoList
{
    public class ItemRepository : IItemRepository
    {
        public async Task<T> GetItens<T>()
        {
            throw new NotImplementedException();
        }

        public async Task<T> SetItem<T>(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
