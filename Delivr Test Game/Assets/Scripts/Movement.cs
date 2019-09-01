using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject camera;

    public float maxSpeed;

    public float maxAcc;

    public float turnSpeed;

    public float maxTurnSpeed;

    public float smooth;

    Vector3 currentRotation = new Vector3(0,0,0);
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 vDiff = transform.forward * maxSpeed - rb.velocity; //Difference between current velocity and intended velocity.
        if (vDiff.magnitude > maxAcc)
            vDiff *= maxAcc / vDiff.magnitude;
        rb.AddForce(vDiff, ForceMode.VelocityChange);

        Vector3 turn = -1 * (turnSpeed * (-transform.up * Horizontal + transform.right * Vertical) + rb.angularVelocity);
        float mag = turn.magnitude;
        turn.Normalize();
        rb.AddTorque(turn * Mathf.Clamp(mag, 0, maxTurnSpeed * Time.fixedDeltaTime), ForceMode.VelocityChange);
    }
}
