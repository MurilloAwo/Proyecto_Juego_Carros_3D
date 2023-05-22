using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoparaVHI : MonoBehaviour
{

    public float MotorForce;
    public WheelCollider colicionadorruedasFL;
    public WheelCollider colicionadorruedasFR;
    public WheelCollider colicionadorruedasRL;
    public WheelCollider colicionadorruedasRR;
    public float SteerForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical") * MotorForce;
        float h = Input.GetAxis("Horizontal") * SteerForce;
        colicionadorruedasRR.motorTorque = v;
        colicionadorruedasRL.motorTorque = v;

        colicionadorruedasFR.steerAngle = h;
        colicionadorruedasFL.steerAngle = h;

    }    
}
