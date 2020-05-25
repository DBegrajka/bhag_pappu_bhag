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
            GoRight();
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            GoLeft();
        }
        if (rigidBody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.position.x > (Screen.width / 2))
            {
                GoRight();
            }
            if (touch.position.x < (Screen.width / 2))
            {
                GoLeft();
            }
        }
    }

    void GoRight()
    {
        rigidBody.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    void GoLeft()
    {
        rigidBody.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
