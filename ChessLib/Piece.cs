namespace ChessLib
{
    public abstract class Piece
    {
        protected (int, int) position;
        protected bool isWhite;
        protected bool isCaptured;

        protected virtual char Symbol { get; set; }

        public Piece(int x, int y, bool isWhite)
        {
            this.position = (x, y);
            this.isWhite = isWhite;
            this.isCaptured = false;
        }

        public virtual void Move(int x, int y)
        {
            this.position = (x, y);
        }

        public virtual void Capture()
        {
            this.isCaptured = true;
        }

        public virtual List<(int, int)> ValidMoves()
        {
            return new List<(int, int)>();
        }

        public virtual void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write($" {((isWhite) ? ((char) (this.Symbol + 6)) : this.Symbol)} ");
        }
    }
}
