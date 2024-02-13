using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    FadeInOut fade;

    private void Start()
    {
        fade = FindObjectOfType<FadeInOut>();
        fade.FadeOut();
    }

    public void PlayGame ()
    {
        StartCoroutine(ChangeScene());
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

    public IEnumerator ChangeScene()
    {
        Time.timeScale = 1f;
        fade.FadeIn();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("SampleScene");
    }
}
