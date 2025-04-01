using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleV
{
    public partial class BattleV : Form
    {
        public BattleV()
        {
            InitializeComponent();
        }

        public static List<Animal> Animals = new List<Animal>
        {
        new Tiger(),
        new Bull(),
        new Ape(),
        new Dragon()
        };

        Animal playerAnimal;
        Animal aiAnimal;

        private void PlayerAttack(Animal aiAnimal, Animal playerAnimal, Move selectedMove)
        {
            aiAnimal.Health -= selectedMove.Damage;
            MessageBox.Show($"{playerAnimal.Name} used {selectedMove.Name} and dealt {selectedMove.Damage} to {aiAnimal.Name}!");

            aiAttack(aiAnimal, playerAnimal);
        }

        private void aiAttack(Animal aiAnimal, Animal playerAnimal)
        {
            Random random = new Random();
            int index = random.Next(aiAnimal.Moves.Count);
            Move aiMove = aiAnimal.Moves[index];

            playerAnimal.Health -= aiMove.Damage;
            MessageBox.Show($"{aiAnimal.Name} used {aiMove.Name} and dealt {aiMove.Damage} to {playerAnimal.Name}!");
        }

        private void BattleV_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            aiAnimal = Animals[random.Next(0,4)];
            playerAnimal = new Dragon();

            playerAttack1.Text = ($"{playerAnimal.Moves[0].Name}");
            playerAttack2.Text = ($"{playerAnimal.Moves[1].Name}");
            playerAttack3.Text = ($"{playerAnimal.Moves[2].Name}");
            playerAttack4.Text = ($"{playerAnimal.Moves[3].Name}");
        }

        private void playerAttack1_Click(object sender, EventArgs e)
        {
            PlayerAttack(aiAnimal, playerAnimal, playerAnimal.Moves[0]);
        }

        private void playerAttack2_Click(object sender, EventArgs e)
        {
            PlayerAttack(aiAnimal, playerAnimal, playerAnimal.Moves[1]);
        }

        private void playerAttack3_Click(object sender, EventArgs e)
        {
            PlayerAttack(aiAnimal, playerAnimal, playerAnimal.Moves[2]);
        }

        private void playerAttack4_Click(object sender, EventArgs e)
        {
            PlayerAttack(aiAnimal, playerAnimal, playerAnimal.Moves[3]);
        }
    }
}
