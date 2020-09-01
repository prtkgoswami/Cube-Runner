using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sideForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hi!");
        rb.useGravity = true;

    }

    
    // Fixed Update is used to mess with Physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Side Movements
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // Jump Movement
        if (Input.GetKey(KeyCode.Space))
        {
            if (rb.position.y <= 5)
            {
                rb.AddForce(0, sideForce * 2 * Time.deltaTime, 0, ForceMode.VelocityChange);
            }
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    // Update is called once per frame
    // Used to get user input
    void Update()
    {
        
    }
}
