using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Vídeo 1
        Video video1 = new Video(
            "Aprenda C# do Zero",
            "Code Academy",
            620
        );

        video1.AdicionarComentario(
            new Comentario("João", "Excelente vídeo! Aprendi bastante.")
        );

        video1.AdicionarComentario(
            new Comentario("Maria", "A explicação foi muito clara.")
        );

        video1.AdicionarComentario(
            new Comentario("Pedro", "Vou assistir novamente para praticar.")
        );


        // Vídeo 2
        Video video2 = new Video(
            "Como Criar um Jogo em C#",
            "Dev Games",
            845
        );

        video2.AdicionarComentario(
            new Comentario("Carlos", "Esse tutorial me ajudou muito.")
        );

        video2.AdicionarComentario(
            new Comentario("Lucas", "Gostei bastante do projeto.")
        );

        video2.AdicionarComentario(
            new Comentario("Fernanda", "Poderia fazer uma parte 2?")
        );


        // Vídeo 3
        Video video3 = new Video(
            "Programação Orientada a Objetos",
            "Programador Iniciante",
            735
        );

        video3.AdicionarComentario(
            new Comentario("Rafael", "Finalmente entendi o conceito de classes.")
        );

        video3.AdicionarComentario(
            new Comentario("Julia", "Ótima explicação sobre objetos.")
        );

        video3.AdicionarComentario(
            new Comentario("Marcos", "Conteúdo muito útil para iniciantes.")
        );

        video3.AdicionarComentario(
            new Comentario("Beatriz", "Estou estudando isso agora. Obrigada!")
        );


        // Vídeo 4
        Video video4 = new Video(
            "Dicas para Aprender Programação",
            "Tech Brasil",
            510
        );

        video4.AdicionarComentario(
            new Comentario("Gabriel", "As dicas são muito boas.")
        );

        video4.AdicionarComentario(
            new Comentario("Larissa", "Gostei principalmente da dica sobre prática.")
        );

        video4.AdicionarComentario(
            new Comentario("Daniel", "Vou colocar essas dicas em prática.")
        );


        // Lista de vídeos
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3,
            video4
        };


        // Exibir os vídeos e comentários
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"Título: {video.Titulo}");
            Console.WriteLine($"Autor: {video.Autor}");
            Console.WriteLine($"Duração: {video.Duracao} segundos");
            Console.WriteLine($"Número de comentários: {video.ObterNumeroComentarios()}");
            Console.WriteLine("Comentários:");

            foreach (Comentario comentario in video.ObterComentarios())
            {
                Console.WriteLine($"  {comentario.Nome}: {comentario.Texto}");
            }

            Console.WriteLine();
        }
    }
}