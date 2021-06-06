using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using RPG.Items;

namespace RPG_CopoVazio.Criaturas
{
    public enum EntidadeGenero { masculino, feminino, Desconhecido };

    public enum EntidadeClasse { guerreiro, mago, Desconhecido };

    interface Entidade
    {
        string Nome { get; }

        int Forca { get; set; }

        int Destreza { get; set; }

        int Sabedoria { get; set; }

        int Vida { get; set; }

        EntidadeGenero genero { get; set; }

        EntidadeClasse ClassePersonagem { get; set; } 



    }
}
