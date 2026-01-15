using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }

    // Este campo guarda o caminho (texto) no banco
    public string? ImagemUrl { get; set; }

    // Este campo recebe o arquivo físico do formulário
    [NotMapped]
    public IFormFile? ImagemArquivo { get; set; }
}