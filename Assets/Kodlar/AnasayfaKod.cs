using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnasayfaKod : MonoBehaviour
{
    void Start()
    {
        
    }

    public void play()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }
    public void anasayfa_btn()
    {
        SceneManager.LoadScene(0);
    }
    public void help()
    {
        SceneManager.LoadScene(1);
    }
}
