using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;

    public float delay;
    float timer = 0;

    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && timer <= 0)
        {
            Shoot();
            timer = delay;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform);
        bullet.GetComponent<Rigidbody>().velocity = transform.forward * 100;
    }
}
