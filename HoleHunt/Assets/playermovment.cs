using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovment : MonoBehaviour {
    public Rigidbody rb;
    public float forwardForce = 200f;





    // Update is called once per frame
    void Update () {

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 750 * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -750 * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-750 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(750 * Time.deltaTime, 0, 0);
        }


    }
}
