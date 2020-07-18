using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    // This is called FixedUpdate because we are using physics 
    void FixedUpdate()
    {
        // adds a forward force to the rigid body
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // add x force when right arrow key is pressed
        if (Input.GetKey("right"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // add x force when left arrow key is pressed
        if (Input.GetKey("left"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // check if player has fallen 
        if (rb.position.y < -1f) 
        {
            FindObjectOfType<GameManager>().GameOver(); 
        }
    }
}
