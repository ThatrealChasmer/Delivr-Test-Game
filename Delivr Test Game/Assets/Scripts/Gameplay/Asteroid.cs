using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public GameSettings settings;

    public string type;

    public int hp;

    public int score;

    public GameObject smallerAsteroid;

    public GameObject AsteroidsParent;

    public int toSpawn;

    // Start is called before the first frame update
    void Start()
    {
        if(type == "big")
        {
            hp = settings.bigHP;
            score = settings.bigScore;
        }
        else if(type == "medium")
        {
            hp = settings.mediumHP;
            score = settings.mediumScore;
        }
        else if(type == "small")
        {
            hp = settings.smallHP;
            score = settings.smallScore;
        }

        toSpawn = settings.toSpawn;

        AsteroidsParent = GameObject.Find("Asteroids");
        GetComponent<Rigidbody>().AddForce(100 * new Vector3(Random.Range(5, 15), Random.Range(5, 15), Random.Range(5, 15)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("Bullet") && hp > 0)
        {
            hp--;
            if(hp <= 0)
            {
                SessionInfo.currentScore += score;
                Destroy(gameObject);
                if(smallerAsteroid != null)
                {
                    for(int i = 0; i < toSpawn; i++)
                    {
                        Vector3 spawnPoint = new Vector3(Random.Range(-3, 3), Random.Range(-3, 3), Random.Range(-3, 3));
                        Instantiate(smallerAsteroid, transform.position + spawnPoint, Quaternion.identity, AsteroidsParent.transform);
                    }
                }
            }
        }
    }
}
