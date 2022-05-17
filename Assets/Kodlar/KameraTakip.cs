using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraTakip : MonoBehaviour
{
    Vector3 mesafe;
    public GameObject karakter;
    public Camera anakamera;
    void Start()
    {
       // mesafe = transform.position - karakter.transform.position;
    }

    void Update()
    {
       // transform.position = karakter.transform.position + mesafe;
    }
}
