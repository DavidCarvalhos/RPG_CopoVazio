using RPG.CharacterClasses;
using RPG_CopoVazio.Criaturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Items
{
    public interface Item
    {
        public string Nome { get; set; }
        public string TipoItem { get; set; }

        void Vender();
        void Use(BaseJogador Jogador);

    }
}
