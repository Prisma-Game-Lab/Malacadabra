using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitonDuration = 1f;
    
    public void MainMenu()
    {
        SceneManager.LoadScene(0);

    }

    public void AdvanceScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadWinScene()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void SairJogo()
    {
        //Debug.Log ("Sair!");
        Application.Quit();
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitonDuration);

        SceneManager.LoadScene(levelIndex);
    }
}
