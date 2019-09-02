using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ship : MonoBehaviour
{
    public bool dead;

    public void Death()
    {
        SessionInfo.lives--;
        Debug.Log(SessionInfo.lives);
        if(SessionInfo.lives <= 0)
        {
            if(SessionInfo.currentScore > PlayerPrefs.GetInt("highscore"))
            {
                PlayerPrefs.SetInt("highscore", SessionInfo.currentScore);
                PlayerPrefs.Save();
            }

            SceneManager.LoadScene("MainMenu");
        }
        else
        {
            SceneManager.LoadScene("Gameplay");
        }
    }
}
