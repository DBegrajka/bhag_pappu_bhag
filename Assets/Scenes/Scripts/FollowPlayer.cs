using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Transform patient;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        //transform.position = player.position + offset;
        transform.position = patient.position + offset;
    }
}
