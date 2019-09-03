using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameSettings settings;

    public Text hsValue;

    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("highscore"))
        {
            PlayerPrefs.SetInt("highscore", 0);
        }

        hsValue.text = PlayerPrefs.GetInt("highscore").ToString();
    }

    public void PlayButton()
    {
        SessionInfo.currentScore = 0;
        SessionInfo.lives = settings.lives;
        SessionInfo.playing = true;
        SceneManager.LoadScene("Gameplay");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
