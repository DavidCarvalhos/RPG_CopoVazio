using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using NetTopologySuite.Algorithm;
using RPG.Items;

namespace RPG_CopoVazio.Criaturas
{
    [XmlInclude(typeof(Mago))]
    [XmlInclude(typeof(Guerreiro))]
    [XmlInclude(typeof(Item))]
    [XmlInclude(typeof(PocaoDeVida))]

    public class BaseJogador : Entidade
    {
        public static Type[] types = new Type[]
        {
            typeof(Mago),
            typeof(Guerreiro)
        };
        protected Random rand = new Random();

        #region atributos
        protected int FatorForca;
        protected int FatorDestreza;
        protected int FatorSabedoria;
        protected int FatorVida;
        protected int _Vida;
        public int VidaMaxima;

        public int LevelUp = 100;
        protected int _LevelInicial = 1;
        protected int _DanoMinimo;
        protected int _DanoMaximo;
        protected int _SlotsTotal = 8;

        #endregion

        #region propriedades
        public string Nome { get; set; }
        public int Forca { get; set; }
        public int Destreza { get; set; }
        public int Sabedoria { get; set; }
        public int XP { get; set; }
        public int Level { get; set; }
        public int Vida
        {
            get
            {
                return _Vida;
            }
            set
            {
                if (value < 0) _Vida = 0;
                if (value > VidaMaxima) _Vida = VidaMaxima;
                else _Vida = value;

            }
        }

        public Item[] Inventario { get; set; }
        public EntidadeGenero genero { get; set; }
        public EntidadeClasse ClassePersonagem { get; set; }
        #endregion

        #region Construtores
        public BaseJogador() { }

        public BaseJogador(string _name, EntidadeGenero _genero, Item[] _inventario)
        {
            Nome = _name;
            genero = _genero;
            Level = _LevelInicial;
            Inventario = _inventario;
        }
        #endregion

        #region combate
        public bool Morto() => Vida is 0;
        public bool levelUp() => XP >= LevelUp;

        public void XpGanho(int points)
        {
            XP += points;
            if (levelUp())
            {
                Forca += 3;
                Destreza += 3;
                VidaMaxima = Vida + 5;
                Vida = VidaMaxima;
                Level += 1;
            }
        }

        public int Atacar()
        {
            _DanoMinimo = _DanoMinimo + Forca / 3;
            _DanoMaximo = _DanoMaximo + Forca / 3;

            if (Morto())
            {
                return rand.Next(_DanoMinimo, _DanoMaximo + 1);
            }
            return 0;
        }

        public void TomarDano(int Dano)
        {
            Vida -= Dano;
        }
        #endregion

        #region inventario

        public string AdicionarItem(Item ItemDropado)
        {
            string msg = "";

            for (int x = 0; x < Length.Inventario; x++)
            {
                if (Inventario[x] != null)
                {
                    Inventario[x] = ItemDropado;
                    msg = ItemDropado.Nome + "adicionado em seu inventario";

                }
                else
                {
                    msg = "inventario esta cheio";
                }
            }
            return msg;
        }
        #endregion

    }
}

