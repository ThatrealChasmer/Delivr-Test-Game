using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, transform.parent.position) >= 1000)
        {
            Destroy(gameObject);
        }
    }
}
