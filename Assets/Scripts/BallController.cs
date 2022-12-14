using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 resetPosition;
    private Rigidbody2D rig;
    public float maxSpeed;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, -1);
    }

    public void IncreaseSpeed(float magnitude)
    {
        rig.velocity *= magnitude;
        if (rig.velocity.magnitude > maxSpeed)
        {
            rig.velocity = Vector2.ClampMagnitude(rig.velocity, maxSpeed);
        }
    }
}
