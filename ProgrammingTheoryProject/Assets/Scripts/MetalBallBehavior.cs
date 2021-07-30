using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalBallBehavior : BallBehavior //INHERITANCE
{

    private void Start()
    {
        ballRb = GetComponent<Rigidbody>();
    }

    //POLYMORPHISM
    //Causes the ball to receive an impact
    public override void OnMouseDown()
    {
        CalculateForce(0.2f);
    }
}
