using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneEnd : MonoBehaviour
{
    // Start is called before the first frame update
    public void ExitTheScene()
    {
        SceneManager.LoadScene("EndinScene");
    }

    public void ExitGame()
    {
        // exit the game for real play
        //Application.Quit();
        //does not work in Unity since it would  lose all settings. so:
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
