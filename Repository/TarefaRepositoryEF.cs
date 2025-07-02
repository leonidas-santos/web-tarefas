using web_tarefas.Models;

namespace web_tarefas.Repository
{
    public class TarefaRepositoryEF : ITarefaRepository
    {
        private readonly TarefaContext _tarefaContext;
        public TarefaRepositoryEF(TarefaContext tarefaContext)
        {
            _tarefaContext = tarefaContext;
        }

        public void Atualizar(Tarefa tarefa)
        {
            _tarefaContext.Update(tarefa);
            _tarefaContext.SaveChanges();
        }

        public Tarefa BuscarPorID(int id)
        {
            return _tarefaContext.Tarefas.FirstOrDefault(x => x.Id == id);
        }

        public List<Tarefa> BuscarTodos()
        {
            return _tarefaContext.Tarefas.ToList();
        }

        public int Criar(Tarefa tarefa)
        {
            _tarefaContext.Tarefas.Add(tarefa);
            return _tarefaContext.SaveChanges();
        }

        public void Excluir(int id)
        {
            Tarefa tarefa = _tarefaContext.Tarefas.FirstOrDefault(x => x.Id == id);
            _tarefaContext.Remove(tarefa);
            _tarefaContext.SaveChanges();
        }

        public Tarefa FindByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
