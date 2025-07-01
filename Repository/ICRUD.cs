using web_tarefas.Models;

namespace web_tarefas.Repository
{
    public interface ICRUD
    {
        public int Criar(Tarefa tarefa);
        public void Atualizar(Tarefa tarefa);
        public void Excluir(int id);
        public Tarefa BuscarPorID(int id);
    }
}
