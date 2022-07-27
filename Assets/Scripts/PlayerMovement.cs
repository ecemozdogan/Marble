using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed = 6000f;
    public float sidewaysSpeed = 10f;

    public leftButtonScript left;
    public rightButtonScript right;

    public Rigidbody rb;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardSpeed * Time.deltaTime);

        if (left.leftButtonHold)
        {
            rb.AddForce(-sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (right.rightButtonHold)
        {
            rb.AddForce(sidewaysSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < 0.8f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    

}
