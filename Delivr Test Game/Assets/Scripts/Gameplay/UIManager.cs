using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public GameObject ui;
    public GameObject lifePrefab;
    public GameObject pauseScreen;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < SessionInfo.lives; i++)
        {
            Instantiate(lifePrefab, ui.transform.position + new Vector3(10 + i * (lifePrefab.GetComponent<RectTransform>().sizeDelta.x), -10, 0), Quaternion.identity, ui.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = SessionInfo.currentScore.ToString();

        if(Input.GetKeyDown(KeyCode.Escape) && SessionInfo.playing == true)
        {
            if (SessionInfo.pause == false)
            {
                Time.timeScale = 0;
                pauseScreen.SetActive(true);
                SessionInfo.pause = true;
            }
            else
            {
                Time.timeScale = 1;
                pauseScreen.SetActive(false);
                SessionInfo.pause = false;
            }
        }
    }

    public void Resume()
    {
        if(SessionInfo.pause == true)
        {
            pauseScreen.SetActive(false);
            SessionInfo.pause = false;
            Time.timeScale = 1;
        }
    }
}
