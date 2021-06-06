using RPG.CharacterClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPG.Items;
using RPG.Data;

namespace RPG
{
    public partial class Frm_Inventory : Form
    {
        public Frm_Inventory(PlayerBase player)
        {
            InitializeComponent();

            Label[] labels = new Label[]
            {
                Lbl_Item1, Lbl_Item2, Lbl_Item3,
                Lbl_Item4, Lbl_Item5,
                Lbl_Item6, Lbl_Item7, Lbl_Item8
            };

            foreach(var label in labels)
            {
                foreach(var item in player.Inventory)
                {
                    if(item != null)
                    {
                        label.Show();
                        label.Text = item.Name.ToString();
                        
                    }
                }
            }





        }





    }
}
