namespace web_tarefas.Models
{
    public record PessoaDto
    {
        
        public string Nome { get; set; }
        public int IDade { get; set; }
        public string Cpf { get; set; }
    }
}
