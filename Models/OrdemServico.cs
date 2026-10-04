namespace OficinaApp.Models;

public class OrdemServico
{
    public int Id { get; set; }
    public Cliente Cliente { get; set; }
    public Veiculo Veiculo { get; set; }
    public string Descricao { get; set; }
    public decimal ValorTotal { get; set; }
    public DateTime DataCadastro { get; set; }
    public string Status { get; set; }
}