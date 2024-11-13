using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLib
{
    public class Constants
    {
        public class BlackPieces
        {
            public static readonly int KING = 9812; // ♔
            public static readonly int QUEEN = 9813; // ♕
            public static readonly int ROOK = 9814; // ♖
            public static readonly int BISHOP = 9815; // ♗
            public static readonly int KNIGHT = 9816; // ♘
            public static readonly int PAWN = 9817; // ♙
        }
        
        public class WhitePieces
        {
            public static readonly int KING = 9818; // ♚
            public static readonly int QUEEN = 9819; // ♛
            public static readonly int ROOK = 9820; // ♜
            public static readonly int BISHOP = 9821; // ♝
            public static readonly int KNIGHT = 9822; // ♞
            public static readonly int PAWN = 9823; // ♟
        }
    }
}
