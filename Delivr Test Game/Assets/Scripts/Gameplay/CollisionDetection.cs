using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public Ship ship;

    void OnCollisionEnter(Collision col)
    {
        if(col.collider.CompareTag("Asteroid") && ship.dead == false)
        {
            ship.dead = true;
            ship.Death();
        }
    }
}
