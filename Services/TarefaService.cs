using web_tarefas.Models;
using web_tarefas.Repository;

namespace web_tarefas.Services
{
    public class TarefaService
    {
        private readonly ITarefaRepository _repository;
        public TarefaService(ITarefaRepository tarefaContext)
        {
            _repository = tarefaContext;
        }
    }
}
