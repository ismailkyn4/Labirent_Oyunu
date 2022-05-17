using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraRotate : MonoBehaviour
{
    float yatayhiz=2.0f,dikeyhiz = 2.0f;

    float yatay = 0.0f;
    float dikey = 0.0f;
    void Start()
    {
        
    }


    void Update()
    {
     /*   yatay -=yatayhiz * Input.GetAxisRaw("Mouse Y");
        dikey +=dikeyhiz * Input.GetAxisRaw("Mouse X");
        transform.localEulerAngles=new Vector3(yatay, dikey, 0f); */
    }
}
