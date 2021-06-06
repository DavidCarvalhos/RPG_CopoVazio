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
    public class Mago : BaseJogador
    {
        #region Fields
        private int _BaseForca = 5;
        private int _BaseDestreza = 5;
        private int _baseSabedoria = 10;
        private int _Vida = 20;
        private Item[] _inventorio = new Item[] { new PocaoDeVida(), new PocaoDeVida(), new PocaoDeVida() };
        private int _danoMinimo = 2;
        private int _maxDmg = 6;
        //construtores
        public Mago()
        {
            ClassePersonagem = EntidadeClasse.guerreiro;
            Forca = _BaseForca;
            Destreza = _BaseDestreza;
            Sabedoria = _BaseSabedoria;
            Vida = _BaseVida;
            _danoMinimo = _danoMinimo;
            _DanoMaximo = _DanoMaximo;
            Inventario = InventarioChar;

        }

        //construtores criacao 
        public Mago(string nome, EntidadeGenero genero, Item[] _inventario) : base(nome, genero, _inventario)
        {
            ClassePersonagem = EntidadeClasse.guerreiro;
            Forca = _BaseForca;
            Destreza = _BaseDestreza;
            Sabedoria = _BaseSabedoria;
            Vida = _Vida;
            _danoMinimo = _danoMinimo;
            _DanoMaximo = _DanoMaximo;
            Inventario = inventarioChar;

        }

    }
}
#endregion