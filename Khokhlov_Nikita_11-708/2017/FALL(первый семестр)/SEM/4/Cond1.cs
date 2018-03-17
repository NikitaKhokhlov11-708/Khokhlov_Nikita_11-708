using System;

class Cond1 {
    public enum Figures {bishop, knight, rook, queen, king};
  
    public static void Main (string[] args)
    {
        Figures fig = (Figures)Enum.Parse(typeof(Figures), Console.ReadLine());
        string from = Console.ReadLine();
        string to = Console.ReadLine();
        Console.WriteLine (fig + " " + CheckMoveCorrectness(from, to, fig));
    }
  
    public static bool CheckMoveCorrectness(string from, string to, Figures fig)
    {
        var dx = Math.Abs(to[0] - from[0]);
        var dy = Math.Abs(to[1] - from[1]);
    
        switch (fig) {
            case Figures.queen:
                return (dx != 0 || dy != 0) && (dx == dy || dx == 0 || dy == 0);
    
            case Figures.bishop:
                return (dx == dy && dx != 0);
        
            case Figures.knight:
                return ((dx == 2 && dy == 1) || (dx == 1 && dy == 2));
    
            case Figures.rook:
                return (dx != 0 || dy != 0) && (dx == 0 || dy == 0);
    
            case Figures.king:
                return (dx == 1 || dy == 1) && (dx == 0 || dy == 0 || dx == dy);
            }

        return false;
    }
}