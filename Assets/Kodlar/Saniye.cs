using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Saniye : MonoBehaviour
{
    int sure = 15;
    public TextMeshProUGUI sureText;
    public GameObject panel,karakter,durdur_btn,gerigelme_btn;
    void Start()
    {
        InvokeRepeating("ZamanAzalt", 1, 1);
    }

    public void ZamanAzalt()
    {
        sure--;
        sureText.text = "" +sure;
        if (sure == 0)
        {
            CancelInvoke();
            
            Time.timeScale=0.0f;
            panel.SetActive(true);
            durdur_btn.SetActive(false);
            gerigelme_btn.SetActive(false);

        }
    }
}
