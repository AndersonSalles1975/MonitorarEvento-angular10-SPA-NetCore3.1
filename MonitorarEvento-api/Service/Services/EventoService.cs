using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services;
using Domain.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Services
{
    public class EventoService: IEventoService
	{
        private readonly IRepository<Evento> _repository;
		private readonly IEventoRepository _eventoRepository;

		public EventoService(IRepository<Evento> repository, IEventoRepository eventoRepository)
        {
            _repository = repository;
			_eventoRepository = eventoRepository;

		}

		//preparado para futuras implementações
		//public async Task<Evento> Put(Evento evento)
		//{
		//	return await _repository.UpdateAsync(evento);
		//}

		//preparado para futuras implementações
		//public async Task<Evento> Get(Guid id)
		//{
		//	return await _repository.SelectAsync(id);
		//}

        //preparado para futuras implementações
        //public async Task<IEnumerable<Evento>> GetAll()
        //{
        //    return await _repository.SelectAsync();
        //}

        public async Task<IEnumerable<RelacaoEvento>> GetRelacaoEvento()
		{
			return await  _eventoRepository.SelectAllAsync();
		}

		public async Task<Evento> Post(Evento evento)
		{
			return await _repository.InsertAsync(evento);
		}

        public async Task<bool> Delete()
        {
            return await _repository.DeleteAsync();
        }
    }
}
