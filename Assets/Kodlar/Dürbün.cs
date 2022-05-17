using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Dürbün : MonoBehaviour
{
    public Camera mainkamera;
    int zoom = 10;
    int normal = 60;
    int sayi = 0;
    public Material renk;
    void Start()
    {
        renk.color = Color.green;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            sayi++;
            if (sayi%2==0)
            {
                mainkamera.fieldOfView = normal;
            }
            if (sayi % 2 == 1)
            {
                mainkamera.fieldOfView = zoom;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sayi++;
            renk.color = Color.blue;
            if (sayi % 2 == 0)
            {
                renk.color = Color.green;
            }
        }
    }
}
