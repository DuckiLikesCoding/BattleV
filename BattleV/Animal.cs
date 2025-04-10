using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleV
{
    public class Animal
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public List<Move> Moves {  get; set; } 

        public Image Image { get; set; }

        public Animal(string name, int health, List<Move> moves, Image image)
        {
            Name = name;
            Health = health;
            MaxHealth = health;
            Moves = moves;
            Image = image;
        }
    }
    public class Tiger : Animal
    {
        public Tiger() : base("Tiger", 150, MoveSetRepository.tigerMoves, Properties.Resources.ape_R)
        {
        }
    }
    public class Bull : Animal
    {
        public Bull() : base("Bull", 200, MoveSetRepository.bullMoves, Properties.Resources.ape_R)
        {
        }
    }
    public class Ape : Animal
    {
        public Ape() : base("Ape", 135, MoveSetRepository.apeMoves, Properties.Resources.ape_R)
        {
        }
    }
    public class Dragon : Animal
    {
        public Dragon() : base("Dragon", 500, MoveSetRepository.dragonMoves, Properties.Resources.ape_R)
        {
        }
    }
}
