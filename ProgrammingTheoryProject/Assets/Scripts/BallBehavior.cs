using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public string ballName { get; private set; } //ENCAPSULATION

    public Rigidbody ballRb;

    // Start is called before the first frame update
    void Start()
    {
        ballRb = GetComponent<Rigidbody>();
    }

    //Causes the ball to receive an impact
    public virtual void OnMouseDown()
    {
        CalculateForce();
    }

    //ABSTRACTION
    //Calculates a force towards the camera direction
    protected void CalculateForce(float forceMultipler = 1.0f)
    {
        Vector3 camDir = ClickerController.instance.mainCamera.transform.forward;
        ballRb.AddForce(camDir 
            * ClickerController.instance.clickerPower
            * forceMultipler, ForceMode.Impulse);
    }

}
