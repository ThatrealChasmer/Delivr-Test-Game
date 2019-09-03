using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SessionInfo
{
    public static int currentScore = 0;
    public static int lives;
    public static bool playing;
    public static bool pause = false;

    public static void Clear()
    {
        currentScore = 0;
        lives = 0;
        pause = false;
    }
}
