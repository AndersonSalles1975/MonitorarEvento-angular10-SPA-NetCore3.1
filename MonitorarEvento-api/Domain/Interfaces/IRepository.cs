using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
	public interface IRepository<T> {

        Task<T> InsertAsync(T item);

        //Para futura implementação
        //Task<T> UpdateAsync(T item);

        Task<bool> DeleteAsync();

        //Para futura implementação
        //Task<T> SelectAsync(Guid id);

        Task<IEnumerable<T>> SelectAsync();
    }
}
