using web_tarefas.Models;
using web_tarefas.Repository;

namespace web_tarefas.Services
{
    public class TarefaService : ITarefaService
    {
        private readonly ITarefaRepository _repository;
        public TarefaService(ITarefaRepository tarefaContext)
        {
            _repository = tarefaContext;
        }

        public void Atualizar(Tarefa tarefa)
        {
            _repository.Atualizar(tarefa);
        }

        public Tarefa BuscarPorId(int id)
        {
            return _repository.FindByID(id);
        }

        public List<Tarefa> BuscarTodos()
        {
            return _repository.BuscarTodos();
        }

        public int Criar(Tarefa tarefa)
        {
            return _repository.Criar(tarefa);
        }

        public void Excluir(int id)
        {
            _repository.Excluir(id);
        }

        public bool ValidarEntidade(Tarefa tarefa)
        {
            return true;
        }
    }
}
