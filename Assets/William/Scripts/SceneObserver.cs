using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneObserver : MonoBehaviour
{
    public static bool GameIsPaused = false;
    int whichScene;
    public GameObject pauseMenuUI;
    public void PlayGame()
    {
        //SceneManager.LoadScene(1);
        whichScene = 1;
        StartCoroutine(SceneDelay());
    }
    public void GameOver()
    {
        //SceneManager.LoadScene(0);
        whichScene = 0;
        StartCoroutine(SceneDelay());
    }
    IEnumerator SceneDelay()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(whichScene);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Paused()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void quit()
    {
        Time.timeScale = 1f;
        //SceneManager.LoadScene(0);
        whichScene = 0;
        StartCoroutine(SceneDelay());
    }
}
