using UnityEngine;

public class MoveBall : MonoBehaviour
{
    Rigidbody rigidBodyFromBall;

    private void Start()
    {
        rigidBodyFromBall = GetComponent<Rigidbody>();
        rigidBodyFromBall.maxAngularVelocity = 15;
    }
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal, 0, 0);
        rigidBodyFromBall.AddForce(movement);
    }
}
