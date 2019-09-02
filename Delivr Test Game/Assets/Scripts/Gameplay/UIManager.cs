using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public GameObject ui;
    public GameObject lifePrefab;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < SessionInfo.lives; i++)
        {
            Instantiate(lifePrefab, ui.transform.position + new Vector3(10 + i * (10 + lifePrefab.GetComponent<RectTransform>().sizeDelta.x), -10, 0), Quaternion.identity, ui.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = SessionInfo.currentScore.ToString();
    }
}
