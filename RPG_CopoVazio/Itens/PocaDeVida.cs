using RPG_CopoVazio.Criaturas;
using System.Xml.Serialization;

namespace RPG.Items
{
    [XmlRoot(Namespace = "PlayerBase")]
    public class PocaoDeVida : Item, Consumir
    {
        private string _Nome = "PoçãoDeVida";
        private string _Tipo = "Poção";
        private int _ValorVida = 15;

        

        
        public PocaoDeVida()
        {
            Nome = _nome;
            TipoItem = _tipo;
            EfeitoConsumo = _ValorVida;
        }

        public string Nome { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string TipoItem { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int EfeitoConsumo { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public override void Use(BaseJogador player)
        {
            player.Vida += EfeitoConsumo;
            if (player.Vida > player.VidaMaxima)
            {
                player.Vida = player.VidaMaxima;
            }
        }

        public void Vender()
        {
            
        }
    }
}
