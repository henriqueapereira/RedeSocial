namespace RedeSocial.Models;

public class Publicacao
{
    public int Id { get; set; }
    public string Texto { get; set; }
    public string Visibilidade { get; set; }
    public int UsuarioId { get; set; }
    //public List<Comentario> Comentarios { get; set; }
    //public List<Curtida> Curtidas { get; set; }
    public bool FlAtivo { get; set; }
}
