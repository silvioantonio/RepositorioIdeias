using RepositorioIdeias.DTO.ViewModel;
using System.Threading.Tasks;

namespace RepositorioIdeias.Repository.TodoList
{
    public interface IItemRepository
    {
        public Task<T> SetItem<T>(Item item);
        public Task<T> GetItens<T>();
    }
}
