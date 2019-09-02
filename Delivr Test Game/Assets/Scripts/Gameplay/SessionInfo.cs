using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SessionInfo
{
    public static int currentScore = 0;
    public static int lives;

    public static void Clear()
    {
        currentScore = 0;
        lives = 0;
    }
}
