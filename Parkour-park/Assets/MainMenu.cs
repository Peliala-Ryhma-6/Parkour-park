using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
        
    }

    public void QuitGame ()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        Debug.Log("Quitted from unity editor!");
#else
            Debug.log("QUIT!");
            Application.Quit();
#endif
    }
}
