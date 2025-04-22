using UnityEngine;

public class CarController : MonoBehaviour
{
    public WheelCollider frontLeft, frontRight, backLeft, backRight;
    public float acceleration = 500f, breakForce = 300f, turnAngle = 15f;
    public float currentAcceleration = 0f, currentBreakForce = 0f, currentTurnAngle = 0f;
    void FixedUpdate()
    {
        currentAcceleration = acceleration * Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //currentBreakForce = breakForce;
            currentAcceleration = 0;
        }

        else currentBreakForce = 0f;

        frontRight.motorTorque = currentAcceleration;
        frontLeft.motorTorque = currentAcceleration;
        frontRight.brakeTorque = currentBreakForce;
        frontLeft.brakeTorque = currentBreakForce;
        backRight.brakeTorque = currentBreakForce;
        backLeft.brakeTorque = currentBreakForce;
        currentTurnAngle = turnAngle * Input.GetAxis("Horizontal");
        frontRight.steerAngle = currentTurnAngle;
        frontLeft.steerAngle = currentTurnAngle;
    }
}