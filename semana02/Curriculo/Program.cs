using System;

class Program
{
    static void Main(string[] args)
    {
        Emprego emprego1 = new Emprego();
        emprego1._cargo = "Coordenador de Projetos";
        emprego1._empresa = "Andritz Brasil LTDA";
        emprego1._anoInicio = 2011;
        emprego1._anoFim = 2025;

        Emprego emprego2 = new Emprego();
        emprego2._cargo = "Engenheiro de Projetos";
        emprego2._empresa = "Aker Kvaerner/Metso";
        emprego2._anoInicio = 2003;
        emprego2._anoFim = 2011;

        Curriculo meuCurriculo = new Curriculo();
        meuCurriculo._nome = "Luciano Piechnik";

        meuCurriculo._empregos.Add(emprego1);
        meuCurriculo._empregos.Add(emprego2);

        meuCurriculo.Exibir();
    }
}