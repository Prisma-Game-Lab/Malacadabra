using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuPrincipal : MonoBehaviour
{
    public void AdvanceScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);

    }

    public void SairJogo()
    {
        Debug.Log ("Sair!");
        Application.Quit();
    }
}
