using RPG_CopoVazio.Criaturas.Monstros;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Criaturas
{
    class MonstroEsqueleto : BaseMonstro
    {
        private int _ForcaBase = 1;
        private int _DestrezaBase = 1;
        private int _SabedoriaBase = 0;
        private int _Vida = 8;
        private string _Nome = "Esqueleto";

        private int _XPesqueleto = 25;

        private int _EsqueletoDanoMinimo = 1;
        private int _EsqueletoDanoMaximo = 6;

        #region construtores
        
        public MonstroEsqueleto(string nome) : base (nome)
        {
            nome = _Nome;
            Forca = _ForcaBase;
            Destreza = _DestrezaBase;
            Sabedoria = _SabedoriaBase;
            Vida = _Vida;
            XPDrop = _XPesqueleto;

            _DanoMinimo = _EsqueletoDanoMinimo;
            _DanoMaximo = _EsqueletoDanoMaximo;
        }
    }

    
    
}
#endregion