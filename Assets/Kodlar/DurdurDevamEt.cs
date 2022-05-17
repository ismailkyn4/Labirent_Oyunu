using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DurdurDevamEt : MonoBehaviour
{
    public GameObject devametlogo,logo2,text1,evet_btn,hayir_btn,durdurma_btn,geri_btn,oyundurdurma_pnl;
    
    public void durdur()
    {
        devametlogo.SetActive(true);
        logo2.SetActive(false);
        geri_btn.SetActive(false);
        oyundurdurma_pnl.SetActive(true);
        Time.timeScale = 0f;
    }
    public void devamet()
    {
        devametlogo.SetActive(false);
        logo2.SetActive(true);
        geri_btn.SetActive(true);
        oyundurdurma_pnl.SetActive(false);

        Time.timeScale = 1f;
    }
    public void anasayfa_donus()
    {
        text1.SetActive(true);
        evet_btn.SetActive(true);
        hayir_btn.SetActive(true);
        durdurma_btn.SetActive(false);
        Time.timeScale=0f;
    }
    public void evet()
    {
        SceneManager.LoadScene(0);
    }
    public void hayir()
    {
        text1.SetActive(false);
        evet_btn.SetActive(false);
        hayir_btn.SetActive(false);
        durdurma_btn.SetActive(true);

        Time.timeScale = 1f;
    }
}
