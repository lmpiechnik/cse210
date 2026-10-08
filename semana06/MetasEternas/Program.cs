class Program
{
    static void Main(string[] args)
    {
        /*
         * CRIATIVIDADE / REQUISITOS EXTRAS:
         *
         * Além dos requisitos básicos do projeto, este programa
         * possui um sistema de níveis baseado na pontuação do jogador.
         *
         * A cada 1000 pontos o jogador sobe de nível.
         * Isso adiciona um elemento de gamificação ao programa
         * para incentivar o usuário a continuar registrando suas metas.
         */

        GerenciadorDeMetas gerenciador = new GerenciadorDeMetas();

        gerenciador.Iniciar();
    }
}