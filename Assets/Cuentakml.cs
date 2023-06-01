using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cuentakml : MonoBehaviour
{
    public Rigidbody rigid;
    public Image imagen;

    
    void Update()
    {
        float speed = rigid.velocity.magnitude;
        imagen.transform.eulerAngles = new Vector3(0,0,speed*-5 + 150);
    }
}
