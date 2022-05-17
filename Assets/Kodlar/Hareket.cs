using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hareket : MonoBehaviour
{
    public float speed = 0.1f;
    int durdur = 0;
    
    //int hiz = 5;
    //Rigidbody yercekimi;
    void Start()
    {
        //yercekimi = GetComponent<Rigidbody>();
        

    }

    void Update()
    {
       
        hareketlenme();
    }
    public void hareketlenme()
    {
        /*  float yatay = Input.GetAxisRaw("Horizontal"); //Unity ekranından Edit/Project Setting/input kısmından horizantalin tam yazımına göre yazmamız gerekli. //kullanıcıdan gelen sağ sol ok tuşları ve a,d tuşlarını kabul eder
      float dikey = Input.GetAxisRaw("Vertical"); //kullanıcıdan gelen yukarı aşağı ok tuşları ve w,s tuşlarını kabul eder
      Vector3 yerdegistirme = new Vector3(yatay,0,dikey); //anlık olarak kullanıcının basmış olduğu tuşlara göre hareket 
      yercekimi.AddForce(hiz*yerdegistirme);//yer çekimine kuvvet uygular */
        //float xDirection = Input.GetAxis("Horizontal");
        //float zDirection = Input.GetAxis("Vertical");

        //Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);
        //transform.position += moveDirection * speed;
        //alttaki kodda ivmelenme olmuyor.

        /*if(durdur==1)
        {
            enabled = false;
        }*/

        
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "kup")
        {
            durdur++;
        }
    }

}
