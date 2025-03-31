using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleV
{
    public class Move
    {
        public string Name {  get; set; }
        public int Damage {  get; set; }
    
        public Move(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
    }
}
