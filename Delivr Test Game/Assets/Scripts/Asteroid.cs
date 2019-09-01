using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public int hp;

    public GameObject smallerAsteroid;

    public GameObject AsteroidsParent;

    // Start is called before the first frame update
    void Start()
    {
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
                Destroy(gameObject);
                if(smallerAsteroid != null)
                {
                    Vector3 spawnPoint = new Vector3(Random.Range(1, 3), Random.Range(1, 3), Random.Range(1, 3));
                    Instantiate(smallerAsteroid, transform.position + spawnPoint, Quaternion.identity, AsteroidsParent.transform);
                    Instantiate(smallerAsteroid, transform.position - spawnPoint, Quaternion.identity, AsteroidsParent.transform);
                }
            }
        }
    }
}
