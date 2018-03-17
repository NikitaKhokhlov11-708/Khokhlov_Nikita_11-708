using System;

class Cond2 {
    public enum Figures {bishop, knight, rook, queen, king};
  
    public static void Main (string[] args) {
        int x;
        int y;
        int z;
        int a;
        int b;
    
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());
        z = int.Parse(Console.ReadLine());
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
    
        Console.WriteLine (CheckSize(x, y, z, a, b));
    }
  
    public static bool CheckSize(int x, int y, int z, int a, int b)
    {
        if (x <= a) {
            if (y <= b || z <= b) return true;
        }
        else if (y <= a) {
            if (x <= b || z <= b) return true;
        }
        else if (z <= a) {
            if (x <= b || y <= b) return true;
        }

        return false;
    }
}