using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text hitungText;
    public static float hitung;
    // public Text hitungText;

    // Start is called before the first frame update
    void Start()
    {
        hitungText.text = "Score: " + Mathf.Round(Enemy.hitung).ToString();

        // hitung = 0;
        // SetHitungText();   
    }

    // Update is called once per frame
    // void Update()
    // {
    //     hitung += 100;
    //         SetHitungText();
    // }

    // void SetHitungText()
    // {
    //     hitungText.text = "Score: " + hitung.ToString();
    // }
}
