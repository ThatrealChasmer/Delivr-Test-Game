using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameSettings settings;

    public Text score;
    public Text highscore;

    void OnEnable()
    {
        score.text = SessionInfo.currentScore.ToString();
        highscore.text = PlayerPrefs.GetInt("highscore").ToString();
    }

    public void RestartButton()
    {
        SessionInfo.Clear();
        SessionInfo.lives = settings.lives;
        SceneManager.LoadScene("Gameplay");
    }

    public void MainMenuButton()
    {
        SessionInfo.Clear();
        SceneManager.LoadScene("MainMenu");
    }
}
