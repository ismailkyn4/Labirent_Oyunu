using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket2 : MonoBehaviour
{
    float speed=6f;
    public Rigidbody top;
    void Start()
    {
        top = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        top.velocity = new Vector3(speed * Input.GetAxis("Horizontal"), top.velocity.y, top.velocity.z);
        top.velocity = new Vector3( top.velocity.x, top.velocity.y,speed * Input.GetAxis("Vertical"));
    }

}
