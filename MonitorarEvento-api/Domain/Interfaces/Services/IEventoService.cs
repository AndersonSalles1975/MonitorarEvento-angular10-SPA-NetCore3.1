using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IEventoService
    {
        //preparado para futuras implementações
        //Task<Evento> Get(Guid id);
        //Task<IEnumerable<Evento>> GetAll();
        //Task<Evento> Put(Evento evento);
        Task<Evento > Post(Evento evento);

        //preparado para futuras implementações
        //Task<bool> Delete(Guid id);
        Task<IEnumerable<RelacaoEvento>> GetRelacaoEvento();
    }
}