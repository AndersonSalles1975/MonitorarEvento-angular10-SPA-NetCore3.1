using Domain.Entities;
using Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Repository
{
	public interface IEventoRepository
	{
		
		Task<IEnumerable<RelacaoEvento>> SelectAllAsync();
	
	}
}