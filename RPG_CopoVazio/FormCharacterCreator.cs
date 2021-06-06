
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using RPG.Data;
using RPG.Items;
using RPG_CopoVazio.Criaturas;

namespace RPG
{
    public partial class Frm_CharCreator : Form
    {
        public Frm_CharCreator()
        {
            InitializeComponent();
        }

        private void Btn_SaveChar_Click(object sender, EventArgs e)
        {
            string name = Txt_CharName.Text;
            string selectedClass = Cbo_CharClass.Text;

            EntidadeGenero gender = Rdo_GenderMale.Checked ? EntidadeGenero.masculino: EntidadeGenero.feminino;
            var entityClass = ClassSelect(selectedClass);

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(selectedClass))
            {
                PlayerBase hero = null;
                Item[] startingItems = new Item[] { new PocaoDeVida(), new PocaoDeVida(), new PocaoDeVida() };
                switch (selectedClass)
                {
                    case "Shaman":
                        hero = new Guerreiro(name, gender, startingItems);
                        break;
                    case "Berserker":
                        hero = new Mago(name, gender, startingItems);
                        break;
                    case "Rogue":
                        //hero = new Rogue(name, gender);
                        break;
                    case "Warrior":
                        //hero = new Warrior(name, gender);
                        break;
                    case "Wizard":
                        //hero = new Wizard(name, gender);
                        break;
                    default:
                        break;
                }
                if (hero != null)
                {
                    FileManager.StoreCharacter(hero);
                    Frm_GameMenu gameMenu = new Frm_GameMenu();
                    gameMenu.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("You need to choose a class!");
                }

            }

            else if (string.IsNullOrWhiteSpace(name) || name[0] == ' ')
            {
                MessageBox.Show("Your characters name can't be empty or begin with a space.");
            }
            else
            {
                MessageBox.Show("You need to select a class for your character!");
            }
        }


        private void Cbo_CharClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stats = ShowStats(Cbo_CharClass.Text);

            Txt_CharStats.Clear();
            Txt_CharStats.AppendText(stats);
        }

        public string ShowStats(string selected)
        {
            
            var entitySelect = ClassSelect(selected);
            string returnStats = "";

            PlayerBase[] entities = new PlayerBase[] 
            {
                new Shaman()

                // Add new heroes here to show their stats
                
            };

            PlayerBase selectedEntity = new PlayerBase();
            foreach (var entity in entities)
            {
                if (entitySelect == entity.CharacterClass)
                {
                    selectedEntity = entity;
                    returnStats +=
                        "Strength: " + selectedEntity.Strength + Environment.NewLine +
                        "Dexterity: " + selectedEntity.Dexterity + Environment.NewLine +
                        "Wisdom: " + selectedEntity.Wisdom + Environment.NewLine +
                        "Health: " + selectedEntity.Health + Environment.NewLine;
                    break;
                }
            }
            return returnStats;
            
        }

        public EntidadeClasse ClassSelect(string selected)
        {
            try
            {
                EntityClass entityClass = (EntityClass)Enum.Parse(typeof(EntityClass), selected, true);
                return entityClass;
            }
            catch(ArgumentException)
            {
                MessageBox.Show("You need to select a hero class!");
            }
            return EntityClass.Unknown;

        }
    }
}