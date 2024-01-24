using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool hasGameEnded = false;
    public float restartDelay = 1f;
    public GameObject levelCompleteUI;
    public void EndGame()
    {
        if (!hasGameEnded)
        {
            hasGameEnded = true;
            Debug.Log("Game Over.");
            Invoke("Restart", restartDelay);
        }
    }

    public void CompleteLevel()
    {
        Debug.Log("Level is completed.");
        levelCompleteUI.SetActive(true);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
