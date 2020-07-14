using Domain.Entities;
using Domain.Repository;
using System.Collections.Generic;
using Dapper;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using Domain.Options;


namespace Data.Implementations
{
	public class EventoImplementation : IEventoRepository
	{
        private readonly string connectionString;

        public EventoImplementation(IOptions<ConfigurationsOptions> options)
        {
            connectionString = options.Value.ConnectionString;
        }


        public async Task<IEnumerable<RelacaoEvento>> SelectAllAsync()
		{
            using (var connection = new SqlConnection(connectionString))
            {
                 return await  connection.QueryAsync<RelacaoEvento>(
                    @"select t.Regiao, sum(t.Qtd) TotalEventos
                      from(
                            select substring(tag, 0, CHARINDEX('sensor', tag) - 1) Regiao, count(*) Qtd
                            from evento
                            group by tag
                        
                           ) T
                      group by t.Regiao
                      union
                      select tag Regiao, count(*) Qtd
                      from evento
                      group by tag
                      order by 1");
            }          
            
        }
       
    }
}
