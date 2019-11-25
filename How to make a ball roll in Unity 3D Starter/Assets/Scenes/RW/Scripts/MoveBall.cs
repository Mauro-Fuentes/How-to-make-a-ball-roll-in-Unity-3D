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
        float moveHorizontal = Input.GetAxis("Horizontal"); // 1

        Vector3 xMovement = new Vector3(moveHorizontal, 0, 0); // 2

        rigidBodyFromBall.AddForce(xMovement); // 3
    }
}