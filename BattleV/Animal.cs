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
}
