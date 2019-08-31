using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;

    public int speed;

    public int angleX;
    public int angleY;
    public int angleZ;

    public float smooth;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddRelativeForce(new Vector3(0, 0, speed));

        float tiltX = Input.GetAxis("Vertical") * angleX;
        float tiltY = Input.GetAxis("Horizontal") * angleY;

        Debug.Log(tiltX + ", " + tiltY);

        Quaternion target = Quaternion.Euler(new Vector3(transform.rotation.x + tiltX,transform.rotation.y + tiltY, 0));

        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }
}
