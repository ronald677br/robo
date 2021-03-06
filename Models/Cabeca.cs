﻿namespace robo.Models
{
    public class Cabeca : Componente
    {
        public static string STATE_ROTACAO_MENOS_90 = "Rotação -90º";
        public static string STATE_ROTACAO_MENOS_45 = "Rotação -45º";
        public Cabeca() : base(new string[3] { STATE_ROTACAO_MENOS_90, STATE_ROTACAO_MENOS_45, STATE_REPOUSO})
        {
            estadoAtualIndex = 2; inclinacaoAtualIndex = 1;
            id = "cabeca";
        }

        public override bool Mover(Movimentos movimento, Movimento.Tipo tipo)
        {
            if (tipo == Movimento.Tipo.posicao && InclinacaoAtual == STATE_INCLINACAO_PARA_BAIXO)
                throw new System.Exception("Movimento não pode ser realizado na inclinação " + STATE_INCLINACAO_PARA_BAIXO);
            return base.Mover(movimento, tipo);
        }
    }
}
