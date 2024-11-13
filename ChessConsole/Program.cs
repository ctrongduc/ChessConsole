


namespace ChessConsole;

internal class Program
{
    static int cursorX = 0;
    static int cursorY = 0;
    static char[,] board = new char[8, 8];
    static int selectedX, selectedY;
    static bool pieceSelected = false;

    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! This is a chess game.");
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        InitializeBoard();

        while (true)
        {
            Console.Clear();
            DrawBoard();
            HandleKeyPress();
        }
    }

    private static void HandleKeyPress()
    {
        if (pieceSelected)
        {
            MovePiece();
        }
        else
        {
            MoveCursor();
        }
    }

    private static void MoveCursor()
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey();

        switch (keyInfo.Key)
        {
            case ConsoleKey.UpArrow:
                cursorY = Math.Max(cursorY - 1, 0);
                break;
            case ConsoleKey.DownArrow:
                cursorY = Math.Min(cursorY + 1, 7);
                break;
            case ConsoleKey.LeftArrow:
                cursorX = Math.Max(cursorX - 1, 0);
                break;
            case ConsoleKey.RightArrow:
                cursorX = Math.Min(cursorX + 1, 7);
                break;
            case ConsoleKey.Enter:
                pieceSelected = true;
                selectedX = cursorX;
                selectedY = cursorY;
                break;
        }
    }

    private static void MovePiece()
    {
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        switch (keyInfo.Key)
        {
            case ConsoleKey.UpArrow:
                selectedY = Math.Max(selectedY - 1, 0);
                break;
            case ConsoleKey.DownArrow:
                selectedY = Math.Min(selectedY + 1, 7);
                break;
            case ConsoleKey.LeftArrow:
                selectedX = Math.Max(selectedX - 1, 0);
                break;
            case ConsoleKey.RightArrow:
                selectedX = Math.Min(selectedX + 1, 7);
                break;
            case ConsoleKey.Enter:
                pieceSelected = false;
                board[selectedY, selectedX] = board[cursorY, cursorX];
                board[cursorY, cursorX] = ' ';
                break;
            case ConsoleKey.Escape:
                pieceSelected = false;
                break;
        }
    }

    private static void InitializeBoard()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (i == 1)
                {
                    board[i, j] = '♙';
                }
                else if (i == 6)
                {
                    board[i, j] = '♟';
                }
                else if (i == 0 || i == 7)
                {
                    switch (j)
                    {
                        case 0:
                        case 7:
                            board[i, j] = (i == 0) ? '♖' : '♜'; // Rooks
                            break;
                        case 1:
                        case 6:
                            board[i, j] = (i == 0) ? '♘' : '♞'; // Knights
                            break;
                        case 2:
                        case 5:
                            board[i, j] = (i == 0) ? '♗' : '♝'; // Bishops
                            break;
                        case 3:
                            board[i, j] = (i == 0) ? '♕' : '♛'; // Queens
                            break;
                        case 4:
                            board[i, j] = (i == 0) ? '♔' : '♚'; // Kings
                            break;
                    }
                }
                else
                {
                    board[i, j] = ' ';
                }
            }
        }
    }

    private static void DrawBoard()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (pieceSelected && i == selectedY && j == selectedX)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                }
                else if (i == cursorY && j == cursorX)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                }
                else 
                {
                    Console.BackgroundColor = (i + j) % 2 == 0 ? ConsoleColor.White : ConsoleColor.Gray;
                }
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write($" {board[i, j]} ");
                Console.ResetColor();
                
                if (j < 7)
                {
                    Console.Write("|");
                }
            }
            Console.WriteLine();
            if (i < 7)
            {
                Console.WriteLine("---+---+---+---+---+---+---+---");
            }
        }
    }
}
