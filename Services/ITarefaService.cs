using web_tarefas.Models;
namespace web_tarefas.Services
{
    public interface ITarefaService
    {
        public int Criar(Tarefa tarefa);
        public void Atualizar(Tarefa tarefa);
        public Tarefa BuscarPorId(int id);
        public List<Tarefa> BuscarTodos();
        public void Excluir(int id);
    }
}