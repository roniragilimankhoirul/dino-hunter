using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptTimer : MonoBehaviour
{
    public Text text;
    public float Waktu;
    public float BaseWaktu;
    public GameObject waktuHabis;

    // Start is called before the first frame update
    // void Start()
    // {
    //     text = GetComponent<Text>();
    // }

    // Update is called once per frame

    private void Start() {
      Waktu = BaseWaktu;
    }
    void SetText()
    {
        int Menit = Mathf.FloorToInt(Waktu / 60);
        int Detik = Mathf.FloorToInt(Waktu % 60);
          Waktu -=Time.deltaTime;
        // if(waktu < 0)
        // waktu = 0;
          Cursor.lockState = CursorLockMode.None;
        text.text = Menit.ToString("00") +":"+ Detik.ToString("00");
    }

    public void ResetWaktu(){
      Waktu = BaseWaktu;
    }

    void Update()
    {
        SetText();
        if(Waktu <= 1)
        {
            Time.timeScale = 0;
            
            waktuHabis.gameObject.SetActive(true);
        }
    }
}

