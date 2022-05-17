using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BitisCarpma : MonoBehaviour
{
    int sahnenum = 2;
    public GameObject panel,karakter,durdur_btn,baslat_btn,anasayfa_btn,yeni_bolum_btn;
    public Camera anakamera;
    

    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name=="kup")
        {

            panel.SetActive(true);
            Time.timeScale = 0.0f;
            durdur_btn.SetActive(false);
            baslat_btn.SetActive(false);
            anasayfa_btn.SetActive(false);
            yeni_bolum_btn.SetActive(true);
            
        }
        
    }
    public void yenidenbasla_btn()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }
    public void yenidenbasla_btn2()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1f;
    }
    public void yenidenbasla_btn3()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1f;
    }
    public void yenidenbasla_btn4()
    {
        SceneManager.LoadScene(5);
        Time.timeScale = 1f;
    }
    public void cikis()
    {
        SceneManager.LoadScene(0);
    }
    public void yeni_bolum_basla()
    {

        //for (int i = 0; i < SceneManager.sceneCount; i++)
        //{
        //    Scene scene = SceneManager.GetSceneAt(i);
        //    if (scene.name == "Sahne2")
        //    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1f;
    }
    public void yeni_bolum_basla2()
    {
            SceneManager.LoadScene(4);
        Time.timeScale = 1f;
    }
    public void yeni_bolum_basla3()
    {
        SceneManager.LoadScene(5);
        Time.timeScale = 1f;
    }


}

