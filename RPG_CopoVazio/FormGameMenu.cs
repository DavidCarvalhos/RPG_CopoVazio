
using RPG.Data;
using RPG_CopoVazio.Criaturas;
using RPG_CopoVazio.Criaturas.Monstros;
using System.Windows.Forms;

namespace RPG
{
    public partial class Frm_GameMenu 
    {
        private BaseJogador jogador = GerenciadorDeArquivos.LoadGame();
        private BaseMonstro _npc = new BaseMonstro();

        public Frm_GameMenu()
        {
            InitializeComponent();
        }

        private void Frm_GameMenu_Load(object sender, EventArgs e)
        {
            if (_player != null)
            {
                RefreshMenu();
                
                Pb_Experience.Minimum = XP;
                Pb_Experience.Maximum = LevelUP;
            }
            else
            {
                MessageBox.Show("No character file to load, start a new game.");
                Close();
            }
        }

        private void Btn_NewEnemy_Click(object sender, EventArgs e)
        {
            if(!_npc.Morto())
            {
                MessageBox.Show("You can't engage a new enemy until you defeated your current enemy!");
            }
            else
            {
                Tb_Dungeon.Clear();
                ShowNewEnemy();
            }
        }

        // Placeholderför test av funktion, Story kan genereras från annan klass sedan.
        public void ShowNewEnemy()
        {
            _npc = _npc.GetNewEnemy();

            Tb_Dungeon.AppendText("Eeek a " +
                _npc.Name + "!" + Environment.NewLine + Environment.NewLine +
                "Enemy: " + _npc.Name + Environment.NewLine + 
                "Current health: " + _npc.Health);
        }

        private void Btn_PlayerAttack_Click(object sender, EventArgs e)
        {
            Tb_Dungeon.Clear();
            if (!_player.IsDead() && !_npc.IsDead())
            {
                int npcDamage = _npc.Attack();
                int playerDamage = _player.Attack();
                _npc.DecreaseHealth(playerDamage);
                _player.DecreaseHealth(npcDamage);

                Tb_Dungeon.AppendText(Story.FightingNPC(_player, _npc, playerDamage, npcDamage));
                Lbl_ShowHealth.Text = _player.Health.ToString();

                if (_npc.IsDead())
                {
                    Tb_Dungeon.AppendText(Environment.NewLine + "You have defeated " + _npc.Name + Environment.NewLine +
                        "You are rewarded with " + _npc.ExperienceDrop + " experience.");
                    _player.ExperienceGain(_npc.ExperienceDrop);
                    Pb_Experience.Value += _npc.ExperienceDrop;

                    if(Pb_Experience.Value == Pb_Experience.Maximum)
                    {
                        Pb_Experience.Value = 0;
                        RefreshMenu();
                    }

                }
                else
                {    
                    Tb_Dungeon.AppendText(Environment.NewLine + _npc.Name + "'s current health: " + _npc.Health);
                }
            }
            else
            {
                MessageBox.Show("There is no enemy to attack.");
            }





        }

        // Uppdaterar UI med nya värden efter en fight/level up
        public void RefreshMenu()
        {
            Lbl_ShowHealth.Text = _player.Health.ToString();
            Lbl_ShowName.Text = _player.Name;
            Lbl_ShowGender.Text = _player.Gender.ToString();
            Lbl_ShowClass.Text = _player.CharacterClass.ToString();
            Lbl_ShowStrength.Text = _player.Strength.ToString();
            Lbl_ShowDexterity.Text = _player.Dexterity.ToString();
            Lbl_ShowWisdom.Text = _player.Wisdom.ToString();
            Lbl_ShowLevel.Text = _player.Level.ToString();
            Lbl_ShowHealth.Text = _player.Health.ToString();
            Pb_Experience.Minimum = _player.Experience;
            Pb_Experience.Maximum = _player.experienceNeeded;

        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            FileManager.StoreCharacter(_player);
        }

        private void Btn_Inventory_Click(object sender, EventArgs e)
        {
            Frm_Inventory FormInventory = new Frm_Inventory(_player);
            FormInventory.Show();
        }
    }
}
