
using RPG.Items;
using RPG_CopoVazio.Criaturas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace RPG.Data
{
    public class GerenciadorDeArquivos
    {
        public static string GerenciadorArquivos
        {
            get
            {
                // C:\Users\UserName\AppData\Roaming\RPG\CharacterSettings
                string folder = Environment.GetFolderPath(
                    Environment.SpecialFolder.ApplicationData);

                folder = Path.Combine(folder, "RPG", "Configuracoes Jogador");
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                return folder;
            }
        }
        public static string JogadorConfigFile
        {
            get
            {
                // C:\Users\UserName\AppData\Roaming\RPG\CharacterSettings\Player.xml
                return Path.Combine(GerenciadorArquivos, "Jogador.xml");
            }
        }


        public static BaseJogador LoadGame()
        {
            if (File.Exists(GerenciadorArquivos))
            {
                using (Stream stream = File.OpenRead(GerenciadorArquivos))
                {
                    XmlReader reader = new XmlTextReader(stream);
                    foreach (var type in BaseJogador.types)
                    {
                        var serializer = new XmlSerializer(type);

                        if (serializer.CanDeserialize(reader))
                        {
                            return (BaseJogador)serializer.Deserialize(reader);
                        }
                    }
                }
            }
            return null;

        }

        public static void StoreCharacter(BaseJogador player)
        {
            using (Stream stream = File.Create(JogadorConfigFile))
            {
                XmlSerializer ser = new XmlSerializer(player.GetType(), "PlayerBase");
                ser.Serialize(stream, player);
            }
        }
    }
}