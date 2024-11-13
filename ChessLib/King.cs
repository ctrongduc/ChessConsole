using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib
{
    public class King : Piece
    {
        protected override char Symbol => '♚';

        public King(int x, int y, bool isWhite) : base(x, y, isWhite)
        {
        }

        public override List<(int, int)> ValidMoves()
        {
            // King can move one square in any direction
            List<(int, int)> moves = new List<(int, int)>()
            {
                (position.Item1- 1, position.Item2 - 1), (position.Item1, position.Item2 - 1), (position.Item1 + 1, position.Item2 - 1),
                (position.Item1 - 1, position.Item2), (position.Item1 + 1, position.Item2),
                (position.Item1 - 1, position.Item2 + 1), (position.Item1, position.Item2 + 1), (position.Item1 + 1, position.Item2 + 1)
            };

            // Filter out moves that are out of bounds
            moves = moves.Where(move => move.Item1 >= 0 && move.Item1 < 8 && move.Item2 >= 0 && move.Item2 < 8).ToList();

            return moves;
        }
    }
}
