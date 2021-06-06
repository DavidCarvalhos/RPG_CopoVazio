using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using RPG.Items;

namespace RPG_CopoVazio.Criaturas
{
    [XmlRoot(Namespace = "BaseJogador")]
    public class Guerreiro : BaseJogador
    {
        //atributos
        private int _BaseForca = 10;
        private int _BaseDestreza = 5;
        private int _BaseSabedoria = 5;
        private int _BaseVida = 25; 

        //construtores
        public Guerreiro()
        {
            ClassePersonagem = EntidadeClasse.guerreiro;
            Forca = _BaseForca;
            Destreza = _BaseDestreza;
            Sabedoria = _BaseSabedoria;
            Vida = _BaseVida; 

        }

        //construtores criacao 
        public Guerreiro(string nome, EntidadeGenero genero, Item[] _inventario) : base(nome, genero, _inventario)
        {
            ClassePersonagem = EntidadeClasse.guerreiro;
            Forca = _BaseForca;
            Destreza = _BaseDestreza;
            Sabedoria = _BaseSabedoria;
            Vida = _BaseVida;
        }
            
    }
}
