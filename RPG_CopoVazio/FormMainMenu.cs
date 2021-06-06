using RPG.CharacterClasses;
using RPG.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Btn_CreateChar_Click(object sender, EventArgs e)
        {
            Frm_CharCreator charCreator = new Frm_CharCreator();
            charCreator.Show();
        }

        private void Btn_LoadGame_Click(object sender, EventArgs e)
        {
            Frm_GameMenu gameMenu = new Frm_GameMenu();
            gameMenu.Show();
        }

        private void Btn_Credits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by, Fredrik Rönnehag"
                + Environment.NewLine +
                "2018. Stockholm, Sweden");

        }
    }
}
