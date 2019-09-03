using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameSettings settings;

    public Rigidbody rb;

    public Transform hull;

    public float maxSpeed;

    public float maxAcc;

    public float turnAcc;

    public float maxTurnSpeed;

    public float delay = 2;

    // Start is called before the first frame update
    void Start()
    {
        maxSpeed = settings.maxSpeed;
        maxAcc = settings.maxAcc;
        turnAcc = settings.turnAcc;
        maxTurnSpeed = settings.maxTurnSpeed;
        delay = settings.delay;

        Time.timeScale = 0;
        StartCoroutine(waitTime(delay));
    }

    IEnumerator waitTime(float delay)
    {
        while(true)
        {
            yield return new WaitForSecondsRealtime(delay);
            Time.timeScale = 1;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!SessionInfo.pause && SessionInfo.playing)
        {
            float Horizontal = Input.GetAxis("Horizontal");
            float Vertical = Input.GetAxis("Vertical");

            Vector3 vDiff = transform.forward * maxSpeed - rb.velocity;
            vDiff *= maxAcc / vDiff.magnitude;
            rb.AddForce(vDiff, ForceMode.VelocityChange);

            Vector3 turn = -1 * (turnAcc * (-transform.up * Horizontal + transform.right * Vertical) + rb.angularVelocity);
            float mag = turn.magnitude;
            turn.Normalize();
            rb.AddTorque(turn * Mathf.Clamp(mag, 0, maxTurnSpeed * Time.fixedDeltaTime), ForceMode.VelocityChange);

            hull.localRotation = Quaternion.Euler(0, 0, Horizontal * -1f * 15);
        }
    }
}
