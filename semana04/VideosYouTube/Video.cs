using System.Collections.Generic;

class Video
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Duracao { get; set; }

    private List<Comentario> _comentarios;

    public Video(string titulo, string autor, int duracao)
    {
        Titulo = titulo;
        Autor = autor;
        Duracao = duracao;
        _comentarios = new List<Comentario>();
    }

    public void AdicionarComentario(Comentario comentario)
    {
        _comentarios.Add(comentario);
    }

    public int ObterNumeroComentarios()
    {
        return _comentarios.Count;
    }

    public List<Comentario> ObterComentarios()
    {
        return _comentarios;
    }
}