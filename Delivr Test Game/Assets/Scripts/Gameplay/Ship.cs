using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ship : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.collider.CompareTag("Asteroid"))
        {
            
            SceneManager.LoadScene("MainMenu");
        }
    }
}
