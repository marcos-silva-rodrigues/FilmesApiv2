using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Filme
{

    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O título do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O título do filme não pode exceder 50 caracteres")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }

    [Required]
    [Range(70, 360, ErrorMessage = "A duração deve ter entre 70 e 360 minutos")]
    public int Duracao { get; set; }

    [Required]
    [StringLength(10, ErrorMessage = "O nome do diretor deve ter pelo menos 10 caracteres")]
    public string Diretor { get; set; }

    public virtual ICollection<Sessao> Sessoes { get; set; }
}