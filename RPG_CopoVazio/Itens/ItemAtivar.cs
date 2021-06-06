
using RPG_CopoVazio.Criaturas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RPG.Items
{
    [XmlRoot(Namespace = "jogadorBase")]
    public class ItemAtivar : Item
    {
        public string Nome { get; set; }
        public string TipoITem { get; set; }
        public int EfeitoConsumo { get; set; }
        public string TipoItem { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Item()
        {

        }


        public void Vender() { }
        public virtual void Use(BaseJogador player) { }
    }
}
