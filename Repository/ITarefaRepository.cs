using web_tarefas.Models;

namespace web_tarefas.Repository
{
    public interface ITarefaRepository : ICRUD
    {
        public Tarefa FindByID(int id);
    }
}
