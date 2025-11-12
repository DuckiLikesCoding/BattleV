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
            Refresh(aiAnimal, aiPercentage, aiHealth);
            MessageBox.Show($"{playerAnimal.Name} used {selectedMove.Name} and dealt {selectedMove.Damage} to {aiAnimal.Name}!");

            aiAttack(aiAnimal, playerAnimal);
        }

        private void aiAttack(Animal aiAnimal, Animal playerAnimal)
        {
            Random random = new Random();
            int index = random.Next(aiAnimal.Moves.Count);
            Move aiMove = aiAnimal.Moves[index];

            playerAnimal.Health -= aiMove.Damage;
            Refresh(playerAnimal, playerPercentage, playerHealth);
            MessageBox.Show($"{aiAnimal.Name} used {aiMove.Name} and dealt {aiMove.Damage} to {playerAnimal.Name}!");
        }

        private void BattleV_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            aiAnimal = Animals[random.Next(0,4)]; //ai animal here
            aiLabel.Text = ($"Ai's {aiAnimal.Name}");
            aiImage.Image = (aiAnimal.Image);
            aiImageFlip(aiImage);
            Refresh(aiAnimal, aiPercentage, aiHealth);

            playerAnimal = new Dragon(); //change your animal here, no screen yet
            playerLabel.Text = ($"Your {playerAnimal.Name}");
            playerImage.Image = playerAnimal.Image;
            Refresh(playerAnimal, playerPercentage, playerHealth);

            playerAttack1.Text = ($"{playerAnimal.Moves[0].Name}");
            playerAttack2.Text = ($"{playerAnimal.Moves[1].Name}");
            playerAttack3.Text = ($"{playerAnimal.Moves[2].Name}");
            playerAttack4.Text = ($"{playerAnimal.Moves[3].Name}");
        }

        public void Refresh(Animal animal, Label percentage, ProgressBar health)
        {
            percentage.Text = ($"{GetHealthPercentage(animal)}%");
            health.Value = GetHealthPercentage(animal);
        }

        private void aiImageFlip(PictureBox pictureBox)
        {
            pictureBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox.Refresh();
        }

        public int GetHealthPercentage(Animal animal)
        {
            int percentage = Convert.ToInt16(Math.Round((animal.Health / (float)animal.MaxHealth) * 100, 0));
            if(percentage < 0)
                { percentage = 0; }
            return percentage;
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
