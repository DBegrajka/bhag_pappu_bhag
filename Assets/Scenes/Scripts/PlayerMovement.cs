using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBody;
    public float forwardForce = 2000f;
    public float sidewayForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rigidBody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
