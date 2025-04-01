using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleV
{
    public class Animal
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public List<Move> Moves {  get; set; } 

        public Animal(string name, int health, List<Move> moves)
        {
            Name = name;
            Health = health;
            Moves = moves;
        }
    }
    public class Tiger : Animal
    {
        public Tiger() : base("Tiger", 150, MoveSetRepository.tigerMoves)
        {
        }
    }
    public class Bull : Animal
    {
        public Bull() : base("Bull", 200, MoveSetRepository.bullMoves)
        {
        }
    }
    public class Ape : Animal
    {
        public Ape() : base("Ape", 135, MoveSetRepository.apeMoves)
        {
        }
    }
    public class Dragon : Animal
    {
        public Dragon() : base("Dragon", 500, MoveSetRepository.dragonMoves)
        {
        }
    }
}
