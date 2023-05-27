using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoparaVHI : MonoBehaviour
{
    public List<WheelCollider> colliders=new List<WheelCollider>();
    [SerializeField] private GameObject[] wheels;

    // 0 --> FL, 1 --> FR, 2 --> RL, 3 --> RR.

    public float MotorForce;
    public float wheelsRotation;
    public float SteerForce;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0;i < wheels.Length;i++)
        {
            colliders.Add(wheels[i].GetComponent<WheelCollider>());
        }
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float v = Input.GetAxis("Vertical") * MotorForce;
        float h = Input.GetAxis("Horizontal") * SteerForce;
        colliders[3].motorTorque = v;
        colliders[2].motorTorque = v;

        for(int i=0;i < wheels.Length;i++)
        {
            UpdateSingleWheel(colliders[i],wheels[i].transform);
            //wheels[i].transform.Rotate(colliders[i].rpm/60*360*Time.deltaTime,0,0);
        }
        
        colliders[1].steerAngle = h;
        colliders[0].steerAngle = h;

        

    }    

        private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform) {
            Vector3 pos;
            Quaternion rot; 
            wheelCollider.GetWorldPose(out pos, out rot);
            wheelTransform.rotation = rot;
            wheelTransform.position = pos;
    }
}
