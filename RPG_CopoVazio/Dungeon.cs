
using RPG_CopoVazio.Criaturas;
using RPG_CopoVazio.Criaturas.Monstros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Dungeon
{
    public class Historia
    {
        private List<string> _firstLine = new List<string> ();
        private string[] _directon = new string[2]
        {
            "cima",
            "baixo",
        };

        public void CriarDungeon(BaseMonstro enemy)
        {

        }

        public static string Lutar(BaseJogador Jogador, BaseMonstro Monstro, int DanoJogador, int DanoMonstro)
        {

            return Jogador.Nome + " acerta " + Monstro.Nome + " acerta em um ponto fraco do " + Environment.NewLine +
                Jogador.Nome + " Inflige " + DanoJogador + " Dano no " + Monstro.Nome + "!" + Environment.NewLine +
                Monstro.Nome + " Ele repele e ataca " + Jogador.Nome + " de volta dando " + DanoMonstro + " De dano!";

        }
    }
}
