using System.Collections.Generic;
using System;

namespace RoleplayGame;

public class Luck
{
    private static List<int> Random()
    {
        List<int> numbers= new List<int> ();
        Random rand = new Random();
        int userNumber = 0;
        int gameNumber = rand.Next(101);
        for (int i = 0; i <= 8; i++)
        {
            userNumber = rand.Next(101);
            if (userNumber == gameNumber)
            {
                numbers.Add(1);
            }
            else
            {
                numbers.Add(0);
            }
        }
        return numbers;
    }
    public static bool Lucky()
    {
        if (Random().Contains(1))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}