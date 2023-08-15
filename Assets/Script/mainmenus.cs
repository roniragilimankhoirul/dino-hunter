using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenus : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public void Level1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Lvl1");
    }

    public void KembaliGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void KembaliMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void KembaliMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Lvl2");
    }

    public void Level3()
    {
        SceneManager.LoadScene("Lvl3");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    public void KeluarGame()
    {
        Application.Quit();
        Debug.Log("keluar");
    }
}
