using RPG.Criaturas;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_CopoVazio.Criaturas.Monstros
{
    public class BaseMonstro : Entidade
    {
        protected Random rand = new Random();
        protected int _DanoMinimo;
        protected int _DanoMaximo;
        protected int _XPDrop;

        #region info
        public string Nome { get; set; }
        public int Forca { get; set; }
        public int Destreza { get; set; }
        public int Sabedoria { get; set; }
        public int Vida { get; set; }
        public int XPDrop { get; set; }
        public EntidadeGenero genero { get; set; } 
        public EntidadeClasse ClassePersonagem { get; set; } 
        #endregion

        #region construtores
        public BaseMonstro(string nome)
        {
            Nome = nome;
        }
        #endregion

        #region spawn
        public BaseMonstro NovoInimigo()
        {
            BaseMonstro[] _BaseMonstro = new BaseMonstro[]
            {
                new MonstroEsqueleto("esqueleto") };
            Random rand = new Random();
            int proximo = rand.Next(0, _BaseMonstro.Length);
            if (_BaseMonstro != null)
            {
                return _BaseMonstro[proximo];
            }
            return null;
        }
        #endregion

        #region combate
        public bool Morto() => Vida is 0;
        public int Atacar()
        {
            if (!Morto())
            {
                return rand.Next(_DanoMinimo, _DanoMaximo);

            }
            return 0;
        }
        public int TomarDano(int Dano)
        {
            Vida -= Dano;
            Vida = Math.Max(0, Vida);

            if (Morto())
            {
                return XPDrop;
            }
            else return 0;
        }
    }
}
    #endregion