using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib
{
    public class Queen : Piece
    {
        protected override char Symbol => '♕';

        public Queen(int x, int y, bool isWhite) : base(x, y, isWhite)
        {
        }

        public override List<(int, int)> ValidMoves()
        {
            List<(int, int)> moves = new List<(int, int)>();

            // Queen can move any number of squares in any direction
            for (int i = 1; i < 8; i++)
            {
                moves.Add((position.Item1 - i, position.Item2 - i));
                moves.Add((position.Item1, position.Item2 - i));
                moves.Add((position.Item1 + i, position.Item2 - i));
                moves.Add((position.Item1 - i, position.Item2));
                moves.Add((position.Item1 + i, position.Item2));
                moves.Add((position.Item1 - i, position.Item2 + i));
                moves.Add((position.Item1, position.Item2 + i));
                moves.Add((position.Item1 + i, position.Item2 + i));
            }

            // Filter out moves that are out of bounds
            moves = moves.Where(move => move.Item1 >= 0 && move.Item1 < 8 && move.Item2 >= 0 && move.Item2 < 8).ToList();

            return moves;
        }
    }
}
}
