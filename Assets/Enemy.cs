using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    
    public int HP = 100;
    public Animator animator;
    public int damageAmount = 20;
    public int scoreWhenDie;
    public ScoreSystem scoreSystem;
    public AudioSource hitSFX;
    public AudioSource dieSFX;

    public static int hitung;
    public static float score;
    void start()
    {
        hitung = 0;
        score = 0;
        // SetHitungText();
        // SetScoreText();
        // HighScoreUI.text = "High Score : " + Mathf.Round(PlayerHighScore).ToString();

        // SetHitunggText();
    }

    public void TakeDamage(int damageAmount){

        HP -= damageAmount;
        if(HP <= 0){

            animator.SetTrigger("die");
            dieSFX.Play();
            GetComponent<Collider>().enabled = false;
            scoreSystem.SetPlayerSCore(scoreSystem.playerCurrentScore + this.scoreWhenDie);

            

            Destroy(gameObject,3);
            // hitung += 100;
            // score +=100;
            // SetHitungText();
            // SetScoreText();
            
            
            // HighScoreUI.text = "High Score : " + Mathf.Round(PlayerHighScore).ToString();

            // SetHitunggText();
            
        }else{
            hitSFX.Play();
            animator.SetTrigger("damage");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            transform.parent = other.transform;
           
        }
    }


        
    
}

