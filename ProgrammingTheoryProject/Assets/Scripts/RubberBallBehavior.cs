using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubberBallBehavior : BallBehavior
{

    private void Start()
    {
        ballRb = GetComponent<Rigidbody>();
        GetComponent<Collider>().material.bounciness = 0.5f;
    }

    //Causes the ball to receive an impact
    public override void OnMouseDown()
    {
        CalculateForce(5.0f);
    }
}
