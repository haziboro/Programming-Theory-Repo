using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassBallBehavior : BallBehavior
{

    private void Start()
    {
        ballRb = GetComponent<Rigidbody>();
    }

    //Causes the ball to receive an impact
    public override void OnMouseDown()
    {
        //Glass ball gets destroyed if hit too hard
        if (ClickerController.instance.clickerPower > 5)
        {
            ParticleSystem explosion = GameObject.Find("GlassBreak").GetComponent<ParticleSystem>();
            explosion.transform.position = transform.position;
            explosion.Play();
            Destroy(gameObject);
        }
        else
        {
            CalculateForce();
        }
    }

}
