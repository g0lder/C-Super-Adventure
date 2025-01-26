using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;


namespace Super_Adventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;

        public SuperAdventure()
        {
            InitializeComponent();

            _player = new Player(currentHealth:10, maximumHealth:10, gold:20, xp:0, level:1);

            lblHealth.Text = _player.CurrentHealth.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblXP.Text = _player.XP.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {

        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {

        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {

        }
        
    }
}
