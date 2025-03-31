using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleV
{
    internal class MoveSetRepository
    {
        public static List<Move> tigerMoves = new List<Move>()
        {
            new Move("Scratch", 10),
            new Move("Bite", 20),
            new Move("Pounce", 15),
            new Move("Growl", 5)
        };

        public static List<Move> apeMoves = new List<Move>()
        {
            new Move("Punch", 10),
            new Move("Scream", 3),
            new Move("Angry Look", 1),
            new Move("Poop Throw", 30)
        };

        public static List<Move> bullMoves = new List<Move>()
        {
            new Move("Super Fast Charge", 25),
            new Move("Fast Charge", 20),
            new Move("Charge", 15),
            new Move("Walk", 5)
        };

        public static List<Move> dragonMoves = new List<Move>()
        {
            new Move("Scratch", 25),
            new Move("Fire Breath", 60),
            new Move("Roar", 10),
            new Move("Takedown", 100)
        };
    }
}
