using web_tarefas.Models;

namespace web_tarefas.Repository
{
    public interface ITarefaRepository : ICRUD<Tarefa>
    {
        public Tarefa FindByID(int id);
    }
}
