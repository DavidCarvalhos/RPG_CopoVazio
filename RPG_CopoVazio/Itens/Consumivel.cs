using RPG.CharacterClasses;
using RPG_CopoVazio.Criaturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Items
{
    interface Consumir
    {
        string Nome { get; set; }
        string TipoItem { get; set; }
        int EfeitoConsumo { get; set; }

        void Use(BaseJogador player);
        void Vender();

    }
}
