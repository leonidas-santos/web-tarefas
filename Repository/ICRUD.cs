namespace web_tarefas.Repository
{
    public interface ICRUD<T>
    {
        public int Criar(T entidade);
        public void Atualizar(T entidade);
        public void Excluir(int id);
        public T BuscarPorID(int id);
        public List<T> BuscarTodos();
    }
}
