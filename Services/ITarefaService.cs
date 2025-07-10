using web_tarefas.Models;
using web_tarefas.Repository;

namespace web_tarefas.Services
{
    public interface ITarefaService : ICRUD<Tarefa>
    {
        public Task<List<Tarefa>> BuscarOrdenadoDataCriacaoDesc();
    }
}
